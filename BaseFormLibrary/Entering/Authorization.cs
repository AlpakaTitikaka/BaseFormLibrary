using BaseFormLibrary.Entering.Error;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseFormLibrary.Entering
{
    /// <summary>
    /// Создание авторизации пользователей
    /// </summary>
    public partial class Authorization : UserControl
    {
        /// <summary>
        /// Функция выбора формы для переключения
        /// <example>
        /// <code>
        ///     authorization1.SelectForm = SelectUserForm;
        /// </code>
        /// </example>
        /// SelectUserForm может иметь такой вид метода
        /// <example>
        /// <code>
        ///     Form SelectUserForm ()
        ///     {
        ///         if (Session.User.Rang == 1)
        ///             return new Form1;
        ///         if (Session.User.Rang == 2)
        ///             return new Form2;
        ///         return new Form3;
        ///     }
        /// </code>
        /// </example>
        /// Если только одна форма, то
        /// <example>
        /// <code>
        ///     Form SelectUserForm ()
        ///     {
        ///         return new Form1;
        ///     }
        /// </code>
        /// </example>
        /// </summary>
        public Func<Form> SelectForm { get; set; }
        /// <summary>
        /// Функция проверки логина и пароля
        /// <example>
        /// <code>
        ///     authorization1.LoginPasswordCheck = Session.Start;
        /// </code>
        /// </example>
        /// </summary>
        public Func<string, string, bool> LoginPasswordCheck;
        /// <summary>
        /// Количество неверных попыток
        /// </summary>
        public int Incorrect { get; set; }
        /// <summary>
        /// Время блокировки каптчи при неверном вводе данных
        /// </summary>
        public int CaptchaBlockingTime { get; set; }
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
        /// Создание авторизации пользователей
        /// </summary>
        public Authorization()
        {
            InitializeComponent();
            CaptchaSimbolCount = 3;
            CaptchaBlockingTime = 10;
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
                SelectForm.Invoke().Show();
            }
            else
            {
                nowIncorrectCount++;
                MessageBox.Show("Неверный логин или пароль");
                if (Incorrect == nowIncorrectCount)
                    using (CheckUser check = new CheckUser
                        (CaptchaSimbolCount
                        , CaptchaSimbols
                        , CaptchaBlockingTime))
                        if (check.ShowDialog(this) == DialogResult.OK)
                        { 
                            check.Dispose();
                            nowIncorrectCount = 0;
                        }
            }
        }

        private void PasswordVisibility_CheckedChanged(object sender, EventArgs e)
            => Password.UseSystemPasswordChar = !PasswordVisibility.Checked;
    }
}
