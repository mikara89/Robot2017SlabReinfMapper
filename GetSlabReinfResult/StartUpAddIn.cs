using GenerateIsolines;
using GetSlabReinfResult;
using GetSlabReinfResult.DataCollector.Logic;
using RobotOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GetSlabReinfResult
{


    [ComVisible(true)]
    [Guid("f788c310-00f1-486d-8d3f-835beea61c77")]
    public class StartUpAddIn : IRobotAddIn
    {
        private IRobotApplication iapp = null;
        private MainWindow w = null;

        public double GetExpectedVersion()
        {
           throw new NotImplementedException() ;
        }
        public bool Connect(RobotApplication robot_app, int add_in_id, bool first_time)
        {
            Services.RobotAppService.iapp = robot_app;
            InitAddAssembly();
            return true;
        }


        public int InstallCommands(RobotCmdList cmd_list)
        {
    
            cmd_list.New(1, "Export slab reinforcement to .dxf"); // Text in Robot menu
            cmd_list.New(2, "test"); // Text in Robot menu
            return cmd_list.Count;
        }

        public bool Disconnect()
        {
            w = null;
            Services.RobotAppService.iapp = null;
            return true;
        }

        public void DoCommand(int cmd_id)
        {

            try
            {
                if (cmd_id == 1)
                {
                    w = new MainWindow();
                    w.Show();
                }
                else
                {
                    TestCollectPunchingForce();
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

        private void TestCollectPunchingForce()
        {

            var s = new DataCollector.Logic.CollectPunchingForce(Services.RobotAppService.iapp);

            s.CollectDataShareForces(new int[] { 327 }, new Progress<ProgressModelObject<double>>(), default);
            var l = new CreatePunchingLine( ShapeType.End_Wall, 90,0.15,0.25);
            var edge = s.PanelEdges.SelectMany(c => c.NodeEdges.Select(n => n));
            var line= l.GetNodesOfLine(s.GetNode(1886), edge.ToArray());
            var panelnodes = s.Panel.SelectMany(c => c.nodes.Select(n => n));
            var Fline = new Q12InPunchLine(s.GetResultsInFE().ToArray(), line);
            var max= Fline.Nodes.Max(f=>f.A)/1000;
        }
    }
}
