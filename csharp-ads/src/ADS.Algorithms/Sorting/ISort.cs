using System;

namespace ADS.Algorithms.Sorting
{
    public interface ISort<T> where T : IComparable<T>
    {
        T[] Sort(T[] list);
    }
}