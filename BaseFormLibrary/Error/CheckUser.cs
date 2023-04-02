﻿using System;
using System.Windows.Forms;

namespace BusinessLib.Security.Error
{
    public partial class CheckUser : Form
    {
        public CheckUser()
        {
            InitializeComponent();
        }
        
        private int BlockingTime = 11; //время блокировки формы при неверном вводе
        private int SimbolCount = 4; //количество символов в капче
        private Captcha Picture; //капча

        private void GenerateCaptcha() //ее генерация и передача в пикчер бокс
        {
            Picture = new Captcha(Captcha.Width, Captcha.Height, SimbolCount);
            Captcha.Image = Picture.Get();
        }

        private void CheckUser_Load(object sender, EventArgs e)
            => GenerateCaptcha();

        private void RefreshCaptcha_Click(object sender, EventArgs e)
            => GenerateCaptcha();

        private void CheckCaptcha_Click(object sender, EventArgs e) //проверка правильности введенного кода
        {
            if (Picture.Check(UserCode.Text))
                DialogResult = DialogResult.OK;
            else
            {
                Enabled = false;
                BlockingTimer.Enabled = true;
                BlockingTimer.Start();
            }
        }

        private void BlockingTimer_Tick(object sender, EventArgs e) //таймер
        {
            if (BlockingTime == 0)
            {
                Enabled = true;
                BlockingTime = 11;
                Text = "Проверка";
                GenerateCaptcha();
                BlockingTimer.Stop();
                BlockingTimer.Enabled = false;
            }
            else
            {
                BlockingTime--;
                Text = "Повторите попытку через " + BlockingTime;
            }
        }
    }
}