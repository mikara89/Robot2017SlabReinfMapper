using GenerateIsolines;
using GenerateIsolines.Model;
using RobotOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using static GetSlabReinfResult.DataCollector.Logic.RSATableQueryingResult;

namespace GetSlabReinfResult.DataCollector.Logic 
{
    public class GetSlabReinfResultClass
    {
        private readonly int ObjNumber;
        private RobotApplication robot;
        private RobotStructure str;
        public bool IsDataCollected { get; internal set; }
        public string messang;


        public List<RSA_FE> Panel;
        public List<Node> Edgets;

        public GetSlabReinfResultClass(int ObjNumber)
        {
            robot = new RobotApplication();
            str = robot.Project.Structure;
            this.ObjNumber = ObjNumber;
            Valedating();

        }

        public virtual void Valedating()
        {
            var slab = (RobotObjObject)str.Objects.Get(ObjNumber);
            if (slab == null)
                throw new Exception($"Slab with number {ObjNumber} don't exist.");
            var s = slab.StructuralType;
            if (s !=  IRobotObjectStructuralType.I_OST_SLAB)
                throw new Exception($"Object with number {ObjNumber} is not slab, please eneter slab number.");
        }

        public void GetSlabEdgets()
        {
            Edgets = new List<Node>();
            var slab = (RobotObjObject)str.Objects.Get(ObjNumber);
            var modelPoints = (RobotGeoPoint3DCollection)slab.Main.ModelPoints;
            for (int i = 1; i <= modelPoints.Count; i++)
            {
                var r = (RobotGeoPoint3D)modelPoints.Get(i);
                Edgets.Add(new Node { X = r.X, Y = r.Y });
            }

        }



        public virtual void  QueryResultsAndNodeCoord(string plate,
            IProgress<ProgressModelObject<double>> progress,
            CancellationToken ct)
        {
            IRobotResultQueryReturnType Res;

            var selecPlate = str.Selections.Create(IRobotObjectType.I_OT_PANEL);
            selecPlate.FromText(plate);
            var slab = (RobotObjObject)str.Objects.Get(ObjNumber);

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
            Panel = t.ReadFromTable(ObjNumber, progress, ct);

            RobotResultRowSet RobResRowSet = new RobotResultRowSet();
            Res = robot.Project.Structure.Results.Query(parm, RobResRowSet);
            bool ok;
            int i = 0;
            ok = RobResRowSet.MoveFirst();

            progress.Report(new ProgressModelObject<double>
            { ProgressToString = "Getting reinforcements and node coordinations", Progress = 9 * 10 });

            if (ct.IsCancellationRequested)
            {
                progress.Report(new ProgressModelObject<double>
                { ProgressToString = "Canceled", Progress = 0 * 10 });
                IsDataCollected = false;
                return;
            }
            while (ok)
            {
                if (ct.IsCancellationRequested) break;               
                int p = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_PANEL);

                if (p == Panel.First().Panel_ID)
                {

                    var nodeId = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_NODE);
                    for (int x = 0; x < Panel.Count; x++)
                    {
                        if (ct.IsCancellationRequested) break;
                        for (int y = 0; y < Panel[x].nodes.Count; y++)
                        {                          
                            if (ct.IsCancellationRequested) break;
                            if (Panel[x].nodes[y].NodeId == nodeId)
                            {
                                Panel[x].nodes[y].AX_BOTTOM = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(3)) * 10000,3) ;
                                Panel[x].nodes[y].AY_BOTTOM = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(4)) * 10000, 3);
                                Panel[x].nodes[y].AX_TOP = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(1)) * 10000, 3);
                                Panel[x].nodes[y].AY_TOP = Math.Round((double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(2)) * 10000, 3);
                                Panel[x].nodes[y].X = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(5));
                                Panel[x].nodes[y].Y = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(6));
                                Panel[x].nodes[y].Z = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(7));

                            }
                        }
                    }
                }
                i++;
                ok = RobResRowSet.MoveNext();
            }
            progress.Report(new ProgressModelObject<double> { ProgressToString = "Done collectiong done!", Progress = 10 * 10 });
            IsDataCollected = true;
        }




        /// <summary>
        /// getting results Ax+, Ax-, Ay+, Ay- for slab
        /// </summary>
        /// <param name="progress"> IProgress for tacking progress</param>
        /// <param name="ct">cancelacionToken</param>
        public void Start(IProgress<ProgressModelObject<double>> progress,
            CancellationToken ct)
        {
            QueryResultsAndNodeCoord(ObjNumber.ToString(), progress, ct);
            GetSlabEdgets();

            if (Panel != null)
            {
                ReportExtrimsReinf();
            }
        }

        /// <summary>
        /// getting results asyncronisly Ax+, Ax-, Ay+, Ay- for slab
        /// </summary>
        /// <param name="progress"> IProgress for tacking progress</param>
        /// <param name="ct">cancelacionToken</param>
        public async Task StartAsync(IProgress<ProgressModelObject<double>> progress,
            CancellationToken ct) 
        {
            await Task.Run(() =>
            {
                QueryResultsAndNodeCoord(ObjNumber.ToString(), progress, ct);
                if(!ct.IsCancellationRequested)GetSlabEdgets();

            },ct);
            
            if (Panel != null)
            {
                ReportExtrimsReinf();
            }
        }

        public void CreateDxfDrawing(
            string filePath,
            A_Type a_Type,
            double SkipA,
            Legend legend,
            DrawAsType drawAsType = DrawAsType.SOLID)
        {
            legend.Extrime = Panel.Max(x => x.ExtremeMax(a_Type));

            IDrawDxfParametars p= new DrawDxfParametars
            {
                a_Type = a_Type,
                drawAsType= drawAsType,
                Legend=legend,
                ListFe=Panel,
                SkipA=SkipA,
                slabEdgesNodes=Edgets
            };
            p.a_Type = a_Type;
            var drawing = new DrawDxf(p);
            drawing
                .CreatAllLayer()
                .DrawEdges()
                .DrawIsolines()
                .DrawLegend()
                .SaveDrawing(filePath);
        }
        public async Task CreateDxfDrawingAsync( 
            string filePath,
            A_Type a_Type,
            double SkipA,
            Legend legend,
            DrawAsType drawAsType = DrawAsType.SOLID)
            {
            legend.Extrime = Panel.Max(x => x.ExtremeMax(a_Type));

            IDrawDxfParametars p = new DrawDxfParametars
            {
                a_Type = a_Type,
                drawAsType = drawAsType,
                Legend = legend,
                ListFe = Panel,
                SkipA = SkipA,
                slabEdgesNodes = Edgets
            };
            await Task.Run(() =>
            {
                var drawing = new DrawDxf(p);
                drawing
                    .CreatAllLayer()
                    .DrawEdges()
                    .DrawIsolines()
                    .DrawLegend()
                    .SaveDrawing(filePath);
            });
           
        }

        public void ReportExtrimsReinf()
        {
            if (Panel.Count > 0)
                messang += $"Slab {ObjNumber}, Reinforcemet extreme values:" + "\n\r" +
                 " Ax+ = " + Math.Round(Panel.Select(n => n.Max_AX_TOP).Max(), 2) + " [cm2]" + "\n\r" +
                 " Ax- = " + Math.Round(Panel.Select(n => n.Max_AX_BOTTOM).Max(), 2) + " [cm2]" + "\n\r" +
                 " Ay+ = " + Math.Round(Panel.Select(n => n.Max_AY_TOP).Max(), 2) + " [cm2]" + "\n\r" +
                 " Ay- = " + Math.Round(Panel.Select(n => n.Max_AY_BOTTOM).Max(), 2) + " [cm2]" + "\n\r";
        }
    }
}
