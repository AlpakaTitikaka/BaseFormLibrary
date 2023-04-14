using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public delegate void SearchTextChangedHandler(object sender, EventArgs e);

    public partial class SearchString : UserControl
    {
        public event SearchTextChangedHandler SearchTextChanged;
        public bool IsClear { get => SearchText.Text == ""; }

        public SearchString()
        {
            InitializeComponent();
        }

        public virtual void OnSearchTextChanged(EventArgs e)
            => SearchTextChanged(this, e);

        public IEnumerable<TSource> Search<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
            => LibraryMethods.Find(source, selector, SearchText.Text);

        private void SearchText_TextChanged(object sender, EventArgs e)
            => OnSearchTextChanged(e);

        private void CenterControls()
        {
            label1.Location = new System.Drawing.Point(label1.Location.X, (Height - label1.Height) / 2);
            SearchText.Location = new System.Drawing.Point(SearchText.Location.X, (Height - SearchText.Height) / 2);
        }

        private void SearchString_FontChanged(object sender, EventArgs e)
        {
            label1.Font = Font;
            SearchText.Font = Font;
            CenterControls();
        }

        private void SearchString_SizeChanged(object sender, EventArgs e) => CenterControls();
    }
}
