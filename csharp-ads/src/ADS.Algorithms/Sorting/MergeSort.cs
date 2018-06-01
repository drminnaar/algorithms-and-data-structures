using System;
using ADS.FX;

namespace ADS.Algorithms.Sorting
{
    public sealed class MergeSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void SortList(T[] list)
        {
            SortList(list, new T[list.Length], 0, list.Length - 1);
        }

        private void SortList(T[] list, T[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
                return;

            var middle = (leftStart + rightEnd) / 2;
            SortList(list, temp, leftStart, middle);
            SortList(list, temp, middle + 1, rightEnd);
            MergeList(list, temp, leftStart, rightEnd);
        }

        private void MergeList(T[] list, T[] temp, int leftStart, int rightEnd)
        {
            var leftEnd = (leftStart + rightEnd) / 2;
            var rightStart = leftEnd + 1;
            var size = rightEnd - leftStart + 1;
            var leftIndex = leftStart;
            var rightIndex = rightStart;
            var tempIndex = leftStart;

            while (leftIndex <= leftEnd && rightIndex <= rightEnd)
            {
                temp[tempIndex++] = list[leftIndex].CompareTo(list[rightIndex]) < 0
                    ? list[leftIndex++]
                    : list[rightIndex++];
            }

            Array.Copy(list, leftIndex, temp, tempIndex, leftEnd - leftIndex + 1);
            Array.Copy(list, rightIndex, temp, tempIndex, rightEnd - rightIndex + 1);
            Array.Copy(temp, leftStart, list, leftStart, size);
        }
    }
}