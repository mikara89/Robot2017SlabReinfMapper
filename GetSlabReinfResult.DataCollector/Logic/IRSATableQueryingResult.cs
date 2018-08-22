using System;
using System.Collections.Generic;
using System.Threading;
using GenerateIsolines;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public interface IRSATableQueryingResult
    {
        List<RSA_FE> ReadFromTable(int ObjNumber,
             IProgress<ProgressModelObject<double>> progress,
             CancellationToken ct); 
    } 
}