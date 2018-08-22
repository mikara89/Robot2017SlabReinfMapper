namespace GenerateIsolines
{
    public class RSANode 
    {
        public double AX_TOP { get; set; }
        public double AX_BOTTOM { get; set; }
        public double AY_TOP { get; set; }
        public double AY_BOTTOM { get; set; }

        public double X { get; set; }
        public double Y { get; set; } 
        public double Z { get; set; }

        public RSANode() 
        {

        }
        public int NodeId { get; set; }
        public int FE_Number { get; set; } 
    }
}



