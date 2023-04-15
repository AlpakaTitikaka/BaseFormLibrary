﻿using BaseFormLibrary.ForFilter;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public delegate void OneFilterEventHandler(object sender, EventArgs e);

    public partial class Filter : UserControl
    {
        /// <summary>
        /// Фильтрует источник данных, по заданным параметрам (по умолчанию один фильтр, промежуток цены и кнопка очистки фильтров)
        /// </summary>
        public Filter()
        {
            InitializeComponent();
            FiltersCount = FiltersCount.One;
        }

        /// <summary>
        /// Событие, происходящее после изменения любых параметров фильтра
        /// </summary>
        public event OneFilterEventHandler Changed;
        /// <summary>
        /// Событие, происходящее после очистки фильтров
        /// </summary>
        public event OneFilterEventHandler FiltersCleared;

        /// <summary>
        /// Надпись фильтра1
        /// </summary>
        public string Text1 
        { 
            get => Title1.Text; 
            set => Title1.Text = value;
        }
        /// <summary>
        /// Надпись фильтра2
        /// </summary>
        public string Text2
        {
            get => Title3.Text;
            set => Title3.Text = value;
        }
        /// <summary>
        /// Надпись фильтра3
        /// </summary>
        public string Text3
        {
            get => Title4.Text;
            set => Title4.Text = value;
        }
        /// <summary>
        /// Надпись цены
        /// </summary>
        public string Text4
        {
            get => Title2.Text;
            set => Title2.Text = value;
        }

        /// <summary>
        /// Количество фильтров на контроле
        /// </summary>
        public FiltersCount FiltersCount 
        { 
            get => Filters.GetEnum(FiltersOnPanel.Controls.OfType<Panel>().Count(p => p.Visible && p.Tag != null));
            set 
            {
                FilterPanel1.Visible = value != FiltersCount.None;
                FilterPanel2.Visible = value == FiltersCount.Two || value == FiltersCount.Three;
                FilterPanel3.Visible = value == FiltersCount.Three;
                resize();
            } 
        }

        /// <summary>
        /// Добавить цену (фильтр с промежутком)
        /// </summary>
        public bool AddPrice
        {
            get => PricePanel.Visible;
            set => PricePanel.Visible = value;
        }

        private string Min { get; set; }
        private string Max { get; set; }

        /// <summary>
        /// Значение минимальной цены (или наименьшего промежутка)
        /// </summary>
        public string MinPrice 
        {
            get => MinPriceString.Text;
            set => MinPriceString.Text = value;
        }
        /// <summary>
        /// Значение максимальной цены (или наибольшего промежутка)
        /// </summary>
        public string MaxPrice 
        {
            get => MaxPriceString.Text;
            set => MaxPriceString.Text = value;
        }

        /// <summary>
        /// Цвет кнопки очистки фильтров
        /// </summary>
        public Color ButtonColor 
        {
            get => ClearFilters.BackColor;
            set => ClearFilters.BackColor = value;
        }

        /// <summary>
        /// Плоский стиль кнопки очистки фильтров
        /// </summary>
        public FlatStyle ButtonFlatStyle
        {
            get => ClearFilters.FlatStyle;
            set => ClearFilters.FlatStyle = value;
        }

        private object SelectedFilter1 { get => Filters1.SelectedIndex != -1 ? Filters1.SelectedItem : null; }
        private object SelectedFilter2 { get => Filters2.SelectedIndex != -1 ? Filters2.SelectedItem : null; }
        private object SelectedFilter3 { get => Filters3.SelectedIndex != -1 ? Filters3.SelectedItem : null; }

        private void ClearFilters_Click(object sender, EventArgs e)
        {
            if (AddPrice)
            {
                MinPrice = Min;
                MaxPrice = Max;
            }
            if (SelectedFilter1 != null)
                Filters1.SelectedIndex = -1;
            if (SelectedFilter2 != null)
                Filters2.SelectedIndex = -1;
            if (SelectedFilter3 != null)
                Filters3.SelectedIndex = -1;
            OnFiltersCleared(sender, e);
        }

        protected virtual void OnChanged(object sender, EventArgs e)
            => Changed(sender, e);

        protected virtual void OnFiltersCleared(object sender, EventArgs e)
            => FiltersCleared(sender, e);

        /// <summary>
        /// Добавление одного фильтра в фильтр1 (только в него)
        /// </summary>
        /// <param name="filters">Массив вариантов параметров фильтра1</param>
        public void AddFilters(object[] filters)
            => Filters1.Items.AddRange(filters);

        /// <summary>
        /// Добавление двух фильтров в фильтр1 и фильтр2 (только в них)
        /// </summary>
        /// <param name="filters1">Массив вариантов параметров фильтра1</param>
        /// <param name="filters2">Массив вариантов параметров фильтра2</param>
        public void AddFilters(object[] filters1, object[] filters2)
        {
            AddFilters(filters1);
            Filters2.Items.AddRange(filters2);
        }

        /// <summary>
        /// Добавление трех фильтров в фильтр1, фильтр2 и фильтр3 (только в них)
        /// </summary>
        /// <param name="filters1">Массив вариантов параметров фильтра1</param>
        /// <param name="filters2">Массив вариантов параметров фильтра2</param>
        /// <param name="filters3">Массив вариантов параметров фильтра3</param>
        public void AddFilters(object[] filters1, object[] filters2, object[] filters3)
        {
            AddFilters(filters1, filters2);
            Filters3.Items.AddRange(filters3);
        }

        /// <summary>
        /// Устанавливает нижнюю и верхнюю границу (минимальную и максимальную) промежутка (цены) 
        /// <para>Строковое представление минимальной и максимальной цены</para>
        /// </summary>
        public void SetMinMax(string min, string max)
        {
            Min = min;
            Max = max;
            MinPrice = Min;
            MaxPrice = Max;
        }
        /// <summary>
        /// Фильтрация источника по одному единственному фильтру1 и цене
        /// <example>
        /// <code>
        ///     filter1.Filtering(db.products, p => p.category, p => p.price);
        /// </code>
        /// </example>
        /// </summary>
        /// <typeparam name="TSource">Тип источника</typeparam>
        /// <typeparam name="TKey">Ключ источника</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="filter">Ключ фильтра</param>
        /// <param name="price">Ключ цены</param>
        /// <returns>Отфильтрованный источник</returns>
        public IEnumerable<TSource> Filtering<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> filter, Func<TSource, TKey> price)
        {
            IEnumerable<TSource> result = FilterByPrice(source, price);
            if (SelectedFilter1 != null)
                result = LibraryMethods.Filtering(FilterByPrice(source, price), filter, (string)SelectedFilter1);
            return result;
        }
        /// <summary>
        /// Фильтрация источника по двум фильтрам (фильтр1 и фильтр2) и цене
        /// <example>
        /// <code>
        ///     filter1.Filtering(db.products, p => p.category, p => p.proizvoditel, p => p.price)
        /// </code>
        /// </example>
        /// </summary>
        /// <typeparam name="TSource">Тип источника</typeparam>
        /// <typeparam name="TKey">Ключ источника</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="filter1">Ключ первого фильтра</param>
        /// <param name="filter2">Ключ второго фильтра</param>
        /// <param name="price">Ключ цены</param>
        /// <returns>Отфильтрованный источник</returns>
        public IEnumerable<TSource> Filtering<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> filter1, Func<TSource, TKey> filter2, Func<TSource, TKey> price)
        {
            IEnumerable<TSource> result = Filtering(source, filter1, price);
            if (SelectedFilter2 != null)
                result = LibraryMethods.Filtering(result, filter2, (string)SelectedFilter2);
            return result;
        }
        /// <summary>
        /// Фильтрация источника по трем фильтрам (фильтр1, фильтр2 и фильтр3) и цене
        /// <example>
        /// <code>
        ///     filter1.Filtering(db.products, p => p.category, p => p.proizvoditel, p => p.size, p => p.price)
        /// </code>
        /// </example>
        /// </summary>
        /// <typeparam name="TSource">Тип источника</typeparam>
        /// <typeparam name="TKey">Ключ источника</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="filter1">Ключ первого фильтра</param>
        /// <param name="filter2">Ключ второго фильтра</param>
        /// <param name="filter3">Ключ третьего фильтра</param>
        /// <param name="price">Ключ цены</param>
        /// <returns>Отфильтрованный источник</returns>
        public IEnumerable<TSource> Filtering<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> filter1, Func<TSource, TKey> filter2, Func<TSource, TKey> filter3, Func<TSource, TKey> price)
        {
            IEnumerable<TSource> result = Filtering(source, filter1, filter2, price);
            if (SelectedFilter3 != null)
                result = LibraryMethods.Filtering(result, filter3, (string)SelectedFilter3);
            return result;
        }

        private IEnumerable<TSource> FilterByPrice<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
        { 
            if (AddPrice)
                return LibraryMethods.Filtering(source, selector, MinPrice, MaxPrice);
            return source;
        }

        private void Filters_SelectedIndexChanged(object sender, EventArgs e)
            => OnChanged(sender, e);

        private void MinPriceString_TextChanged(object sender, EventArgs e)
            => OnChanged(sender, e);

        private void resize()
        {
            FiltersOnPanel.Height = FiltersOnPanel.Controls.OfType<Panel>().Sum(p => p.Height) + ClearFilters.Height + 3;
            Height = FiltersOnPanel.Height;
            Width = FiltersOnPanel.Width;
        }

        private void PricePanel_VisibleChanged(object sender, EventArgs e) => resize();

        private void Filter_FontChanged(object sender, EventArgs e)
        {
            FiltersOnPanel.Font = Font;
            label4.Size = new Size
                (MinPriceString.Width + MaxPriceString.Width + MaxPriceString.Location.X - MinPriceString.Location.X - MinPriceString.Width + 1, MaxPriceString.Height);
            label4.Location = MinPriceString.Location;
            resize();
        }
    }
}