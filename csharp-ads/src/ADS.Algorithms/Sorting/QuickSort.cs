using System;
using ADS.FX;

namespace ADS.Algorithms.Sorting
{
    public sealed class QuickSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void SortList(T[] list)
        {
            SortList(list, 0, list.Length);
        }

        private void SortList(T[] list, int start, int end)
        {
            if (end - start < 2)
                return;

            var pivotIndex = Partition(list, start, end);
            SortList(list, start, pivotIndex);
            SortList(list, pivotIndex + 1, end);
        }

        private int Partition(T[] list, int start, int end)
        {
            var pivot = list[start];
            var left = start;
            var right = end;

            while (left < right)
            {
                while (left < right && list[--right].CompareTo(pivot) >= 0) { }

                if (left < right)
                    list[left] = list[right];

                while (left < right && list[++left].CompareTo(pivot) <= 0) { }

                if (left < right)
                    list[right] = list[left];
            }

            list[right] = pivot;

            return right;
        }
    }
}