using netDxf;

namespace GenerateIsolines
{
    public interface IDrawMapping
    {
        double[] LegendPosition { get; }
        double offsetForLegend { get; set; }
        IDrawParameters Parm { get; }

        IDrawMapping CreatAllLayer();
        IDrawMapping SetParamForDrawing(IDrawParameters drawParameters);
        IDrawMapping DrawEdges();
        IDrawMapping DrawIsolines();
        IDrawMapping DrawLegend();
        IDrawMapping SaveDrawing(string filePath);
    }
}