using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class NumberBox : TextBox
    {

        private int numbers = -1;

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
        public override string Text 
        { 
            get => base.Text; 
            set => Numbers = int.Parse(value);
        }

        public NumberBox() : base()
        {

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = !(char.IsDigit(e.KeyChar) || (Convert.ToInt32(e.KeyChar) == 8));
        }
    }
}
