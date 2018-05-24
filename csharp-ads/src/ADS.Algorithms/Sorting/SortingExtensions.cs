using System;

namespace ADS.Algorithms.Sorting
{
    public static class SortingExtensions
    {
        public static T[] Sort<T>(this T[] list, ISort<T> sortStrategy) where T : IComparable<T>
        {
            return list?.Length < 2 ? list : sortStrategy.Sort(list);
        }

        public static T[] BubbleSort<T>(this T[] list) where T : IComparable<T>
        {
            return list?.Length < 2 ? list : list.Sort(new BubbleSort<T>());
        }

        public static T[] SelectionSort<T>(this T[] list) where T : IComparable<T>
        {
            return list?.Length < 2 ? list : list.Sort(new SelectionSort<T>());
        }
    }
}