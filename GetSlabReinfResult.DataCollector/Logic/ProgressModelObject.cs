using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public class ProgressModelObject<T>
    {
        public T CurrentValue { get; set; }
        public T MaxValue { get; set; }
        public T Progress { get; set; }
        public string ProgressToString { get; set; }
    }
}
