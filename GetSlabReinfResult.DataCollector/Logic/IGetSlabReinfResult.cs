using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GenerateIsolines;
using GenerateIsolines.Model;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public interface IGetSlabReinfResult
    {
        bool IsDataCollected { get; }

        Task CreateDxfDrawingAsync(string filePath, A_Type a_Type, double SkipA, Legend legend, DrawAsType drawAsType = DrawAsType.SOLID);
        void GetSlabsEdges(int[] ObjNumbers, IProgress<ProgressModelObject<double>> progress);
        void QueryResultsAndNodeCoord(string plate, IProgress<ProgressModelObject<double>> progress, CancellationToken ct);
        Task StartAsync(IProgress<ProgressModelObject<double>> progress, CancellationToken ct);
        void Validating(int ObjNumber);
        List<RSA_FE> Panel { get;}
        List<Panel> PanelEdges { get; } 
    }
}