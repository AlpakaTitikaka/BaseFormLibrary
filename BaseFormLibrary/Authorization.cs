using BaseFormLibrary.Error;
using BusinessLib.Security.Error;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class Authorization : UserControl
    {
        public Form UserForm { get; set; }
        public Func<string, string, bool> LoginPasswordCheck;
        public int Incorrect { get; set; }
        private int incorrect { get; set; }
        public int CaptchaSimbolCount { get; set; }
        public Chars CaptchaSimbols { get; set; }

        public Color ButtonColor
        {
            get => Authorize.BackColor;
            set => Authorize.BackColor = value;
        }

        public FlatStyle ButtonFlatStyle
        {
            get => Authorize.FlatStyle;
            set => Authorize.FlatStyle = value;
        }

        public Authorization()
        {
            InitializeComponent();
            CaptchaSimbolCount = 3;
            CaptchaSimbols = Chars.Any;
            incorrect = 0;
            Incorrect = 2;
        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            if (LoginPasswordCheck.Invoke(Login.Text, Password.Text))
            {
                incorrect = 0;
                Login.Text = "";
                Password.Text = "";
                PasswordVisibility.Checked = false;
                ParentForm.Hide();
                UserForm.Show();
            }
            else
            {
                incorrect++;
                MessageBox.Show("Неверный логин или пароль");
                if (Incorrect == incorrect)
                    using (CheckUser check = new CheckUser(CaptchaSimbolCount, CaptchaSimbols))
                        if (check.ShowDialog(this) == DialogResult.OK)
                            check.Dispose();
            }
        }

        private void PasswordVisibility_CheckedChanged(object sender, EventArgs e)
            => Password.UseSystemPasswordChar = !PasswordVisibility.Checked;
    }
}
