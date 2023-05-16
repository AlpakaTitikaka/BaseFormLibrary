using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BaseFormLibrary.Selecting
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void OneFilterEventHandler(object sender, EventArgs e);

    /// <summary>
    /// Фильтрует источник данных, по заданным параметрам (по умолчанию один фильтр, промежуток цены и кнопка очистки фильтров)
    /// </summary>
    public partial class Filter : UserControl
    {
        /// <summary>
        /// Фильтрует источник данных, по заданным параметрам (по умолчанию один фильтр, промежуток цены и кнопка очистки фильтров)
        /// </summary>
        public Filter()
        {
            InitializeComponent();
            FiltersCount = 1;
        }

        /// <summary>
        /// Событие, происходящее после изменения любых параметров фильтра
        /// </summary>
        public event OneFilterEventHandler Changed; // зачем
        /// <summary>
        /// Событие, происходящее после очистки фильтров
        /// </summary>
        public event OneFilterEventHandler FiltersCleared; // принцип YAGNI

        /// <summary>
        /// Надпись фильтра1
        /// </summary>
        public string Filter1 
        { 
            get => Title1.Text; 
            set => Title1.Text = value;
        }
        /// <summary>
        /// Надпись фильтра2
        /// </summary>
        public string Filter2
        {
            get => Title3.Text;
            set => Title3.Text = value;
        }
        /// <summary>
        /// Надпись фильтра3
        /// </summary>
        public string Filter3
        {
            get => Title4.Text;
            set => Title4.Text = value;
        }
        /// <summary>
        /// Надпись цены
        /// </summary>
        public string Price
        {
            get => Title2.Text;
            set => Title2.Text = value;
        }

        /// <summary>
        /// Количество фильтров на контроле
        /// </summary>
        public int FiltersCount 
        {
            // чё за хуйня
            // количество фильтров лох
            get => FiltersOnPanel.Controls.OfType<Panel>().Count(p => p.Visible && p.Tag != null);
            set 
            {
                FilterPanel1.Visible = value > 0;
                FilterPanel2.Visible = value > 1;
                FilterPanel3.Visible = value > 2;
                resize();
            } 
        }

        /// <summary>
        /// Добавить цену (фильтр с промежутком)
        /// </summary>
        public bool isCheckPrice
        {
            get => PricePanel.Visible;
            set => PricePanel.Visible = value;
        }


        /// <summary>
        /// Значение минимальной цены (или наименьшего промежутка)
        /// </summary>
        public int MinPrice 
        {
            // Поле и свойство цены должно быть связано. Но в этом случае   
            get => MinPriceBox.Numbers;
            set => MinPriceBox.Numbers = value; 

        }
        /// <summary>
        /// Значение максимальной цены (или наибольшего промежутка)
        /// </summary>
        public int MaxPrice 
        {
            get => MaxPriceBox.Numbers;
            set => MaxPriceBox.Numbers = value;
            
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

        private void ClearFilters_Click(object sender, EventArgs e)
        {
            if (Filters1.SelectedItem != null)
                Filters1.SelectedIndex = -1;
            if (Filters2.SelectedItem != null)
                Filters2.SelectedIndex = -1;
            if (Filters3.SelectedItem != null)
                Filters3.SelectedIndex = -1;
            OnFiltersCleared(sender, e);
        }
        /// <summary>
        /// Событие, возникающее после любых изменений в параметрах фильтров
        /// </summary>
        protected virtual void OnChanged(object sender, EventArgs e)
            => Changed(sender, e);
        /// <summary>
        /// Событие, возникающее после очистки фильтров
        /// </summary>
        protected virtual void OnFiltersCleared(object sender, EventArgs e)
            => FiltersCleared(sender, e);


        // сделаю неогриниченное кол-во фильтров, пока пусть будет как есть
        // ок

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
        public void SetMinMax(int min, int max)
        {
            MinPrice = min;
            MaxPrice = max;
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
        /// <typeparam name="TFilter">Тип фильтра1</typeparam>
        /// <typeparam name="TKey">Ключ источника</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="filter">Ключ фильтра</param>
        /// <param name="price">Ключ цены</param>
        /// <returns>Отфильтрованный источник</returns>
        public IEnumerable<TSource> Filtering<TSource, TFilter, TKey>(IEnumerable<TSource> source, Func<TSource, TFilter> filter, Func<TSource, TKey> price)
        {
            // не забыть доработать допфильтры
            IEnumerable<TSource> result = FilterByPrice(source, price);
            if (Filters1.SelectedItem != null)
                result = Data.Filtering(result, filter, Filters1.SelectedItem.ToString());
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
        /// <typeparam name="TFilter1">Тип фильтра1</typeparam>
        /// <typeparam name="TFilter2">Тип фильтра2</typeparam>
        /// <typeparam name="TKey">Ключ источника</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="filter1">Ключ первого фильтра</param>
        /// <param name="filter2">Ключ второго фильтра</param>
        /// <param name="price">Ключ цены</param>
        /// <returns>Отфильтрованный источник</returns>
        public IEnumerable<TSource> Filtering<TSource, TFilter1, TFilter2, TKey>(IEnumerable<TSource> source, Func<TSource, TFilter1> filter1, Func<TSource, TFilter2> filter2, Func<TSource, TKey> price)
        {
            IEnumerable<TSource> result = Filtering(source, filter1, price);
            if (Filters2.SelectedItem != null)
                result = Data.Filtering(result, filter2, Filters2.SelectedItem.ToString());
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
        /// <typeparam name="TFilter1">Тип фильтра1</typeparam>
        /// <typeparam name="TFilter2">Тип фильтра2</typeparam>
        /// <typeparam name="TFilter3">Тип фильтра3</typeparam>
        /// <typeparam name="TKey">Ключ источника</typeparam>
        /// <param name="source">Источник</param>
        /// <param name="filter1">Ключ первого фильтра</param>
        /// <param name="filter2">Ключ второго фильтра</param>
        /// <param name="filter3">Ключ третьего фильтра</param>
        /// <param name="price">Ключ цены</param>
        /// <returns>Отфильтрованный источник</returns>
        public IEnumerable<TSource> Filtering<TSource, TFilter1, TFilter2, TFilter3, TKey>(IEnumerable<TSource> source, Func<TSource, TFilter1> filter1, Func<TSource, TFilter2> filter2, Func<TSource, TFilter3> filter3, Func<TSource, TKey> price)
        {
            IEnumerable<TSource> result = Filtering(source, filter1, filter2, price);
            if (Filters3.SelectedItem != null)
                result = Data.Filtering(result, filter3, Filters3.SelectedItem.ToString());
            return result;
        }

        private IEnumerable<TSource> FilterByPrice<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
        { 
            if (isCheckPrice)
                return Data.Filtering(source, selector, MinPrice, MaxPrice);
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
            label4.Size = new Size (MinPriceBox.Width + MaxPriceBox.Width + MaxPriceBox.Location.X - MinPriceBox.Location.X 
                                    - MinPriceBox.Width + 1, MaxPriceBox.Height);
            label4.Location = MinPriceBox.Location;
            resize();
        }
    }
}
