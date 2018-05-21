using System;
using System.Collections.Generic;
using System.Linq;

namespace ADS.FX
{
    public static class ArrayExtensions
    {
        public static T[] Copy<T>(this T[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            var clone = new T[list.Length];

            list.CopyTo(clone, 0);

            return clone;
        }

        public static void Swap<T>(this T[] list, int lhs, int rhs)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (list.Any(e => e == null))
                throw new ArgumentException("Null elements not allowed.", nameof(list));

            if (list.Length < 2)
                return;

            var temp = list[rhs];
            list[rhs] = list[lhs];
            list[lhs] = temp;
        }
    }
}
