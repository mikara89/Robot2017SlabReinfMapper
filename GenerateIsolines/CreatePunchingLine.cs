using System;
using System.Collections.Generic;


namespace GenerateIsolines
{
    public class CreatePunchingLine
    {

        public CreatePunchingLine(ShapeType shapeType, double angle, double d, double b)
        {
            ShapeType = shapeType;
            Angle = angle;
            this.d = d;
            this.b = b;
        }

        public ShapeType ShapeType { get; }
        public Node EdgeNode { get; internal set; }
        public double Angle { get; }
        public PositionType PositionType { get; internal set; }
            = PositionType.Middle;
        public double d { get; }
        public double b { get; }

        public Node[] GetNodesOfLine(Node wallNode, Node[] slabNodes)
        {
            IsNodeNearEdge(wallNode, slabNodes);
            switch (ShapeType)
            {
                case ShapeType.Column:
                    return Column_Calc(wallNode);
                case ShapeType.End_Wall:
                    return End_Wall_Calc(wallNode);
                case ShapeType.Corner_Wall_90:
                    return Corner_Wall_90_Calc(wallNode);
                case ShapeType.Corner_Wall_270:
                    return Corner_Wall_270_Calc(wallNode);
                default:
                    throw new Exception("ShapeType not determent.");
            }
        }

        private Node[] Column_Calc(Node wallNode)
        {
            throw new NotImplementedException("Column type not implemented yet.");
        }

        private Node[] Corner_Wall_270_Calc(Node wallNode)
        {
            throw new NotImplementedException("Corner wall type not implemented yet.");
        }

        private Node[] Corner_Wall_90_Calc(Node wallNode)
        {
            throw new NotImplementedException("Corner wall type not implemented yet.");
        }

        private void IsNodeNearEdge(Node wallNode, Node[] slabNodes)
        {
            for (int i = 0; i < slabNodes.Length; i++)
            {
                Node clossestNode;
                double dist;
                if (i == slabNodes.Length - 1)
                    dist = wallNode.FindDistanceToSegment(slabNodes[i], slabNodes[0], out clossestNode);
                else
                    dist = wallNode.FindDistanceToSegment(slabNodes[i], slabNodes[i + 1], out clossestNode);

                if (dist <= 2 * d)
                {
                    if (EdgeNode != null)
                        throw new Exception("Can't calculate this wall/column");
                    EdgeNode = clossestNode;
                    PositionType = PositionType.Edge;
                }
                else clossestNode = null;
            }
        }

        private Node[] End_Wall_Calc(Node wallNode)
        {
            var result = new List<Node>();
            if (PositionType == PositionType.Middle)
            {
                var nodes = new ShapeOfLine(new List<IShape2D>
                {
                    new LineShape(new Node {X=wallNode.X+2*d+b/2, Y=wallNode.Y-1.5*d,Z=wallNode.Z},new Node {X=wallNode.X+2*d+b/2, Y=wallNode.Y,Z=wallNode.Z} ),
                    new ArcShape(new Node {X=wallNode.X+b/2, Y=wallNode.Y,Z=wallNode.Y},new Node {X=wallNode.X+b/2, Y=wallNode.Y+2*d,Z=wallNode.Z},new Node {X=wallNode.X+2*d+b/2, Y=wallNode.Y,Z=wallNode.Z}),
                    new LineShape(new Node {X=wallNode.X+b/2, Y=wallNode.Y+2*d,Z=wallNode.Z},new Node {X=wallNode.X-b/2, Y=wallNode.Y+2*d,Z=wallNode.Z} ),
                    new ArcShape(new Node {X=wallNode.X-b/2, Y=wallNode.Y,Z=wallNode.Z},new Node {X=wallNode.X-(2*d+b/2), Y=wallNode.Y,Z=wallNode.Z},new Node {X=wallNode.X-b/2, Y=wallNode.Y+2*d,Z=wallNode.Z}),
                    new LineShape(new Node {X=wallNode.X-(2*d+b/2), Y=wallNode.Y,Z=wallNode.Z},new Node {X=wallNode.X-(2*d+b/2), Y=wallNode.Y-1.5*d,Z=wallNode.Z} ),
                });

                for (int i = 0; i < nodes.Nodes.Length; i++)
                {
                    double angle;
                    if (Angle + 90 > 360)
                        angle = Angle + 90 - 360;
                    else
                        angle = Angle + 90;
                    result.Add(Node.RotateNode(nodes.Nodes[i], wallNode, angle));
                }
            }
            else if (PositionType == PositionType.Edge)
            {
                throw new NotImplementedException("Edge position not implemented yet.");
            }
            else
                throw new Exception("Position type not known");
            return result.ToArray();
        }
    }

    public class Q12InPunchLine
    {
        public Node[] Nodes { get;internal set; }
        public Q12InPunchLine(FE[] FE, Node[] PunchLine)
        {
            FE.Filter(PunchLine);
            FE.MapNodes();
            Nodes = FE.GetMappedNodes();
        }
    }
}