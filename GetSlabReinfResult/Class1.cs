using GetSlabReinfResult;
using RobotOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GetSlabReinfResult
{


    [ComVisible(true)]
    [Guid("195821f7-a8f3-44bf-8e89-5b69839536ab")]
    public class Class1 : IRobotAddIn
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
            cmd_list.New(1, "Export reinforcement to .dxf"); // Text in Robot menu
            return cmd_list.Count;
        }

        public bool Disconnect()
        {
            iapp = null;
            return true;
        }
        public void DoCommand(int cmd_id)
        {
            switch (cmd_id)
            {
                case 1:
                    var w = new MainWindow();
                    w.ShowDialog();
                    break;
                default:
                    break;
            }
            
        }
    }
}
