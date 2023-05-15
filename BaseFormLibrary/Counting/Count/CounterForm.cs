using System.Drawing;
using System.Windows.Forms;

namespace BaseFormLibrary.Counting.Count
{
    /// <summary>
    /// Форма для счетчика
    /// </summary>
    public partial class CounterForm : Form
    {
        /// <summary>
        /// Форма для счетчика
        /// </summary>
        public CounterForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Заголовок формы
        /// </summary>
        public string Title
        {
            get => Text; 
            set => Text = value;
        }
        /// <summary>
        /// Текст кнопки установления значения
        /// </summary>
        public string SetButtonTitle
        {
            get => SetCount.Text; 
            set => SetCount.Text = value;
        }
        /// <summary>
        /// Цвет кнопки установления значения
        /// </summary>
        public Color SetCountColor
        {
            get => SetCount.BackColor; 
            set => SetCount.BackColor = value;
        }
        /// <summary>
        /// Цвет кнопки отмены
        /// </summary>
        public Color CancelCounterColor
        {
            get => CancelCounter.BackColor;
            set => CancelCounter.BackColor = value;
        }
        /// <summary>
        /// Значение в настоящий момент
        /// </summary>
        public int Value
        {
            get => (int)CountNumber.Value;
            set => CountNumber.Value = value;
        }
        /// <summary>
        /// Максимальное значение счетчика
        /// </summary>
        public int MaxValue 
        { 
            get => (int)CountNumber.Maximum; 
            set => CountNumber.Maximum = value; 
        }

    }
}
