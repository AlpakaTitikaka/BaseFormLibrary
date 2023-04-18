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
        public NumberBox() : base()
        {
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (char.IsDigit(e.KeyChar) || (Convert.ToInt32(e.KeyChar) == 8))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }


        public int Numbers
        {
            get
            {
                return int.Parse(base.Text);
            }
            set
            {
                base.Text = value.ToString();

            }
        }
    }
}
