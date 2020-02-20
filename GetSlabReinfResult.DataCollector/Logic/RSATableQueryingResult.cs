using GenerateIsolines;
using RobotOM;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace GetSlabReinfResult.DataCollector.Logic
{

    public class RSATableQueryingResult /*: IRSATableQueryingResult*/
    {

        private string temp;
        private double plus = 10;

        public async Task<List<RSA_FE>> ReadFromTableAsync(int[] ObjNumber,
                                        IProgress<ProgressModelObject<double>> progress,
                                        CancellationToken ct)
        {
            return await Task.Run(() =>
             {
                return  ReadFromTable(ObjNumber, progress, ct);
             },ct);
        }
        

            public List<RSA_FE> ReadFromTable(int[] ObjNumber,
                                        IProgress<ProgressModelObject<double>> progress,
                                        CancellationToken ct)
        {
            var Plat = new List<RSA_FE>();
  
            try
            {
                if (ct.IsCancellationRequested) return null;
                GetAllFeFromSlab(ObjNumber, progress);
                
                var t = ConvertCSVtoDataTable(temp);

                progress.Report(new ProgressModelObject<double>
                { ProgressToString = "Reading FE from table in temp file...", Progress = 6 * plus });

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    if (ct.IsCancellationRequested) break;
                    var fe = new RSA_FE
                    {
                        FE_ID = Convert.ToInt32(t.Rows[i][(int)FE_TABLE_ROWS.Elenents]),
                        Panel_ID = Convert.ToInt32(t.Rows[i][(int)FE_TABLE_ROWS.Panel]),

                    };
                    fe.nodes = new List<RSANode>();

                    fe.nodes.Add(new RSANode
                    {
                        NodeId = Convert.ToInt32(t.Rows[i][((int)FE_TABLE_ROWS.Node1)]),
                    });

                    fe.nodes.Add(new RSANode
                    {
                        NodeId = Convert.ToInt32(t.Rows[i][((int)FE_TABLE_ROWS.Node2)]),
                    });

                    fe.nodes.Add(new RSANode
                    {
                        NodeId = Convert.ToInt32(t.Rows[i][((int)FE_TABLE_ROWS.Node3)]),
                    });

                    if (Convert.ToString(t.Rows[i][(int)FE_TABLE_ROWS.ElementType]) != "T3")
                    {
                        fe.nodes.Add(new RSANode
                        {
                            NodeId = Convert.ToInt32(t.Rows[i][((int)FE_TABLE_ROWS.Node4)]),
                        });
                    }
                    Plat.Add(fe);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                progress.Report(new ProgressModelObject<double>
                { ProgressToString = "Deleting temp file..", Progress = 7 * plus });
                TempFileManager.DeleteTmpFile(temp);
            }

            return Plat;
        }

        private DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = File.OpenText(strFilePath))
            {
            
                string[] headers = sr.ReadLine().Split(';');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }
            return dt;
        }

        private void GetAllFeFromSlab(int[] ObjNumbers, 
            IProgress<ProgressModelObject<double>> progress)
        {

            IRobotApplication RobApp;
            RobApp = Services.RobotAppService.iapp;
            RobotTable t;
            RobotTableFrame tf;

            var str = RobApp.Project.Structure;
            var fe = "";
            var ObjNumbersString = "";
            foreach (var objNumber in ObjNumbers)
            {
                var slab = (RobotObjObject)str.Objects.Get(objNumber);
                fe +=slab.FiniteElems+ " ";
                ObjNumbersString += objNumber + " ";
            }
           
            
            var selectFe = str.Selections.Create(IRobotObjectType.I_OT_PANEL);
            selectFe.FromText(fe);

            progress.Report(new ProgressModelObject<double> { ProgressToString = "Creating FE table...", Progress = 1 * plus });
            t = RobApp.Project.ViewMngr.CreateTable(IRobotTableType.I_TT_FINITE_ELEMENTS, IRobotTableDataType.I_TDT_FE);
            tf = RobApp.Project.ViewMngr.GetTable(RobApp.Project.ViewMngr.TableCount);

            progress.Report(new ProgressModelObject<double> { ProgressToString = "Filtering FE table for slab number...", Progress = 2 * plus });

            

            t.Select(IRobotSelectionType.I_ST_PANEL, ObjNumbersString);
            t.Select(IRobotSelectionType.I_ST_FINITE_ELEMENT, fe);

            RobotTable a = tf.Get(2);
            progress.Report(new ProgressModelObject<double> { ProgressToString = "Creating temp file to store FE table...", Progress = 3 * plus });
            temp = TempFileManager.CreateTmpFile();
            progress.Report(new ProgressModelObject<double> { ProgressToString = "Writting rows to temp file...", Progress = 4 * plus });

            a.Printable.SaveToFile(temp, IRobotOutputFileFormat.I_OFF_TEXT);

        }
    }

}
