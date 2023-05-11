using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class NumberBox: UserControl
    {
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

        private void NumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (Convert.ToInt32(e.KeyChar) == 8));
        }
    }
}
