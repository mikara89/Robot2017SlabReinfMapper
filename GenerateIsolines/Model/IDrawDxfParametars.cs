using GenerateIsolines.Model;
using System.Collections.Generic;


namespace GenerateIsolines
{
    public interface IDrawParameters
    {
        List<Panel> slabEdgesNodes { get; set; }
        Legend Legend { get; set; }
        List<RSA_FE> ListFe { get; set; }
        DrawAsType drawAsType { get; set; }
        A_Type a_Type { get; set; }
        double SkipA { get; set; }
    }
}