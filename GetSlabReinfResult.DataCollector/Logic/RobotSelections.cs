using RobotOM;
using System;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public class RobotSelections : IRobotSelections
    {
        private readonly IRobotApplication robot;

        public RobotSelections(IRobotApplication robot)
        {
            this.robot = robot;
        }
        public string GetSlabSelection(string lastSelection)
        {

            if (robot == null) return lastSelection;
            try
            {
                string sel = robot
                .Project
                .Structure
                .Selections
                .Get(RobotOM.IRobotObjectType.I_OT_PANEL)
                .ToText();
                if (sel != lastSelection && sel.Trim()!="")
                {
                    return sel;
                }
            }
            catch (Exception ex)
            {
                var a = ex;
            }
            return lastSelection;
        }
    }
}
