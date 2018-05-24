using System;
using ADS.FX;

namespace ADS.Algorithms.Sorting
{
    public sealed class SelectionSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void SortList(T[] list)
        {
            var maxValueIndex = 0;

            for (int lastUnsortedIndex = (list.Length - 1); lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                maxValueIndex = lastUnsortedIndex;

                for (int i = 0; i <= lastUnsortedIndex; i++)
                {
                    if (list[i].CompareTo(list[maxValueIndex]) > 0)
                        maxValueIndex = i;
                }

                list.Swap(maxValueIndex, lastUnsortedIndex);
            }
        }
    }
}