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

        public static IEnumerable<TSource> Filtering<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector, int min, int max)
        {
            foreach (var item in source)
            {
                if (!double.TryParse(selector(item).ToString(), out double a)) continue;
                if (min > -1 && max >= min) continue;
                if (a >= min && a <= max)
                {
                    yield return item;
                }
            }
        }
    }
}
