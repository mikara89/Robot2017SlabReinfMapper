using GetSlabReinfResult;
using RobotOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RobotSlabReinfMapperAddIn
{


    [ComVisible(true)]
    [Guid("572b93b1-2b95-47b4-8fa9-6db05bef5de3")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("RobotSlabReinfMapperAddIn.Class1")]
    public class Class1 : IRobotAddIn, IClass1
    {
        private IRobotApplication iapp = null;

        public double GetExpectedVersion()
        {
            throw new NotImplementedException();
        }

        

        public bool Connect(RobotApplication robot_app, int add_in_id, bool first_time)
        {
            iapp = robot_app;
            return true;
        }

        public int InstallCommands(RobotCmdList cmd_list)
        {
            cmd_list.New(1, "My Command 1"); // Text in Robot menu
            return cmd_list.Count;
        }

        public bool Disconnect()
        {
            iapp = null;
            return true;
        }
        public void DoCommand(int cmd_id)
        {
            MessageBox.Show("App will run now4!");
            App app = new App();
            app.InitializeComponent();
            app.Run();
            //var w = new MainWindow();
            //w.ShowDialog();
        }
    }
    [ComVisible(true)]
    [Guid("67F6AA4C-A9A5-4682-98F9-15BDF2246A74")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    internal interface IClass1
    {
    }
}
