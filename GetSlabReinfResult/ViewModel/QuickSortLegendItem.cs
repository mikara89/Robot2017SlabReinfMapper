using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GetSlabReinfResult.ViewModel
{
    public class QuickSortLegendItem
    {
        public BindingList<LegendItemViewModel> SortList(BindingList<LegendItemViewModel> A, int start, int end)
        {
            if (start >= end) return A;


            var pIndex = Partetion(ref A, start, end);
            A = SortList(A, start, pIndex - 1);
            A = SortList(A, pIndex + 1, end);

            return A;
        }
        
        private int Partetion(ref BindingList<LegendItemViewModel> A, int start, int end)
        {
            var pivet = A[end];
            var pIndex = start;
            LegendItemViewModel a = new LegendItemViewModel();
            for (int i = start; i < end; i++)
            {
                if ( A[i].Areg <= pivet.Areg)
                {
                    A.Swap(i, pIndex);
                    if (pIndex < A.Count() - 1)
                        pIndex++;
                }
            }
            A.Swap(pIndex, end);
            return pIndex;
        }
    }
}
