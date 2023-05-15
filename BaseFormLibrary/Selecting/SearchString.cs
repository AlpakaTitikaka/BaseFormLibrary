using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseFormLibrary.Selecting
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void SearchTextChangedHandler(object sender, EventArgs e);

    /// <summary>
    /// Поисковая строка
    /// </summary>
    public partial class SearchString : UserControl
    {
        /// <summary>
        /// Происходит после того, как изменился текст в поисковой строке
        /// </summary>
        public event SearchTextChangedHandler SearchTextChanged;
        /// <summary>
        /// true, если строка пустая, false, если в ней что-то есть
        /// </summary>
        public bool IsClear 
        {
            get => SearchText.Text == ""; 
        }

        /// <summary>
        /// Поисковая строка
        /// </summary>
        public SearchString()
        {
            InitializeComponent();
        }

        protected virtual void OnSearchTextChanged(EventArgs e)
            => SearchTextChanged(this, e);
        /// <summary>
        /// Осуществляет поиск из источника, находит то, что содержит в себе поисковый запрос
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <returns>Найденные варианты</returns>
        public IEnumerable<TSource> Search<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> selector)
            => Data.Find(source, selector, SearchText.Text);

        private void SearchText_TextChanged(object sender, EventArgs e)
            => OnSearchTextChanged(e);

        private void CenterControls()
        {
            label1.Location = new System.Drawing.Point(label1.Location.X, (Height - label1.Height) / 2);
            SearchText.Location = new System.Drawing.Point(SearchText.Location.X, (Height - SearchText.Height) / 2);
        }

        private void ResizeControls()
        {

        }

        private void SearchString_FontChanged(object sender, EventArgs e)
        {
            ResizeControls();
            CenterControls();
        }

        private void SearchString_SizeChanged(object sender, EventArgs e) => CenterControls();
    }
}
