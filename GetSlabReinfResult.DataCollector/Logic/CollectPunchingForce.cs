using GenerateIsolines;
using RobotOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public class CollectPunchingForce
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
        public CollectPunchingForce(IRobotApplication robot)
        {
            this.robot = robot;
            this.str = robot.Project.Structure;
            Panel = new List<RSA_FE>();
            PanelEdges = new List<Panel>();
        }
        private void GetSlabsEdges(int[] ObjNumbers, IProgress<ProgressModelObject<double>> progress)
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
                    p.NodeEdges.Add(new Node { X = r.X, Y = r.Y, Z=r.Z });
                }
                PanelEdges.Add(p);
            }
        }


        #region Test
        private void QueryResultsAndNodeCoord(string plates,
        IProgress<ProgressModelObject<double>> progress,
        CancellationToken ct)
        {
            IRobotResultQueryReturnType Res;

            var selecPlate = str.Selections.Create(IRobotObjectType.I_OT_PANEL);
            selecPlate.FromText(plates);

            var slab = (RobotObjObject)str.Objects.Get(plates.ToIntArrayFromRobotStringSelection()[0]);

            var selecNodes = str.Selections.Create(IRobotObjectType.I_OT_NODE);
            selecNodes.FromText(slab.Nodes);

            var Case = str.Selections
              .Get(RobotOM.IRobotObjectType.I_OT_CASE);

            RobotResultQueryParams parm = new RobotResultQueryParams();

            parm.Selection.Set(IRobotObjectType.I_OT_PANEL, selecPlate);
            parm.Selection.Set(IRobotObjectType.I_OT_NODE, selecNodes);
            parm.Selection.Set(IRobotObjectType.I_OT_CASE, Case);

            parm.SetParam(IRobotResultParamType.I_RPT_ELEMENT, 11);
            parm.SetParam(IRobotResultParamType.I_RPT_NODE, 3);
            parm.SetParam(IRobotResultParamType.I_RPT_PANEL, 2);
            parm.SetParam(IRobotResultParamType.I_RPT_RESULT_POINT_COORDINATES, 31);

            parm.SetParam(IRobotResultParamType.I_RPT_MULTI_THREADS, true);
            parm.SetParam(IRobotResultParamType.I_RPT_THREAD_COUNT, 4);
            parm.SetParam(IRobotResultParamType.I_RPT_DIR_X_DEFTYPE, IRobotObjLocalXDirDefinitionType.I_OLXDDT_CARTESIAN);

            parm.ResultIds.SetSize(8);

            parm.ResultIds.Set(1, (int)T_DATA_TYPES.T_NODE_COORD_CART_X);
            parm.ResultIds.Set(2, (int)T_DATA_TYPES.T_NODE_COORD_CART_Y);
            parm.ResultIds.Set(3, (int)T_DATA_TYPES.T_NODE_COORD_CART_Z);
            parm.ResultIds.Set(4, (int)T_DATA_TYPES.T_FE_Q_SHEA);
            parm.ResultIds.Set(5, (int)T_DATA_TYPES.T_FE_Q_XY);
            parm.ResultIds.Set(6, (int)T_DATA_TYPES.T_FE_Q_ROUND);
            parm.ResultIds.Set(7, (int)T_DATA_TYPES.T_FE_Q_ALPHA);
            parm.ResultIds.Set(8, (int)T_DATA_TYPES.T_FE_Q_MISES);

            var sN = plates.ToIntArrayFromRobotStringSelection();
            GetFEAndNodes(sN);
            if (Panel.Count == 0)
            {
                throw new SlabNotCalculatedExpetation("None of selected slabs are meshed and calculated");
            }


            RobotResultRowSet RobResRowSet = new RobotResultRowSet();
            Res = robot.Project.Structure.Results.Query(parm, RobResRowSet);
            bool ok;
            int i = 0;
            ok = RobResRowSet.MoveFirst();

            //progress.Report(new ProgressModelObject<double>
            //{ ProgressToString = "Getting reinforcements and node coordinations", Progress = 9 * 10 });
            double T_FE_Q_XY;

            while (ok)
            {
                ///geting slab number
                int p = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_PANEL);

                var nodeId = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_NODE);
                for (int x = 0; x < Panel.Count; x++)
                {

                    for (int y = 0; y < Panel[x].nodes.Count; y++)
                    {
                        if (Panel[x].nodes[y].NodeId == nodeId)
                        {
                            Panel[x].nodes[y].X = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(1));
                            Panel[x].nodes[y].Y = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(2));
                            Panel[x].nodes[y].Z = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(3));
                            if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(4)))
                                Panel[x].nodes[y].AX_BOTTOM = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(4));
                            if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(5)))
                                T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(5));
                            if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(6)))
                                T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(6));
                            if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(7)))
                                T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(7));
                            if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(8)))
                                T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(8));
                        }
                    }
                }
                i++;
                ok = RobResRowSet.MoveNext();
            }

            //if (ErrorList.Count == ObjNumbers.Length)
            //    throw new SlabNotCalculatedForReinfException
            //        ("None of selected slabs are calculated for reinforcement");

            //progress.Report(new ProgressModelObject<double>
            //{ ProgressToString = "Done collectiong done!", Progress = 10 * 10 });
            IsDataCollected = true;
        }

        private void QueryResultsForQxy(int ObjNumber)
        {
            IRobotResultQueryReturnType Res;

            var slab = (RobotObjObject)str.Objects.Get(ObjNumber);

            var selecFE = str.Selections.Create(IRobotObjectType.I_OT_FINITE_ELEMENT);
            selecFE.FromText(slab.FiniteElems);

            var selecNodes = str.Selections.Create(IRobotObjectType.I_OT_NODE);
            selecNodes.FromText(slab.Nodes);

            var Case = str.Selections
              .Get(RobotOM.IRobotObjectType.I_OT_CASE);

            RobotResultQueryParams parm = new RobotResultQueryParams();

            parm.Selection.Set(IRobotObjectType.I_OT_NODE, selecNodes);
            parm.Selection.Set(IRobotObjectType.I_OT_FINITE_ELEMENT, selecFE);
            parm.Selection.Set(IRobotObjectType.I_OT_CASE, Case);

            parm.SetParam(IRobotResultParamType.I_RPT_ELEMENT, 11);
            parm.SetParam(IRobotResultParamType.I_RPT_NODE, 3);
            parm.SetParam(IRobotResultParamType.I_RPT_LOAD_CASE, 4);
            parm.SetParam(IRobotResultParamType.I_RPT_RESULT_POINT_COORDINATES, 31);

            parm.SetParam(IRobotResultParamType.I_RPT_MULTI_THREADS, true);
            parm.SetParam(IRobotResultParamType.I_RPT_THREAD_COUNT, 4);
            parm.SetParam(IRobotResultParamType.I_RPT_DIR_X_DEFTYPE, IRobotObjLocalXDirDefinitionType.I_OLXDDT_CARTESIAN);
            parm.SetParam(IRobotResultParamType.I_RPT_DIR_X, new { _x = 0, _y = 0, _z = 1 });
            parm.ResultIds.SetSize(10);

            parm.ResultIds.Set(1, (int)T_DATA_TYPES.T_NODE_COORD_CART_X);
            parm.ResultIds.Set(2, (int)T_DATA_TYPES.T_NODE_COORD_CART_Y);
            parm.ResultIds.Set(3, (int)T_DATA_TYPES.T_NODE_COORD_CART_Z);
            parm.ResultIds.Set(4, (int)IRobotFeResultType.I_FRT_DETAILED_QXX);
            parm.ResultIds.Set(5, (int)IRobotFeResultType.I_FRT_DETAILED_QYY);
            parm.ResultIds.Set(6, (int)IRobotFeResultType.I_FRT_PRINCIPAL_Q1_2);

            RobotResultRowSet RobResRowSet = new RobotResultRowSet();
            Res = robot.Project.Structure.Results.Query(parm, RobResRowSet);

            bool ok;
            ok = RobResRowSet.MoveFirst();

            double T_FE_Q_XY;

            while (ok)
            {
                RSA_FE FE;
                var FE_Id = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_NODE);



                var node = new RSANode
                {
                    X = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(1)),
                    Y = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(2)),
                    Z = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(3)),
                };

                if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(4)))
                    T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(4));
                if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(5)))
                    T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(5));
                if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(6)))
                    T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(6));

                if (!Panel.Any(fe => fe.FE_ID == FE_Id))
                {
                    FE = new RSA_FE { FE_ID = FE_Id, Panel_ID = ObjNumber };
                }

                else
                    FE = Panel.Find(fe => fe.FE_ID == FE_Id);

                FE.nodes.Add(node);

                ok = RobResRowSet.MoveNext();
            }
        }

        private void QueryResultsForQxy2(int ObjNumber)
        {
            IRobotResultQueryReturnType Res;

            var slab = (RobotObjObject)str.Objects.Get(ObjNumber);

            var selecPlate = str.Selections.Create(IRobotObjectType.I_OT_PANEL);
            selecPlate.Get(ObjNumber);

            var selecNodes = str.Selections.Create(IRobotObjectType.I_OT_NODE);
            selecNodes.FromText(slab.Nodes);

            var Case = str.Selections
              .Get(RobotOM.IRobotObjectType.I_OT_CASE);

            RobotResultQueryParams parm = new RobotResultQueryParams();

            parm.Selection.Set(IRobotObjectType.I_OT_NODE, selecNodes);
            parm.Selection.Set(IRobotObjectType.I_OT_PANEL, selecPlate);
            parm.Selection.Set(IRobotObjectType.I_OT_CASE, Case);

            parm.SetParam(IRobotResultParamType.I_RPT_ELEMENT, 11);
            parm.SetParam(IRobotResultParamType.I_RPT_PANEL, 12);
            parm.SetParam(IRobotResultParamType.I_RPT_PANEL_PART, 13);
            parm.SetParam(IRobotResultParamType.I_RPT_NODE, 3);
            parm.SetParam(IRobotResultParamType.I_RPT_RESULT_POINT_COORDINATES, 31);

            parm.SetParam(IRobotResultParamType.I_RPT_MULTI_THREADS, true);
            parm.SetParam(IRobotResultParamType.I_RPT_THREAD_COUNT, 4);
            parm.SetParam(IRobotResultParamType.I_RPT_DIR_X_DEFTYPE, IRobotObjLocalXDirDefinitionType.I_OLXDDT_CARTESIAN);

            parm.ResultIds.SetSize(6);

            parm.ResultIds.Set(1, (int)T_DATA_TYPES.T_NODE_COORD_CART_X);
            parm.ResultIds.Set(2, (int)T_DATA_TYPES.T_NODE_COORD_CART_Y);
            parm.ResultIds.Set(3, (int)T_DATA_TYPES.T_NODE_COORD_CART_Z);
            parm.ResultIds.Set(4, (int)T_DATA_TYPES.T_FE_Q_XX);
            parm.ResultIds.Set(5, (int)T_DATA_TYPES.T_FE_Q_YY);
            parm.ResultIds.Set(6, (int)T_DATA_TYPES.T_FE_Q_XY);

            RobotResultRowSet RobResRowSet = new RobotResultRowSet();
            Res = robot.Project.Structure.Results.Query(parm, RobResRowSet);

            bool ok;
            ok = RobResRowSet.MoveFirst();

            double T_FE_Q_XY;

            while (ok)
            {
                RSA_FE FE;

                try
                {
                    var Node_Id = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_NODE);
                    var Panel_Id = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_PANEL);
                    var FE_Id = (int)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_PANEL_PART);
                }
                catch (Exception)
                { }


                var node = new RSANode
                {
                    X = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(1)),
                    Y = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(2)),
                    Z = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(3)),
                };

                if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(4)))
                    T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(4));
                if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(5)))
                    T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(5));
                if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(6)))
                    T_FE_Q_XY = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(6));


                //if (!Panel.Any(fe => fe.FE_ID == FE_Id))
                //{
                //    FE = new RSA_FE { FE_ID = FE_Id, Panel_ID = ObjNumber };
                //}

                //else
                //    FE = Panel.Find(fe => fe.FE_ID == FE_Id);

                //FE.nodes.Add(node);

                ok = RobResRowSet.MoveNext();
            }
        }
        #endregion



        private void QueryQ12()
        {
            List<int> slabNumbers = Panel.Select(x => x.Panel_ID).Distinct().ToList();
            foreach (var slabNum in slabNumbers)
            {
                var slab = (RobotObjObject)str.Objects.Get(slabNum);
                var selecNodes = str.Selections.Create(IRobotObjectType.I_OT_NODE);
                selecNodes.FromText(slab.Nodes);
                var Case = str.Selections
                .Get(RobotOM.IRobotObjectType.I_OT_CASE);

                for (int i = 1; i < selecNodes.Count; i++)
                {
                    var nodeNumb = selecNodes.Get(i);
                    var caseNumb = Case.Get(1);


                    var param = new RobotFeResultParams();
                    param.SetDirX(IRobotObjLocalXDirDefinitionType.I_OLXDDT_CARTESIAN, 0, 0, 1);
                    param.Panel = slab.Number;
                    param.Node = nodeNumb;
                    param.Case = caseNumb;

                    IRobotFeResultPrincipal detFE;
                    detFE = str.Results.FiniteElems.Principal(param);

                    var filter = Panel.Where(x => x.nodes.Any(n => n.NodeId == nodeNumb)).ToList();
                    for (int j = 0; j < filter.Count(); j++)
                    {
                        for (int l = 0; l < filter[j].nodes.Count(); l++)
                        {
                            if (filter[j].nodes[l].NodeId == nodeNumb)
                                filter[j].nodes[l].AX_BOTTOM = detFE.Q1_2;
                        }
                    }
                }
            }
        }
        private void QueryNodeCoordinates()
        {
            var nodes = Panel.SelectMany(x => x.nodes.Select(y => y.NodeId)).Distinct().ToList();
            for (int i = 0; i < nodes.Count(); i++)
            {
                var node = str.Nodes.Get(nodes[i]) as IRobotNode;
                Panel.ForEach(x => x.nodes.ForEach(
                    y => {
                        if(y.NodeId== nodes[i])
                        {
                            y.X = node.X;
                            y.Y = node.Y;
                            y.Z = node.Z;
                        }
                    }));
            }
        }
        private void GetFEAndNodes(int[] ObjNumbers)
        {
            var Case = str.Selections
                .Get(RobotOM.IRobotObjectType.I_OT_CASE)
                .ToText();



            for (int k = 0; k < ObjNumbers.Length; k++)
            {
                var slab = (RobotObjObject)str.Objects.Get(ObjNumbers[k]);

                var SelectionFe_col = str.Selections.Get(IRobotObjectType.I_OT_FINITE_ELEMENT);

                SelectionFe_col.FromText(slab.FiniteElems);

                var fe_col = str.FiniteElems.GetMany(SelectionFe_col) as RobotFiniteElementCollection;
                for (int i = 1; i <= fe_col.Count; i++)
                {
                    var fe = fe_col.Get(i) as IRobotFiniteElement;
                    var RSAFE = new RSA_FE { FE_ID = fe.Number, Panel_ID = ObjNumbers[k] };
                    for (int j = 1; j <= fe.Nodes.Count; j++)
                    {
                        var n = fe.Nodes.Get(j);
                        RSAFE.nodes.Add(new RSANode { NodeId = n, FE_Number = fe.Number });
                    }
                    Panel.Add(RSAFE);
                }
            }
        }

        public void CollectDataShareForces(int[] ObjNumbers, IProgress<ProgressModelObject<double>> progress, CancellationToken ct)
        {
            progress.Report(new ProgressModelObject<double> { ProgressToString = "Collectin edge slab data" });
            GetSlabsEdges(ObjNumbers, progress);
            progress.Report(new ProgressModelObject<double> { ProgressToString = "Collectin FE and Nodes Ids" });
            GetFEAndNodes(ObjNumbers);
            progress.Report(new ProgressModelObject<double> { ProgressToString = "Collectin Q12 data for nodes" });
            QueryQ12();
            progress.Report(new ProgressModelObject<double> { ProgressToString = "Collectin node coorditaions" });
            QueryNodeCoordinates();
        }

        public List<FE> GetResultsInFE()
        {
            var result = new List<FE>();
            Panel.ForEach(fe =>
            {
                var Fe = new FE();
                Fe.FE_ID = fe.FE_ID;
                Fe.nodes = new List<Node>();
                fe.nodes.ForEach(n =>
                {
                    Fe.nodes.Add(new Node {X=n.X, Y=n.Y, Z=n.Z, A=n.AX_BOTTOM });
                });
                result.Add(Fe);
            });
            return result;
        }
        public Node GetNode(int nodeNum)
        {
            var node = str.Nodes.Get(nodeNum) as IRobotNode;
            return new Node { X = node.X, Y = node.Y, Z = node.Z };
        }
    }
}
