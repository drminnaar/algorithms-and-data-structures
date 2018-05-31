using System;
using ADS.FX;

namespace ADS.Algorithms.Sorting
{
    public sealed class ShellSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void SortList(T[] list)
        {
            var i = 0;
            var j = 0;
            var key = default(T);

            for (int gap = list.Length / 2; gap > 0; gap /= 2)
            {
                for (i = gap; i < list.Length; i++)
                {
                    key = list[i];
                    j = i;

                    while (j >= gap && key.CompareTo(list[j - gap]) < 0)
                    {
                        list.Swap(j, j - gap);
                        j -= gap;
                    }
                }
            }
        }
    }
}