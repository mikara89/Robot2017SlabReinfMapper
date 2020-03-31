using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GenerateIsolines
{
    public class FE
    {
        public List<Node> nodes;
        public List<Node> nodesForMapping = new List<Node>();
        public int FE_ID { get; set; }
        public int Panel_ID { get; set; }

        public void ConvertFromRSA_FEToFE(RSA_FE element, A_Type TypeOfA)
        {
            FE_ID = element.FE_ID;
            Panel_ID = element.Panel_ID;
            nodes = new List<Node>();
            for (int i = 0; i < element.nodes.Count; i++)
            {
                var n = new Node();
                n.X = element.nodes[i].X;
                n.Y = element.nodes[i].Y;
                switch (TypeOfA)
                {
                    case A_Type.AX_TOP:
                        n.A = element.nodes[i].AX_TOP;
                        break;
                    case A_Type.AX_BOTTOM:
                        n.A = element.nodes[i].AX_BOTTOM;
                        break;
                    case A_Type.AY_TOP:
                        n.A = element.nodes[i].AY_TOP;
                        break;
                    case A_Type.AY_BOTTOM:
                        n.A = element.nodes[i].AY_BOTTOM;
                        break;
                    default:
                        break;
                }
                nodes.Add(n);
            }
        }



        public static string GetA_TypeAsString(A_Type A_Type)
        {
            switch (A_Type)
            {
                case A_Type.AX_TOP:
                    return "Ax[+]";
                case A_Type.AX_BOTTOM:
                    return "Ax[-]";
                case A_Type.AY_TOP:
                    return "Ay[+]";
                case A_Type.AY_BOTTOM:
                    return "Ay[-]";
                default:
                    return null;
            }
        }

        public static A_Type GetStringAsA_Type(string val)
        {
            switch (val)
            {
                case "Ax[+]":
                    return A_Type.AX_TOP;
                case "Ay[+]":
                    return A_Type.AY_TOP;
                case "Ax[-]":
                    return A_Type.AX_BOTTOM;
                case "Ay[-]":
                    return A_Type.AY_BOTTOM;
                default:
                    return A_Type.AX_TOP;

            }
        }

      

        ///// <summary>
        ///// Determines if the given point is inside the polygon
        ///// </summary>
        ///// <param name="polygon">the vertices of polygon</param>
        ///// <param name="testPoint">the given point</param>
        ///// <returns>true if the point is inside the polygon; otherwise, false</returns>
       




    }
    public static class Fe_Extendions
    {
        private static bool IsPointInPolygon4(Node[] polygon, Node testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
        public static FE[] Filter<T>(this T[] list, Node[] nodes)
         where T : FE
        {
            List<FE> result = new List<FE>();

            foreach (T fe in list)
            {
                foreach (var node in nodes)
                {
                    if (IsPointInPolygon4(fe.nodes.ToArray(), node))
                        if (result.Any(x => x == fe))
                            result.Find(x => x == fe).nodesForMapping.Add(node);
                        else
                        {
                            fe.nodesForMapping.Add(node);
                            result.Add(fe);
                        }
                }
            }
            return result.ToArray();
        }
        public static Node[] GetMappedNodes<T>(this T[] list)
     where T : FE
        {
            List<Node> result = new List<Node>();

            foreach (T fe in list)
            {
                foreach (var node in fe.nodesForMapping)
                {
                    result.Add(node);
                }
            }
            return result.ToArray();
        }
        public static void MapNodes<T>(this T[] list)
    where T : FE
        {
            List<Node> result = new List<Node>();

            foreach (T fe in list)
            {
                foreach (var node in fe.nodesForMapping)
                {
                    node.MapValueZ(fe.nodes.ToArray());
                }
            }
        }
    }
}



