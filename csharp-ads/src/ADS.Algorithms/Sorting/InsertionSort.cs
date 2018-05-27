using System;
using ADS.FX;

namespace ADS.Algorithms.Sorting
{
    public sealed class InsertionSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void SortList(T[] list)
        {
            var k = default(T);
            var i = 0;

            for (var firstUnsortedIndex = 1; firstUnsortedIndex < list.Length; firstUnsortedIndex++)
            {
                k = list[firstUnsortedIndex];
                i = firstUnsortedIndex - 1;

                while (i >= 0 && k.CompareTo(list[i]) < 0)
                {
                    list.Swap(i, i + 1);
                    i--;
                }
            }

        }
    }
}