using System;
using System.Collections.Generic;

namespace GenerateIsolines
{
    public class Panel
    {
        public List<Node> NodeEdges { get; set; }
        public int PanelId { get; set; }
        public Panel()
        {
            NodeEdges = new List<Node>();
        }
    }
    public class Node 
    {
        public double A { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; } 

        public Node()
        {

        }
        public bool Compare(Node y)
        {
            return this.X == y.X && this.Y == y.Y;
        }

        public static Node GetMiddleNode(Node n1, Node n2)
        {
            return new Node { X = (n1.X + n2.X) / 2, Y = (n1.Y + n2.Y) / 2, A= (n1.A + n2.A) / 2 };
        }
        public static double GetDegreeNode(Node n1, Node n2) 
        {
            var dx = n2.X - n1.X;
            var dy = n2.Y - n1.Y;

            int deg = Convert.ToInt32(Math.Atan2(dy, dx) * (180 / Math.PI));
            if (deg < 0) { deg += 360; }

            return deg;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Node);
        }
        public bool Equals(Node obj)
        {
            return obj != null && obj.X == this.X && obj.Y == this.Y;
            // Or whatever you think qualifies as the objects being equal.
        }

    }
}



