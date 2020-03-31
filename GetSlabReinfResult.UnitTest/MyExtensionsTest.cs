using GenerateIsolines;
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
            var selectInt = select.ToIntArrayFromRobotStringSelection();

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
        [DataRow("51 69to71 80", new int[] { 51, 69, 70, 71, 80 })]
        [DataRow("51 69to71 80 91to100", new int[] { 51, 69, 70, 71, 80, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 })]
        [DataRow("51 69 80", new int[] { 51, 69, 80 })]
        [DataRow("91to100", new int[] { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 })]
        public void TestToRobotSelectionString(string exp, int[] test)
        {
            int[] select = test;
            string selectInt;

            selectInt = select.ToRobotSelectionString();
            Assert.IsTrue(exp == selectInt);

        }

    }

    [TestClass]
    public class Testing_2DShapes 
    {
        [TestMethod]
        public void TestLine()
        {
            var l = new LineShape
                (
                    new Node { X = -4.7943, Y = 7.1569 },
                    new Node { X = -3.1378, Y = 8.4220 }
                );

            var s = l.NodesOnSegment(4)[1];
            Assert.IsTrue(Math.Round(l.Length, 4)== 2.0843);   
            Assert.IsTrue(Math.Round(s.X, 4) == -4.3802);
            Assert.IsTrue(Math.Round(s.Y, 4) == 7.4732);
        }
        [TestMethod]
        public void TestArc()
        { 
            var l = new ArcShape
                (
                    new Node { X = -4.5337, Y = 8.9392 },
                    new Node { X = -5.3321, Y = 8.9392 },
                    new Node { X = -4.5337, Y = 9.7376 }
                );

            var s = l.NodesOnSegment(4);
            Assert.IsTrue(Math.Round(l.Length, 4) == 1.2541);
            Assert.IsTrue(Math.Round(s[1].X, 4) == -5.2713);
            Assert.IsTrue(Math.Round(s[1].Y, 4) == 9.2447);
        }
        [TestMethod]
        public void TestArc2()
        {
            var l = new ArcShape
                (
                    new Node { X = -4.5337, Y = 8.9392 },
                    new Node { X = -5.3321, Y = 8.9392 },
                    new Node { X = -3.7352, Y = 8.9382 }
                );

            var s = l.NodesOnSegment(8);
            Assert.IsTrue(Math.Round(l.Length, 4) == 1.2541*2);
            Assert.IsTrue(Math.Round(s[1].X, 4) == -5.2713);
            Assert.IsTrue(Math.Round(s[1].Y, 4) == 9.2447);
        }
        //[TestMethod]
        //public void TestArc3() 
        //{
        //    var l = new ArcShape
        //        (
        //            new Node { X = -4.5337, Y = 8.9392 },
        //            new Node { X = -5.3321, Y = 8.9392 },
        //            new Node { X = -4.8392, Y = 9.6769 }
        //        );

        //    var s = l.NodesOnSegment(4);
        //    //Assert.IsTrue(Math.Round(l.Length, 4) == 0.9406);
        //    Assert.IsTrue(Math.Round(s[1].X, 4) == -5.2977);
        //    Assert.IsTrue(Math.Round(s[1].Y, 4) == 9.1710);
        //}
    }
}
