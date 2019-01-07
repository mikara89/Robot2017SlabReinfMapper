using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GetSlabReinfResult.DataCollector.Logic.MyExtensions;

namespace GetSlabReinfResult.UnitTest
{
    [TestClass]
    public class MyExtensionsTest
    {
        [TestMethod]
        [DataRow("51 69to71 80", new int[] { 51, 69, 70, 71, 80 })]
        [DataRow("51 69to71 80 91to100", new int[] { 51, 69, 70, 71, 80, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 })]
        [DataRow("51 69 80", new int[] { 51, 69, 80 })]
        [DataRow("91to100", new int[] { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 })]
        public void TestToIntArrayFromRobotStringSelection(string test, int[] expet)
        {
            var select = test;
            var selectInt= select.ToIntArrayFromRobotStringSelection();

            for (int i = 0; i < expet.Count(); i++)
            {
                Assert.IsTrue(expet[i] == selectInt[i]);
            }
        }

        [TestMethod]
        [DataRow("51 69tos71 80")]
        [DataRow("51 69to71 80s 91to100")]
        [DataRow("51 69 80to")]
        [DataRow("91to100aa")]
        public void TestToIntArrayFromRobotStringSelectionThrowExpetation(string test)  
        {
            var select = test;
            int[] selectInt;

            try
            {
                selectInt = select.ToIntArrayFromRobotStringSelection();
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Invalid selection string:"));
            }
        }

        [TestMethod]
        [DataRow("51 69to71 80",new int[] { 51, 69, 70, 71, 80 })]
        [DataRow("51 69to71 80 91to100", new int[] { 51, 69, 70, 71, 80, 91,92,93,94,95,96,97,98,99,100})]
        [DataRow("51 69 80", new int[] { 51, 69, 80 })]
        [DataRow("91to100", new int[] { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 })]
        public void TestToRobotSelectionString(string exp,int[] test) 
        {
            int[] select = test;
            string selectInt;

            selectInt = select.ToRobotSelectionString();
            Assert.IsTrue(exp == selectInt);

        }
        
    }
}
