using GenerateIsolines;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GetSlabReinfResult.UnitTest
{
    [TestClass]
    public class NodesTest
    {
        [TestMethod]
        [DataRow(-3.1413,-0.1455 , -5.4338, -1.8561,8, -5.1956, 3.0925, 13, -1.6977, 3.1301, 10, 0, 0, 0)]
        public void TestNodes(double px1, double py1, 
            double l1x, double l1y, double l1z, 
            double l2x, double l2y, double l2z, 
            double l3x, double l3y, double l3z,
            double l4x, double l4y, double l4z) 
        {

            var node = new Node{X= px1, Y= py1 };
            var nodes = new Node[] {
                new Node { X =l1x, Y =l1y, A = l1z } ,
                new Node { X =l2x, Y =l2y, A = l2z } ,
                new Node { X =l3x, Y =l3y, A = l3z } ,
                new Node { X =l4x, Y =l4y, A = l4z } ,
            };

            node.MapValueZ(nodes);

            Assert.IsTrue(Math.Round(node.A,2) == 6.50);
        }
    }
}
