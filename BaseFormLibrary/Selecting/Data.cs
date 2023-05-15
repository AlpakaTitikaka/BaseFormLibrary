using System;
using System.Collections.Generic;

namespace BaseFormLibrary.Selecting
{
    /// <summary>
    /// Методы для работы с данными
    /// </summary>
    public static class Data
    {
        /// <summary>
        /// Фильтрация источника по фильтру
        /// </summary>
        /// <typeparam name="TSource">Тип источника</typeparam>
        /// <typeparam name="TKey">Тип ключа фильтра</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="selector">Ключ</param>
        /// <param name="filter">Фильтр</param>
        /// <returns>Фильтрованный источник</returns>
        public static IEnumerable<TSource> Filtering<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector, string filter)
        {
            foreach (var item in source)
                if (selector(item).ToString().Equals(filter))
                    yield return item;
        }
        /// <summary>
        /// Поиск результатов в источнике
        /// </summary>
        /// <typeparam name="TSource">Тип источника</typeparam>
        /// <typeparam name="TKey">Тип ключа для поиска</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="selector">Ключ</param>
        /// <param name="text">Запрос</param>
        /// <returns>Все найденные элементы</returns>
        public static IEnumerable<TSource> Find<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector, string text)
        {
            foreach (var item in source)
                if (selector(item).ToString().Contains(text))
                    yield return item;
        }
        /// <summary>
        /// Фильтрация по промежутку
        /// </summary>
        /// <typeparam name="TSource">Тип источника</typeparam>
        /// <typeparam name="TKey">Тип ключа для фильтрации</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="selector">Ключ</param>
        /// <param name="min">Нижняя граница (минимальное)</param>
        /// <param name="max">Верхняя граница (максимальное)</param>
        /// <returns>Отфильтрованный источник</returns>
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
