using GetSlabReinfResult;
using System;
using RobotOM;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GetSlabReinfResult.Services.RobotAppService.iapp = new RobotApplication();
            var w = new MainWindow();
            w.ShowDialog();
        }
    }
}
