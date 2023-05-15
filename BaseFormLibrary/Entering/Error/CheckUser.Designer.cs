namespace BaseFormLibrary.Entering.Error
{
    partial class CheckUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Captcha = new System.Windows.Forms.PictureBox();
            this.RefreshCaptcha = new System.Windows.Forms.Button();
            this.CheckCaptcha = new System.Windows.Forms.Button();
            this.UserCode = new System.Windows.Forms.TextBox();
            this.BlockingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // Captcha
            // 
            this.Captcha.Location = new System.Drawing.Point(12, 12);
            this.Captcha.Name = "Captcha";
            this.Captcha.Size = new System.Drawing.Size(196, 101);
            this.Captcha.TabIndex = 0;
            this.Captcha.TabStop = false;
            // 
            // RefreshCaptcha
            // 
            this.RefreshCaptcha.Location = new System.Drawing.Point(12, 119);
            this.RefreshCaptcha.Name = "RefreshCaptcha";
            this.RefreshCaptcha.Size = new System.Drawing.Size(196, 29);
            this.RefreshCaptcha.TabIndex = 1;
            this.RefreshCaptcha.Text = "Обновить";
            this.RefreshCaptcha.UseVisualStyleBackColor = true;
            this.RefreshCaptcha.Click += new System.EventHandler(this.RefreshCaptcha_Click);
            // 
            // CheckCaptcha
            // 
            this.CheckCaptcha.Location = new System.Drawing.Point(12, 183);
            this.CheckCaptcha.Name = "CheckCaptcha";
            this.CheckCaptcha.Size = new System.Drawing.Size(196, 29);
            this.CheckCaptcha.TabIndex = 2;
            this.CheckCaptcha.Text = "Ввести";
            this.CheckCaptcha.UseVisualStyleBackColor = true;
            this.CheckCaptcha.Click += new System.EventHandler(this.CheckCaptcha_Click);
            // 
            // UserCode
            // 
            this.UserCode.Location = new System.Drawing.Point(12, 154);
            this.UserCode.Name = "UserCode";
            this.UserCode.Size = new System.Drawing.Size(196, 23);
            this.UserCode.TabIndex = 3;
            // 
            // BlockingTimer
            // 
            this.BlockingTimer.Interval = 1000;
            this.BlockingTimer.Tick += new System.EventHandler(this.BlockingTimer_Tick);
            // 
            // CheckUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 224);
            this.ControlBox = false;
            this.Controls.Add(this.UserCode);
            this.Controls.Add(this.CheckCaptcha);
            this.Controls.Add(this.RefreshCaptcha);
            this.Controls.Add(this.Captcha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckUser";
            this.Text = "Проверка";
            this.Load += new System.EventHandler(this.CheckUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Captcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Captcha;
        private System.Windows.Forms.Button RefreshCaptcha;
        private System.Windows.Forms.Button CheckCaptcha;
        private System.Windows.Forms.TextBox UserCode;
        private System.Windows.Forms.Timer BlockingTimer;
    }
}