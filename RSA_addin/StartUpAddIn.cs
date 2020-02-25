using RobotOM;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

namespace RSA_addin 
{


    [ComVisible(true)]
    [Guid("f788c310-00f1-486d-8d3f-835beea61c77")]
    public class StartUpAddIn : IRobotAddIn
    {
        private IRobotApplication iapp = null;
        private GetSlabReinfResult.MainWindow w = null;

        public double GetExpectedVersion()
        {
            throw new NotImplementedException();
        }
        public bool Connect(RobotApplication robot_app, int add_in_id, bool first_time)
        {
            GetSlabReinfResult.Services.RobotAppService.iapp = robot_app;
            TableTetaUI.Services.RobotAppService.iapp = robot_app;
            //InitAddAssembly();
            return true;
        }


        public int InstallCommands(RobotCmdList cmd_list)
        {

            cmd_list.New(1, "Export slab reinforcement to .dxf"); // Text in Robot menu

            cmd_list.New(2, "Table"); // Text in Robot menu
            return cmd_list.Count;
        }

        public bool Disconnect()
        {
            w = null;
            GetSlabReinfResult.Services.RobotAppService.iapp = null;
            return true;
        }

        public void DoCommand(int cmd_id)
        {

            try
            {
                if (cmd_id == 1)
                {
                    w = new GetSlabReinfResult.MainWindow();
                    w.Show();
                }
                else if (cmd_id == 2)
                {
                    var tabelTetaWindow = new TableTetaUI.MainWindow();
                    tabelTetaWindow.Show();
                    //var test = new GetResultForStorys(iapp);

                    ////var t1 = test.QueryResultsForStoreys("12", new Progress<ProgressModelObject<double>>(), default);
                    //    var t = test.QueryResultsForStorey(12, new Progress<ProgressModelObject<double>>(), default); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Adding Assembly that is not added from some reason exp. "Xceed.Wpf.Toolkit"
        /// </summary>
        private void InitAddAssembly()
        {
            var path = System.IO.Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath) + "\\Xceed.Wpf.Toolkit.dll";
            IsAssemblyLoaded(path);
        }

        private void IsAssemblyLoaded(string fullName)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (Assembly assembly in assemblies)
            {
                if (assembly.FullName != fullName)
                {
                    Assembly.LoadFrom(fullName);
                }
            }
        }

    }

}
