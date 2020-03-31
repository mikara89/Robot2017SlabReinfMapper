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
        public override string ToString()
        {
            return $"{nameof(this.X)}:{Math.Round(X,3)}|{nameof(this.Y)}:{Math.Round(Y, 3)}|{nameof(this.Z)}:{Math.Round(Z, 3)}|{nameof(this.A)}:{Math.Round(A, 3)}";
        }
        public static Node PointSearcher(Node n2, Node n1, double Areq)
        {
            if ((n1.A > Areq && n2.A < Areq) ||
             (n1.A < Areq && n2.A > Areq))
            {
                var deltA = n1.A - n2.A;
                var deltAreg = Areq - n1.A;
                var deltaX = n1.X - n2.X;
                var deltaY = n1.Y - n2.Y;

                var x = n1.X + Interpulation(deltaX, deltA, deltAreg);
                var y = n1.Y + Interpulation(deltaY, deltA, deltAreg);
                var A = n1.A + deltAreg;
                if (Math.Round(A, 3) != Math.Round(Areq, 3))
                    throw new Exception($"Error: A={A} a Areg={Areq}");
                return new Node() { X = x, Y = y, A = A };

            }
            if (n1.A == Areq) return n1;
            if (n2.A == Areq) return n2;

            return null;
        }

        private static double Interpulation(double x1, double val1, double val2)
        {
            return (1 / (val1 / x1)) * val2;
        }

        public static Node Intersect(Node line1P1, Node line1P2, Node line2P1, Node line2P2)
        {
            //Line1
            double A1 = line1P2.Y - line1P1.Y;
            double B1 = line1P1.X - line1P2.X;
            double C1 = A1 * line1P1.X + B1 * line1P1.Y;

            //Line2
            double A2 = line2P2.Y - line2P1.Y;
            double B2 = line2P1.X - line2P2.X;
            double C2 = A2 * line2P1.X + B2 * line2P1.Y;

            double det = A1 * B2 - A2 * B1;
            if (det == 0)
            {
                return null;//parallel lines
            }
            else
            {
                double x = (B2 * C1 - B1 * C2) / det;
                double y = (A1 * C2 - A2 * C1) / det;
                return new Node { X=x, Y=y};
            }
        }

        public static double GetNodesDistance(Node n1, Node n2)
        {
            return Math.Sqrt(Math.Pow((n2.X -n1.X), 2) + Math.Pow((n2.Y - n1.Y), 2));
        }
        /// <summary>
        /// Rotates one point around another
        /// </summary>
        /// <param name="pointToRotate">The point to rotate.</param>
        /// <param name="centerPoint">The center point of rotation.</param>
        /// <param name="angleInDegrees">The rotation angle in degrees.</param>
        /// <returns>Rotated point</returns>
        public static Node RotateNode(Node pointToRotate, Node centerPoint, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new Node
            {
                X = (cosTheta * (pointToRotate.X - centerPoint.X) -
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                Y = (sinTheta * (pointToRotate.X - centerPoint.X) +
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            };
        }



    }

    public static class Node_Extendions 
    {
        public static void GetZValue(this Node nodeFindZ, Node node1, Node node2)
        {
            var l = Node.GetNodesDistance(node1, nodeFindZ);
            var l1 = Node.GetNodesDistance(node1, node2);
            nodeFindZ.A = ((node2.A - node1.A) / l1 * l) + node1.A;
        }
        public static void MapValueZ(this Node node, Node[] nodes)
        {
            if (node is null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (nodes is null)
            {
                throw new ArgumentNullException(nameof(nodes));
            }

            ///If node is on line segment of borders
            for (int i = 0; i < nodes .Length- 1; i++)
            {
                if (IsNodeOnLine(node, nodes[i], nodes[i + 1]))
                {
                    node.GetZValue(nodes[i], nodes[i + 1]);
                    return;
                }
                    
            }

            ///If node is inside borders
            Node node_helper= new Node();
            for (int i = 1; i < nodes.Length-1; i++)
            {
                node_helper = Node.Intersect(nodes[0], node, nodes[i], nodes[i+1]);
                if (IsNodeOnLine(node_helper, nodes[i], nodes[i + 1]))
                {
                    node_helper.GetZValue(nodes[i], nodes[i + 1]);
                    break;
                }
            }
            node.GetZValue(nodes[0], node_helper);
        }

        public static void MoveNodes(this Node[] nodes, Node node)
        {
            foreach (var n in nodes)
            {
                n.X = n.X + node.X;
                n.Y = n.Y + node.Y;
                n.Z = n.Z + node.Z;
            }
        }
        public static bool IsNodeOnLine(Node node, Node lineP1, Node lineP2)
        {
            var AB = Math.Sqrt((lineP2.X - lineP1.X) * (lineP2.X - lineP1.X) + (lineP2.Y - lineP1.Y) * (lineP2.Y - lineP1.Y));
            var AP = Math.Sqrt((node.X - lineP1.X) * (node.X - lineP1.X) + (node.Y - lineP1.Y) * (node.Y - lineP1.Y));
            var PB = Math.Sqrt((lineP2.X - node.X) * (lineP2.X - node.X) + (lineP2.Y - node.Y) * (lineP2.Y - node.Y));
            if (AB / (AP + PB) < 1.01 && AB / (AP + PB) > 0.99)
                return true;
            else return false;
        }
        // Calculate the distance between
        // point pt and the segment p1 --> p2.
        public static double FindDistanceToSegment(this Node pt, Node p1, Node p2, out Node closest)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            if ((dx == 0) && (dy == 0))
            {
                // It's a point not a line segment.
                closest = p1;
                dx = pt.X - p1.X;
                dy = pt.Y - p1.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }

            // Calculate the t that minimizes the distance.
            double t = ((pt.X - p1.X) * dx + (pt.Y - p1.Y) * dy) /
                (dx * dx + dy * dy);

            // See if this represents one of the segment's
            // end points or a point in the middle.
            if (t < 0)
            {
                closest = new Node { X = p1.X, Y = p1.Y };
                dx = pt.X - p1.X;
                dy = pt.Y - p1.Y;
            }
            else if (t > 1)
            {
                closest = new Node { X = p2.X, Y = p2.Y };
                dx = pt.X - p2.X;
                dy = pt.Y - p2.Y;
            }
            else
            {
                closest = new Node { X = p1.X + t * dx, Y = p1.Y + t * dy };
                dx = pt.X - closest.X;
                dy = pt.Y - closest.Y;
            }

            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}



