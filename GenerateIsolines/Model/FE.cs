using System.Collections.Generic;


namespace GenerateIsolines
{
    public class FE 
    {
        public List<Node> nodes;
        public List<Node> nodesForMapping= new List<Node>(); 
        public int FE_ID { get; set; }
        public int Panel_ID { get; set; }

        public void ConvertFromRSA_FEToFE(RSA_FE element,A_Type TypeOfA) 
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
    }
}



