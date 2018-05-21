using System;
using ADS.FX;

namespace ADS.Algorithms.Sorting
{
    public abstract class SortBase<T> : ISort<T> where T : IComparable<T>
    {
        public T[] Sort(T[] list)
        {
            if (list?.Length < 2)
                return list;

            var clone = list.Copy();

            SortList(clone);

            return clone;
        }

        protected abstract void SortList(T[] list);
    }
}