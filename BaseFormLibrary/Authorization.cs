using BusinessLib.Security.Error;
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
    public partial class Authorization : UserControl
    {
        public Form UserForm;
        public Func<string, string, bool> LoginPasswordCheck;
        private int Incorrect = 0;

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            if (LoginPasswordCheck.Invoke(Login.Text, Password.Text))
            {
                Incorrect = 0;
                Login.Text = "";
                Password.Text = "";
                PasswordVisibility.Checked = false;
                ParentForm.Hide();
                UserForm.Show();
            }
            else
            {
                Incorrect++;
                MessageBox.Show("Неверный логин или пароль");
                if (Incorrect > 1)
                    using (CheckUser check = new CheckUser())
                        if (check.ShowDialog(this) == DialogResult.OK)
                            check.Dispose();
            }
        }

        private void PasswordVisibility_CheckedChanged(object sender, EventArgs e)
            => Password.UseSystemPasswordChar = !PasswordVisibility.Checked;

        private void Authorization_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
                Controls[i].Location = new Point((Width - Controls[i].Width) / 2, Controls[i].Location.Y);
        }
    }
}
