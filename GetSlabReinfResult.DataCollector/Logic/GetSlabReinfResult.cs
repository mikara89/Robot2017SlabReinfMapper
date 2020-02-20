using GenerateIsolines;
using GenerateIsolines.Model;
using RobotOM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static GetSlabReinfResult.DataCollector.Logic.RSATableQueryingResult;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public class GetSlabReinfResult : IGetSlabReinfResult
    {
        public int[] ObjNumbers { get; set; }
        private IRobotApplication robot;
        private RobotStructure str;
        private readonly string panelPath;
        private readonly string edgesPath;
        private readonly CancellationToken ct;
        public List<string> ErrorList { get; set; }

        public bool IsDataCollected { get; internal set; }


        public List<RSA_FE> Panel { get; internal set; }

        public List<Panel> PanelEdges { get; internal set; }

        #region Constructor
    public GetSlabReinfResult(CancellationToken ct,IRobotApplication iapp=null)
        {
            Services.RobotAppService.iapp = iapp;
            Init(iapp);
        }

        public GetSlabReinfResult(IRobotApplication iapp = null)
        {
            Services.RobotAppService.iapp = iapp;
            Init(iapp);
        }

        /// <summary>
        /// Use for Fake loading from json file
        /// </summary>
        /// <param name="panelPath">path of json file for panel</param>
        /// <param name="edgesPath">path of json file for edges</param>
        public GetSlabReinfResult(string panelPath,string edgesPath)
        {

            this.panelPath = panelPath;
            this.edgesPath = edgesPath;
        }

        private void Init(IRobotApplication iapp)
        {
            if (iapp != null) robot = iapp;
            else robot = new RobotApplication();
            str = robot.Project.Structure;
            Panel = new List<RSA_FE>();
            PanelEdges = new List<Panel>();
            ErrorList = new List<string>();
        }
        #endregion


        #region Validate
        public virtual void Validating(int ObjNumber)
        {
            var slab = (RobotObjObject)str.Objects.Get(ObjNumber);
            if (slab == null)
                throw new Exception($"Slab with number {ObjNumber} don't exist.");
            var s = slab.StructuralType;
            if (s != IRobotObjectStructuralType.I_OST_SLAB)
                throw new Exception($"Object with number {ObjNumber} is not a slab, please enter a slab number.");
        }

        private void Validatings(int[] ObjNumbers)
        {
            foreach (var objNumber in ObjNumbers)
            {
                Validating(objNumber);
            }
        }

        public void ValidatingOnSameZCoord(int[] ObjNumbers)
        {
            var toRemove = new List<int>();
            var slabsNodes = new List<FE>();
            var s = new FE { };

            foreach (var slabNumber in ObjNumbers)
            {
                s = new FE();
                var slab = (RobotObjObject)str.Objects.Get(slabNumber);
                s.Panel_ID = slabNumber;
                s.nodes = new List<Node>();
                var modelPoints = (RobotGeoPoint3DCollection)slab.Main.ModelPoints;
                for (int i = 1; i <= modelPoints.Count; i++)
                {
                    var r = (RobotGeoPoint3D)modelPoints.Get(i);
                    s.nodes.Add(new Node { X = r.X, Y = r.Y, A = r.Z });
                }
                slabsNodes.Add(s);
            }
            double Z = 0;
            slabsNodes.ForEach(x =>
            {
                if (slabsNodes.IndexOf(x) == 0)
                    Z = x.nodes.FirstOrDefault().A;
                if (x.nodes.Any(y => y.A != Z))
                {
                    toRemove.Add(x.Panel_ID);
                }
            });

            if (toRemove.Count != 0)
                throw new Exception($"Slabs {toRemove.ToArray().ToRobotSelectionString()} not on same Z coordinat as {slabsNodes[0].Panel_ID}");
        }
        #endregion

        #region CollectingData

        
        public void GetSlabsEdges(int[] ObjNumbers, IProgress<ProgressModelObject<double>> progress) 
        {
            var y = 0;
            foreach (var ObjNumber in ObjNumbers)
            {
                y++;
                progress.Report(new ProgressModelObject<double>() { ProgressToString = $"Getting slab edges {y}/{ObjNumbers.Count()}" });
                var p = new Panel(); 
                p.PanelId = ObjNumber;
                var slab = (RobotObjObject)str.Objects.Get(ObjNumber);
                var modelPoints = (RobotGeoPoint3DCollection)slab.Main.ModelPoints;
                for (int i = 1; i <= modelPoints.Count; i++)
                {
                    var r = (RobotGeoPoint3D)modelPoints.Get(i);
                    p.NodeEdges.Add(new Node { X = r.X, Y = r.Y });
                }
                PanelEdges.Add(p);
            }
        }


        public async Task QueryResultsAndNodeCoord(string plates,
            IProgress<ProgressModelObject<double>> progress,
            CancellationToken ct)
        {
            IRobotResultQueryReturnType Res;

            var selecPlate = str.Selections.Create(IRobotObjectType.I_OT_PANEL);
            selecPlate.FromText(plates);

            RobotResultQueryParams parm = new RobotResultQueryParams();

            parm.Selection.Set(IRobotObjectType.I_OT_PANEL, selecPlate);

            parm.SetParam(IRobotResultParamType.I_RPT_ELEMENT, 11);
            parm.SetParam(IRobotResultParamType.I_RPT_NODE, 3);
            parm.SetParam(IRobotResultParamType.I_RPT_PANEL, 2);
            parm.SetParam(IRobotResultParamType.I_RPT_RESULT_POINT_COORDINATES, 31);

            parm.ResultIds.SetSize(8);

            parm.ResultIds.Set(1, (int)T_DATA_TYPES.T_FERA_NOD_LONG_UP);
            parm.ResultIds.Set(2, (int)T_DATA_TYPES.T_FERA_NOD_TRAN_UP);
            parm.ResultIds.Set(3, (int)T_DATA_TYPES.T_FERA_NOD_LONG_DOWN);
            parm.ResultIds.Set(4, (int)T_DATA_TYPES.T_FERA_NOD_TRAN_DOWN);
            parm.ResultIds.Set(5, (int)T_DATA_TYPES.T_NODE_COORD_CART_X);
            parm.ResultIds.Set(6, (int)T_DATA_TYPES.T_NODE_COORD_CART_Y);
            parm.ResultIds.Set(7, (int)T_DATA_TYPES.T_NODE_COORD_CART_Z);


            var t = new RSATableQueryingResult();
            Panel = await t.ReadFromTableAsync(plates.ToIntArrayFromRobotStringSelection(), progress, ct);

            if (Panel.Count == 0)
            {
                throw new SlabNotCalculatedExpetation("None of selected slabs are meshed and calculated");
            }
            

            RobotResultRowSet RobResRowSet = new RobotResultRowSet();
            Res = robot.Project.Structure.Results.Query(parm, RobResRowSet);
            bool ok;
            int i = 0;
            ok = RobResRowSet.MoveFirst();

            progress.Report(new ProgressModelObject<double>
            { ProgressToString = "Getting reinforcements and node coordinations", Progress = 9 * 10 });


            while (ok)
            {
                ///geting slab number
                int p = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_PANEL);
                ///if already got in error list
                if (ErrorList.Any(g => g.Contains($"number {p} isn't")))
                    goto ExitPlate;

                var nodeId = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_NODE);
                //var eeId = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_ELEMENT); 
                for (int x = 0; x < Panel.Count; x++)
                {

                    for (int y = 0; y < Panel[x].nodes.Count; y++)
                    {
                        if (Panel[x].nodes[y].NodeId == nodeId)
                        {
                            ///check if there is result for slab
                            if (!RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(3)))
                            {
                                ErrorList.Add($"Slabs with number {p} isn't calculated for reinforcement");
                                goto ExitPlate;
                            }

                            Panel[x].nodes[y].AX_BOTTOM = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(3)) * 10000, 3);
                            Panel[x].nodes[y].AY_BOTTOM = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(4)) * 10000, 3);
                            Panel[x].nodes[y].AX_TOP = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(1)) * 10000, 3);
                            Panel[x].nodes[y].AY_TOP = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(2)) * 10000, 3);
                            Panel[x].nodes[y].X = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(5));
                            Panel[x].nodes[y].Y = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(6));
                            Panel[x].nodes[y].Z = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(7));
                        }
                    }
                }
                ExitPlate:
                i++;
                ok = RobResRowSet.MoveNext();
            }

            if (ErrorList.Count == ObjNumbers.Length)
                throw new SlabNotCalculatedForReinfException
                    ("None of selected slabs are calculated for reinforcement");

            progress.Report(new ProgressModelObject<double>
            { ProgressToString = "Done collectiong done!", Progress = 10 * 10 });
            IsDataCollected = true;
        }

        /// <summary>
        /// getting results asynchronously Ax+, Ax-, Ay+, Ay- for slab
        /// </summary>
        /// <param name="progress"> IProgress for tacking progress</param>
        /// <param name="ct">cancelacionToken</param>
        public async Task StartAsync(int[] ObjNumbers, IProgress<ProgressModelObject<double>> progress,
            CancellationToken ct)
        {
            this.ObjNumbers = ObjNumbers;
            await Task.Run(() =>
            {
                progress.Report(new ProgressModelObject<double>() { ProgressToString = $"Validating selection" });
                    Validatings(ObjNumbers);
                    ValidatingOnSameZCoord(ObjNumbers);
                    GetSlabsEdges(ObjNumbers,progress);
            }, ct);
            await QueryResultsAndNodeCoord(ObjNumbers.ToRobotSelectionString(), progress, ct);

        }
        #endregion

        #region Drawing
        public async Task CreateDxfDrawingAsync(
            string filePath,
            A_Type a_Type,
            double SkipA,
            Legend legend,
            DrawAsType drawAsType = DrawAsType.SOLID)
        {
            legend.Extrime = Panel.Max(x => x.ExtremeMax(a_Type));

            IDrawParameters p = new DrawDxfParametars
            {
                a_Type = a_Type,
                drawAsType = drawAsType,
                Legend = legend,
                ListFe = Panel,
                SkipA = SkipA,
                slabEdgesNodes = PanelEdges
            };
            await Task.Run(() =>
            {
                var drawing = new DrawDxf();
                drawing
                    .SetParamForDrawing(p)
                    .CreatAllLayer()
                    .DrawEdges()
                    .DrawIsolines()
                    .DrawLegend()
                    .SaveDrawing(filePath);
            });

        }
        #endregion

        public void SaveToJson()
        {
            using (StreamWriter file = File.CreateText(@"F:\panel.json"))
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, Panel);
            }
            using (System.IO.StreamWriter file = File.CreateText(@"F:\edges.json"))
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, PanelEdges);
            }
        }

        public async Task StartFakeAsync(IProgress<ProgressModelObject<double>> progress, CancellationToken ct)
        {

            await Task.Run(() =>
            {
                if (File.Exists(panelPath) && !ct.IsCancellationRequested)
                {
                    progress.Report(new ProgressModelObject<double>
                    {
                        Progress = 40,
                        ProgressToString = $"File {panelPath.Split('\\').Last()} is loading"
                    });
                    Panel = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RSA_FE>>(File.ReadAllText(panelPath));
                }
                else throw new Exception($"File missing : {panelPath}");
                if (File.Exists(edgesPath) && !ct.IsCancellationRequested)
                {
                    progress.Report(new ProgressModelObject<double>
                    {
                        Progress = 80,
                        ProgressToString = $"File {edgesPath.Split('\\').Last()} is loading"
                    });
                    PanelEdges = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Panel>>(File.ReadAllText(edgesPath));
                }    
                else throw new Exception($"File missing : {edgesPath}");
            });

        }
    }
}
