using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public delegate void OneFilterEventHandler(object sender, EventArgs e);

    public partial class OneFilter : UserControl
    {
        public OneFilter()
        {
            InitializeComponent();
        }

        public event OneFilterEventHandler Changed;
        public event OneFilterEventHandler FiltersCleared;

        public string Text1 
        { 
            get => Title1.Text; 
            set => Title1.Text = value; 
        }
        public string Text2 
        { 
            get => Title2.Text; 
            set => Title2.Text = value; 
        }

        private string Min { get; set; }
        private string Max { get; set; }

        public string MinPrice 
        {
            get => MinPriceString.Text;
            set => MinPriceString.Text = value;
        }
        public string MaxPrice 
        {
            get => MaxPriceString.Text;
            set => MaxPriceString.Text = value;
        }

        private object SelectedFilter { get => AllFilters.SelectedIndex != -1 ? AllFilters.SelectedItem : null; }

        private void ClearFilters_Click(object sender, EventArgs e)
        {
            MinPrice = Min;
            MaxPrice = Max;
            AllFilters.SelectedIndex = -1;
            OnFiltersCleared(sender, e);
        }

        protected virtual void OnChanged(object sender, EventArgs e)
            => Changed(sender, e);

        protected virtual void OnFiltersCleared(object sender, EventArgs e)
            => FiltersCleared(sender, e);

        public void AddFilters(object[] filters)
            => AllFilters.Items.AddRange(filters);

        public void SetMinMax(string min, string max)
        {
            Min = min;
            Max = max;
            MinPrice = Min;
            MaxPrice = Max;
        }

        public IEnumerable<TSource> Filter<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> filter, Func<TSource, TKey> price)
        { 
            if (SelectedFilter != null)
                return LibraryMethods.Filtering(FilterByPrice(source, price), filter, (string)SelectedFilter);
            return FilterByPrice(source, price);
        }

        private IEnumerable<TSource> FilterByPrice<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
            => LibraryMethods.Filtering(source, selector, MinPrice, MaxPrice);

        private void Filters_SelectedIndexChanged(object sender, EventArgs e)
            => Changed(sender, e);

        private void MinPriceString_TextChanged(object sender, EventArgs e)
            => Changed(sender, e);
    }
}
