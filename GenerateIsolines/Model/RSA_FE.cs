using GenerateIsolines.Model;
using netDxf;
using netDxf.Entities;
using netDxf.Header;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenerateIsolines
{
    public class RSA_FE
    {
        public List<RSANode> nodes;
        public int FE_ID { get; set; }
        public int Panel_ID { get; set; }
        public double Max_AX_TOP
        {
            get
            { return nodes != null ? nodes.Max(x => x.AX_TOP) : 0; }
        }
        public double Max_AY_TOP
        {
            get
            { return nodes!=null? nodes.Max(x => x.AY_TOP):0; }
        }
        public double Max_AX_BOTTOM
        {
            get
            { return nodes != null ? nodes.Max(x => x.AX_BOTTOM) : 0; }
        }
        public double Max_AY_BOTTOM
        {
            get
            { return nodes != null ? nodes.Max(x => x.AY_BOTTOM) : 0; }
        }
        public double ExtremeMax(A_Type a_Type)
        {
            switch (a_Type)
            {
                case A_Type.AX_TOP:
                    return Max_AX_TOP;
                case A_Type.AX_BOTTOM:
                    return Max_AX_BOTTOM; ;
                case A_Type.AY_TOP:
                    return Max_AY_TOP; ;
                case A_Type.AY_BOTTOM:
                    return Max_AY_BOTTOM; ;
                default:
                    return 0;
            }
        }

        public double Min_AX_TOP
        {
            get
            { return nodes != null ? nodes.Min(x => x.AX_TOP) : 0; }
        }
        public double Min_AY_TOP
        {
            get
            { return nodes != null ? nodes.Min(x => x.AY_TOP) : 0; }
        }
        public double Min_AX_BOTTOM
        {
            get
            { return nodes != null ? nodes.Min(x => x.AX_BOTTOM) : 0; }
        }
        public double Min_AY_BOTTOM
        {
            get
            { return nodes != null ? nodes.Min(x => x.AY_BOTTOM) : 0; }
        }
        public double ExtremeMin(A_Type a_Type)
        {
            switch (a_Type)
            {
                case A_Type.AX_TOP:
                    return Min_AX_TOP;
                case A_Type.AX_BOTTOM:
                    return Min_AX_BOTTOM; ;
                case A_Type.AY_TOP:
                    return Min_AY_TOP; ;
                case A_Type.AY_BOTTOM:
                    return Min_AY_BOTTOM; ;
                default:
                    return 0;
            }
        }
    }
}



