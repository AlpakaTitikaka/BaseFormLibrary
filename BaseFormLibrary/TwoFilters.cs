using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public delegate void TwoFilterEventHandler(object sender, EventArgs e);

    public partial class TwoFilters : UserControl
    {
        public TwoFilters()
        {
            InitializeComponent();
        }

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
        public string Text3
        {
            get => Title3.Text;
            set => Title3.Text = value;
        }

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

        private string Min { get; set; }
        private string Max { get; set; }

        private object SelectedFilter1
        {
            get => AllFilters1.SelectedIndex != -1 ? AllFilters1.SelectedItem : null;
        }
        private object SelectedFilter2
        {
            get => AllFilters2.SelectedIndex != -1 ? AllFilters2.SelectedItem : null;
        }

        public event TwoFilterEventHandler Changed;
        public event TwoFilterEventHandler FiltersCleared;

        protected virtual void OnChanged(object sender, EventArgs e)
            => Changed(sender, e);

        protected virtual void OnFiltersCleared(object sender, EventArgs e)
            => FiltersCleared(sender, e);

        private void ClearFilters_Click(object sender, EventArgs e)
        {
            MinPrice = Min;
            MaxPrice = Max;
            AllFilters1.SelectedIndex = -1;
            AllFilters2.SelectedIndex = -1;
            OnFiltersCleared(sender, e);
        }

        public void AddFilters(object[] filters1, object[] filters2)
        {
            AllFilters1.Items.AddRange(filters1);
            AllFilters2.Items.AddRange(filters2);
        }

        public void SetMinMax(string min, string max)
        {
            Min = min;
            Max = max;
            MinPrice = min;
            MaxPrice = max;
        }

        public IEnumerable<TSource> Filter<TSource, TKey>(IEnumerable<TSource> source, 
            Func<TSource, TKey> filter1, Func<TSource, TKey> filter2, Func<TSource, TKey> price)
        {
            if (SelectedFilter1 != null && SelectedFilter2 == null)
                return LibraryMethods.Filtering(FilterByPrice(source, price), filter1, (string)SelectedFilter1);
            if (SelectedFilter1 == null && SelectedFilter2 != null)
                return LibraryMethods.Filtering(FilterByPrice(source, price), filter2, (string)SelectedFilter2);
            if (SelectedFilter1 == null && SelectedFilter2 == null)
                return LibraryMethods.Filtering(LibraryMethods.Filtering
                    (FilterByPrice(source, price), filter1, (string)SelectedFilter1), filter2, (string)SelectedFilter2);
            return FilterByPrice(source, price);
        }

        private IEnumerable<TSource> FilterByPrice<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
            => LibraryMethods.Filtering(source, selector, MinPrice, MaxPrice);

        private void Filters_SelectedIndexChanged(object sender, EventArgs e)
            => OnChanged(sender, e);

        private void MinPriceString_TextChanged(object sender, EventArgs e)
            => OnChanged(sender, e);
    }
}
