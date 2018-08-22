using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateIsolines
{
    public class RSAColor
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; } = 255;

        public RSAColor(int R, int B, int G)
        {
            this.R = R;
            this.B = B;
            this.G = G;
            this.A = 255;
        }
        public RSAColor(int R, int B, int G, int A)
        {
            this.R = R;
            this.B = B;
            this.G = G; 
            this.A = A;
        }
        public RSAColor()
        {

        }
    }
}
