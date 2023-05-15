using System;
using System.Windows.Forms;

namespace BaseFormLibrary.Number
{
    /// <summary>
    /// Элемент, в котором можно писать только цифры
    /// </summary>
    public partial class NumberBox: UserControl
    {
        /// <summary>
        /// Элемент, в котором можно писать только цифры
        /// </summary>
        public NumberBox()
        {
            InitializeComponent();
        }

        private int numbers = -1;
        /// <summary>
        /// Число, хранящееся в элементе
        /// </summary>
        public int Numbers
        {
            get
            {
                return numbers;
            }
            set
            {
                numbers = value;
                if (value == -1)
                {
                    base.Text = "";
                    return;
                }
                base.Text = value.ToString();
            }
        }
        /// <summary>
        /// Установление числа в элемент
        /// </summary>
        public override string Text
        {
            get => NumberText.Text;
            set => Numbers = int.Parse(value);
        }
        /// <summary>
        /// Режим только чтение
        /// </summary>
        public bool ReadOnly
        {
            get => NumberText.ReadOnly;
            set => NumberText.ReadOnly = value;
        }

        private void NumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (Convert.ToInt32(e.KeyChar) == 8));
        }
    }
}
