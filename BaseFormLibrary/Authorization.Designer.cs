namespace BaseFormLibrary
{
    partial class Authorization
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.PasswordVisibility = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Authorize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Location = new System.Drawing.Point(0, 76);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(225, 20);
            this.Password.TabIndex = 23;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.Location = new System.Drawing.Point(0, 22);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(225, 20);
            this.Login.TabIndex = 22;
            // 
            // PasswordVisibility
            // 
            this.PasswordVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordVisibility.AutoSize = true;
            this.PasswordVisibility.Location = new System.Drawing.Point(61, 107);
            this.PasswordVisibility.Name = "PasswordVisibility";
            this.PasswordVisibility.Size = new System.Drawing.Size(114, 17);
            this.PasswordVisibility.TabIndex = 21;
            this.PasswordVisibility.Text = "Показать пароль";
            this.PasswordVisibility.UseVisualStyleBackColor = true;
            this.PasswordVisibility.CheckedChanged += new System.EventHandler(this.PasswordVisibility_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пароль";
            // 
            // Authorize
            // 
            this.Authorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Authorize.Location = new System.Drawing.Point(36, 141);
            this.Authorize.Name = "Authorize";
            this.Authorize.Size = new System.Drawing.Size(159, 28);
            this.Authorize.TabIndex = 19;
            this.Authorize.Text = "Вход";
            this.Authorize.UseVisualStyleBackColor = true;
            this.Authorize.Click += new System.EventHandler(this.Authorize_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Логин";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordVisibility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Authorize);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Size = new System.Drawing.Size(225, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.CheckBox PasswordVisibility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Authorize;
        private System.Windows.Forms.Label label1;
    }
}
