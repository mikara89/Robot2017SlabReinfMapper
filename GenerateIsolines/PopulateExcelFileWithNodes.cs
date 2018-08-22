using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenerateIsolines
{
    public static class PopulateExcelFileWithNodes
    {
        private static Application xlApp;
        private static Workbook xlWorkBook;
        private static Worksheet xlWorkSheet;

        public static async Task Populte(List<Node> nodes,string full_fileName)
        {
            object misValue = System.Reflection.Missing.Value;
            try
            {
                xlApp = new Application();

                if (xlApp == null)
                {
                    throw new Exception("Excel is not properly installed!!");
                }

                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    for (int i = 0; i < nodes.Count; i++)
                    {

                        xlWorkSheet.Cells[i + 1, 1] = nodes.ToArray()[i].X;
                        xlWorkSheet.Cells[i + 1, 2] = nodes.ToArray()[i].Y;
                        xlWorkSheet.Cells[i + 1, 3] = nodes.ToArray()[i].A;
                    }

                xlWorkBook.SaveAs(full_fileName);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

            }
            catch (Exception ex)
            {
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                throw new Exception("Error in making Excel: "+ex.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }
        public static async Task PopulteFe(List<RSA_FE> fe, string full_fileName, IProgress<ProgressModelObject<double>> progress, CancellationToken ct)
        {
            object misValue = System.Reflection.Missing.Value;
            try
            {
                xlApp = new Application();

                if (xlApp == null)
                {
                    throw new Exception("Excel is not properly installed!!");
                }

                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int counter = 0;
                    for (int i = 0; i < fe.Count; i++)
                    {
                    counter++;
                        if (counter % 10 == 0)
                        {
                            double percentage = (double)counter / fe.Count * 100;
                            progress.Report(new ProgressModelObject<double>()
                            {
                                Progress = percentage,
                                CurrentValue = counter,
                                MaxValue = fe.Count,
                                ProgressToString = $"Excel file writting: {counter} row of {fe.Count} rows"
                            });
                        }
                        if (ct.IsCancellationRequested) continue;
                        xlWorkSheet.Cells[i + 1, 1] = fe.ToArray()[i].FE_ID;

                        for (int j = 0; j < fe[i].nodes.Count; j++)
                        {
                            xlWorkSheet.Cells[i + 1, 2] = fe.ToArray()[i].nodes[j].NodeId;
                            xlWorkSheet.Cells[i + 1, 3] = fe.ToArray()[i].nodes[j].AX_TOP;
                            xlWorkSheet.Cells[i + 1, 4] = fe.ToArray()[i].nodes[j].AY_TOP;
                            xlWorkSheet.Cells[i + 1, 5] = fe.ToArray()[i].nodes[j].AX_BOTTOM;
                            xlWorkSheet.Cells[i + 1, 6] = fe.ToArray()[i].nodes[j].AY_BOTTOM;
                        }

                    }

                    if(!ct.IsCancellationRequested)
                        xlWorkBook.SaveAs(full_fileName);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();


            }
            catch (Exception ex)
            {
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                throw new Exception("Error in making Excel: " + ex.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }
    }
}
