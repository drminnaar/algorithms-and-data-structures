using System;
using ADS.FX;

namespace ADS.Algorithms.Sorting
{
    public sealed class BubbleSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void SortList(T[] list)
        {
            for (int lastSortedIndex = (list.Length - 1); lastSortedIndex > 0; lastSortedIndex--)
            {
                for (int i = 0; i < lastSortedIndex; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                        list.Swap(i, i + 1);
                }
            }
        }
    }
}