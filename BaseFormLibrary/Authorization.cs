using BaseFormLibrary.Error;
using BusinessLib.Security.Error;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    // потрогать класс
    public partial class Authorization : UserControl
    {
        /// <summary>
        /// Форма, на которую осуществляется переход после удачной авторизации
        /// <example>
        /// <code>
        ///     authorization1.UserForm = new ManagerForm(this);
        /// </code>
        /// </example>
        /// </summary>
        public Form UserForm { get; set; }
        /// <summary>
        /// Функция проверки логина и пароля
        /// <example>
        /// <code>
        ///     authorization1.LoginPasswordCheck = Session.Login;
        /// </code>
        /// </example>
        /// </summary>
        public Func<string, string, bool> LoginPasswordCheck;
        /// <summary>
        /// Количество неверных попыток
        /// </summary>
        public int Incorrect { get; set; }
        private int nowIncorrectCount { get; set; }
        /// <summary>
        /// Количество символов в каптче
        /// </summary>
        public int CaptchaSimbolCount { get; set; }
        /// <summary>
        /// Какие символы могут быть в каптче
        /// </summary>
        public Chars CaptchaSimbols { get; set; }
        /// <summary>
        /// Цвет кнопки авторизации
        /// </summary>
        public Color ButtonColor
        {
            get => Authorize.BackColor;
            set => Authorize.BackColor = value;
        }
        /// <summary>
        /// Плоский стиль кнопки авторизации
        /// </summary>
        public FlatStyle ButtonFlatStyle
        {
            get => Authorize.FlatStyle;
            set => Authorize.FlatStyle = value;
        }
        /// <summary>
        /// Авторизация пользователя
        /// При неудачной попытке появляется каптча
        /// <para>ВНИМАНИЕ!!!</para>
        /// 1. Не работает, если не введены параметры следующей формы и проверки подлинности логина и пароля
        /// <para>
        /// 2. После авторизации форма на которой был контрол скрывается (Hide()), а новая форма открывается (Show())
        /// </para>
        /// Советую в UserForm передавать форму, на которой находится контрол (Например: new ManagerForm(this)), затем при закрытии UserForm открывать форму с контролом (AuthForm.Show())
        /// </summary>
        public Authorization()
        {
            InitializeComponent();
            CaptchaSimbolCount = 3;
            CaptchaSimbols = Chars.Any;
            nowIncorrectCount = 0;
            Incorrect = 2;
        }
        private void Authorize_Click(object sender, EventArgs e)
        {
            if (LoginPasswordCheck.Invoke(Login.Text, Password.Text))
            {
                nowIncorrectCount = 0;
                Login.Text = "";
                Password.Text = "";
                PasswordVisibility.Checked = false;
                ParentForm.Hide();
                UserForm.Show();
            }
            else
            {
                nowIncorrectCount++;
                MessageBox.Show("Неверный логин или пароль");
                if (Incorrect == nowIncorrectCount)
                    using (CheckUser check = new CheckUser(CaptchaSimbolCount, CaptchaSimbols))
                        if (check.ShowDialog(this) == DialogResult.OK)
                            check.Dispose();
            }
        }

        private void PasswordVisibility_CheckedChanged(object sender, EventArgs e)
            => Password.UseSystemPasswordChar = !PasswordVisibility.Checked;
    }
}
