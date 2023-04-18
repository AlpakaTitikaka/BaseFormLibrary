using System;
using System.Collections.Generic;

namespace BaseFormLibrary
{
    public class LibraryMethods
    {
        public static IEnumerable<TSource> Filtering<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector, string filter)
        {
            foreach (var item in source)
                if (selector(item).ToString().Equals(filter))
                    yield return item;
        }

        public static IEnumerable<TSource> Find<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector, string text)
        {
            foreach (var item in source)
                if (selector(item).ToString().Contains(text))
                    yield return item;
        }

        public static IEnumerable<TSource> Filtering<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector, string min, string max)
        {
            foreach (var item in source)
            {
                if (!double.TryParse(selector(item).ToString(), out double a)) continue;
                if (!double.TryParse(min, out double minA)) continue;
                if (!double.TryParse(max, out double maxA)) continue;
                if (a >= minA && a <= maxA)
                {
                    yield return item;
                }
            }
        }
    }
}
