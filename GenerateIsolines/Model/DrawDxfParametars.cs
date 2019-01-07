using GenerateIsolines.Model;
using System.Collections.Generic;


namespace GenerateIsolines
{
    public struct DrawDxfParametars: IDrawParameters
    {
        public List<Panel> slabEdgesNodes { get; set; } 
        public Legend Legend { get; set; }
        public List<RSA_FE> ListFe { get; set; }
        public DrawAsType drawAsType { get; set; }
        public A_Type a_Type { get; set; }
        public double SkipA { get; set; }
    }
}