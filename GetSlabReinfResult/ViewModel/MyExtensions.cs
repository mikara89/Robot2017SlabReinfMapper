using System.Collections.Generic;

namespace GetSlabReinfResult.ViewModel
{
    public static class MyExtensions
    {
        public static void Swap<T>(this IList<T> A, int index1, int index2)
        {
            var A1 = A[index1];
            var A2 = A[index2];

            A[index1] = A2;
            A[index2] = A1;
        }
    }
}
