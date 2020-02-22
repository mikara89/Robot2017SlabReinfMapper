using RobotOM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public class GetResultForStorys
    {
        private IRobotApplication robot;
        private RobotStructure str;

        #region Constructor

        public GetResultForStorys(IRobotApplication iapp = null)
        {
            Init(iapp);
        }

        private void Init(IRobotApplication iapp)
        {
            if (iapp != null) robot = iapp;
            else robot = new RobotApplication();
            str = robot.Project.Structure;
        }
        #endregion
        public DataTable QueryResultsForStoreys(string loadCase,
    IProgress<ProgressModelObject<double>> progress, 
    CancellationToken ct)
        {
            IRobotResultQueryReturnType Res;

            IRobotStoreySelection stor= new RobotStoreySelection();
            stor.AddAll();

            //var selectedNodes = str.Selections.Create(IRobotObjectType.I_OT_NODE);
            //selectedNodes.FromText("all");
            var selectedCase = str.Selections.Create(IRobotObjectType.I_OT_CASE);
            selectedCase.FromText(loadCase);
            
            RobotResultQueryParams parm = new RobotResultQueryParams();

            parm.Selection.Set(IRobotObjectType.I_OT_CASE, selectedCase);

            //parm.Selection.Set(IRobotObjectType.I_OT_NODE, selectedNodes);
            parm.SetParam(IRobotResultParamType.I_RPT_MULTI_THREADS, true);
            parm.SetParam(IRobotResultParamType.I_RPT_THREAD_COUNT, 4);
            parm.SetParam(IRobotResultParamType.I_RPT_MAX_BUFFER_SIZE, 2000000);
            parm.SetParam(IRobotResultParamType.I_RPT_STOREY, 11);

            parm.ResultIds.SetSize(24);

            parm.ResultIds.Set(1, (int)T_DATA_TYPES.T_STOREY_NAME);

            parm.ResultIds.Set(2, (int)T_DATA_TYPES.T_STOREY_MASS_X);
            parm.ResultIds.Set(3, (int)T_DATA_TYPES.T_STOREY_MASS_Y);
            parm.ResultIds.Set(4, (int)T_DATA_TYPES.T_STOREY_MASS_Z);
            parm.ResultIds.Set(5, (int)T_DATA_TYPES.T_STOREY_MASS);
            parm.ResultIds.Set(6, (int)T_DATA_TYPES.T_STOREY_DPL_MAX_UX);
            parm.ResultIds.Set(7, (int)T_DATA_TYPES.T_STOREY_DPL_MAX_UY);
            parm.ResultIds.Set(8, (int)T_DATA_TYPES.T_STOREY_DPL_MIN_UX);
            parm.ResultIds.Set(9, (int)T_DATA_TYPES.T_STOREY_DPL_MIN_UY);
            parm.ResultIds.Set(10, (int)T_DATA_TYPES.T_STOREY_DPL_UX);
            parm.ResultIds.Set(11, (int)T_DATA_TYPES.T_STOREY_DPL_UY);
            parm.ResultIds.Set(12, (int)T_DATA_TYPES.T_STOREY_DRFR_UX);
            parm.ResultIds.Set(13, (int)T_DATA_TYPES.T_STOREY_DRFR_UY);
            parm.ResultIds.Set(14, (int)T_DATA_TYPES.T_STOREY_DRF_UX);
            parm.ResultIds.Set(15, (int)T_DATA_TYPES.T_STOREY_DRF_UY);
            ///forces in X direction
            parm.ResultIds.Set(16, (int)T_DATA_TYPES.T_STOREY_RED_FX);
            ///forces in Y direction
            parm.ResultIds.Set(17, (int)T_DATA_TYPES.T_STOREY_RED_FY);
            ///forces in Z direction
            parm.ResultIds.Set(18, (int)T_DATA_TYPES.T_STOREY_RED_FZ);
            ///forces in X direction only on columns
            parm.ResultIds.Set(19, (int)T_DATA_TYPES.T_STOREY_RED_FXPC);
            ///forces in Y direction only on columns
            parm.ResultIds.Set(20, (int)T_DATA_TYPES.T_STOREY_RED_FYPC);
            ///forces in X direction only on walls
            parm.ResultIds.Set(21, (int)T_DATA_TYPES.T_STOREY_RED_FXPW);
            ///forces in Y direction only on walls
            parm.ResultIds.Set(22, (int)T_DATA_TYPES.T_STOREY_RED_FYPW);
            ///moment in G point
            parm.ResultIds.Set(23, (int)T_DATA_TYPES.T_STOREY_RED_MX);
            ///G point
            parm.ResultIds.Set(24, (int)T_DATA_TYPES.T_STOREY_G);



            var table = CreateTable();


            RobotResultRowSet RobResRowSet = new RobotResultRowSet();

            Res = robot.Project.Structure.Results.Query(parm, RobResRowSet);
            bool ok;
            int i = 0;
            ok = RobResRowSet.MoveFirst();


            while (ok)
            {
                try
                {
                    string Storey = (string)RobResRowSet.CurrentRow.GetParam(IRobotResultParamType.I_RPT_STOREY);
                }
                catch (Exception)
                { }
                

                object[] obj = new object[table.Columns.Count];

                for (int j = 1; j < table.Columns.Count+1; j++)
                {
                    if (j == 1 || j == table.Columns.Count)
                    {
                        if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(j)))
                            obj[j - 1] = RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(j)) as string;
                    }

                    else
                    {
                        if (RobResRowSet.CurrentRow.IsAvailable(RobResRowSet.ResultIds.Get(j)))
                            obj[j - 1] = (double)RobResRowSet.CurrentRow.GetValue(RobResRowSet.ResultIds.Get(j));
                    }
                       
                }

                table.Rows.Add(obj);
                i++;
                ok = RobResRowSet.MoveNext();
            }
            return table;
        }

        public Storys QueryResultsForStorey(int loadCase, 
             IProgress<ProgressModelObject<double>> progress,
             CancellationToken ct)
        {
            var result = new Storys();

            for (int i = 1; i < str.Storeys.Count+1; i++)
            {
                var storey = str.Storeys.Get(i);
                var storeyIndex = str.Storeys.Find(storey.Name);
                progress.Report(new ProgressModelObject<double>
                {
                    ProgressToString=$"Addding data from slab/case: {storey.Name}/{loadCase}..."
                });

                var story = new Story
                {
                    Index = storeyIndex,
                    Name = str.Storeys.Get(i).Name,
                    LVL = storey.Level,
                    Height = storey.Height,
                    ReducedForces = str.Results.Storeys.ReducedForces(storeyIndex, loadCase),
                    Displacements = str.Results.Storeys.Displacements(storeyIndex, loadCase),
                    Values = str.Results.Storeys.Values(storeyIndex, loadCase),

                };
                result.Add(story);
            }

            return result;
        }
        public async Task<Storys> QueryResultsForStoreyAsync(int loadCase,
           IProgress<ProgressModelObject<double>> progress,
           CancellationToken ct) 
        {
            return await Task.Run(() =>
            {
                return QueryResultsForStorey(loadCase, progress, ct);
            });
        }

        public async Task<Storys[]> QueryResultsForStoreyByCasesAsync(int[] loadCase,
             IProgress<ProgressModelObject<double>> progress,
             CancellationToken ct)
        {
            var result = new Storys[loadCase.Length];
            for (int i = 0; i < loadCase.Length; i++)
            {
                result[i] = await QueryResultsForStoreyAsync(loadCase[i], progress, ct);
            }
            return result;
        }

        private DataTable CreateTable()
        {
            var table = new DataTable();

            // Create new DataColumn, set DataType, 
            // ColumnName and add to DataTable.    
            var column = new DataColumn();

            column = new DataColumn("STOREY NAME", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("MASS X", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("MASS Y", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("MASS Z", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("MASS", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DPL MAX UX", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DPL MAX UY", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DPL MIN UX", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DPL MIN UY", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DPL UX", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DPL UY", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DRFR UX", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DRFR UY", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DRF UX", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("DRF UY", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED FX", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED FY", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED FZ", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED FX ON COLUMNS", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED FY ON COLUMNS", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED FX ON WALLS", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED FY ON WALLS", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("REDUCED MX IN GRAVITY POINT", typeof(double));
            table.Columns.Add(column);

            column = new DataColumn("GRAVITY POINT", typeof(string));
            table.Columns.Add(column);

            return table;
        }
    }
    public class Storys:List<Story>
    {

    }
    public class Story
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public double LVL { get; set; }
        public double Height { get; set; }

        public RobotStoreyReducedForces ReducedForces { get; set; }
        public RobotStoreyDisplacements Displacements { get; set; }
        public RobotStoreyValues Values { get; set; }

    }

}
