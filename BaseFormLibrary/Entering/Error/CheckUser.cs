using System;
using System.Windows.Forms;

namespace BaseFormLibrary.Entering.Error
{
    /// <summary>
    /// Проверка пользователя с помощью каптчи
    /// </summary>
    public partial class CheckUser : Form
    {
        /// <summary>
        /// Проверка пользователя с помощью каптчи
        /// </summary>
        /// <param name="simbolCount">Количество символов в каптче</param>
        /// <param name="chars">Тип символов в каптче</param>
        public CheckUser(int simbolCount, Chars chars, int blockingTime)
        {
            InitializeComponent();
            SimbolCount = simbolCount;
            this.chars = chars; 
            BlockingTime = blockingTime + 1;
            CurrentBlockingTime = BlockingTime;
        }
        
        private int BlockingTime; //время блокировки формы при неверном вводе
        private int SimbolCount; //количество символов в капче
        private int CurrentBlockingTime; //время блокировки (счетчик)
        private Chars chars; // режим капчи (какие символы генерируются)
        private Captcha Picture; //капча

        private void GenerateCaptcha() //ее генерация и передача в пикчер бокс
        {
            Picture = new Captcha(Captcha.Width, Captcha.Height, SimbolCount, chars);
            Captcha.Image = Picture.Get();
        }

        private void CheckUser_Load(object sender, EventArgs e)
            => GenerateCaptcha();

        private void RefreshCaptcha_Click(object sender, EventArgs e)
            => GenerateCaptcha();

        private void CheckCaptcha_Click(object sender, EventArgs e) //проверка правильности введенного кода
        {
            if (Picture.Check(UserCode.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                Enabled = false;
                BlockingTimer.Enabled = true;
                BlockingTimer.Start();
            }
        }

        private void BlockingTimer_Tick(object sender, EventArgs e) //таймер
        {
            if (CurrentBlockingTime == 0)
            {
                Enabled = true;
                CurrentBlockingTime = BlockingTime;
                Text = "Проверка";
                GenerateCaptcha();
                BlockingTimer.Stop();
                BlockingTimer.Enabled = false;
            }
            else
            {
                CurrentBlockingTime--;
                Text = "Повторите попытку через " + CurrentBlockingTime;
            }
        }
    }
}
