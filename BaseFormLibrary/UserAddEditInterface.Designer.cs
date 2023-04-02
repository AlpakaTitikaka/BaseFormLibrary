namespace BaseFormLibrary
{
    partial class UserAddEditInterface
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.snils = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.polis = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fullName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.passport, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.phone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.address, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.email, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.snils, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.polis, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.birthday, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            this.label1.VisibleChanged += new System.EventHandler(this.label7_VisibleChanged);
            // 
            // id
            // 
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Location = new System.Drawing.Point(105, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(187, 20);
            this.id.TabIndex = 1;
            this.id.Tag = "";
            this.id.Visible = false;
            this.id.VisibleChanged += new System.EventHandler(this.id_VisibleChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullName
            // 
            this.fullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullName.Location = new System.Drawing.Point(105, 29);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(187, 20);
            this.fullName.TabIndex = 3;
            this.fullName.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Паспорт";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passport
            // 
            this.passport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passport.Location = new System.Drawing.Point(105, 55);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(187, 20);
            this.passport.TabIndex = 5;
            this.passport.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адрес";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone
            // 
            this.phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phone.Location = new System.Drawing.Point(105, 107);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(187, 20);
            this.phone.TabIndex = 9;
            this.phone.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Почта";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // address
            // 
            this.address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address.Location = new System.Drawing.Point(105, 159);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(187, 20);
            this.address.TabIndex = 11;
            this.address.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 182);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "СНИЛС";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Visible = false;
            this.label7.VisibleChanged += new System.EventHandler(this.label7_VisibleChanged);
            // 
            // email
            // 
            this.email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email.Location = new System.Drawing.Point(105, 133);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(187, 20);
            this.email.TabIndex = 13;
            this.email.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 208);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Полис";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Visible = false;
            this.label8.VisibleChanged += new System.EventHandler(this.label7_VisibleChanged);
            // 
            // snils
            // 
            this.snils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snils.Location = new System.Drawing.Point(105, 185);
            this.snils.Name = "snils";
            this.snils.Size = new System.Drawing.Size(187, 20);
            this.snils.TabIndex = 15;
            this.snils.Tag = "";
            this.snils.Visible = false;
            this.snils.VisibleChanged += new System.EventHandler(this.snils_VisibleChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 78);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(96, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Дата рождения";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // polis
            // 
            this.polis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polis.Location = new System.Drawing.Point(105, 211);
            this.polis.Name = "polis";
            this.polis.Size = new System.Drawing.Size(187, 20);
            this.polis.TabIndex = 17;
            this.polis.Visible = false;
            this.polis.VisibleChanged += new System.EventHandler(this.polis_VisibleChanged);
            // 
            // birthday
            // 
            this.birthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthday.Location = new System.Drawing.Point(105, 81);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(187, 20);
            this.birthday.TabIndex = 18;
            // 
            // UserAddEditInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserAddEditInterface";
            this.Size = new System.Drawing.Size(295, 236);
            this.Load += new System.EventHandler(this.UserAddEditInterface_Load);
            this.FontChanged += new System.EventHandler(this.UserAddEditInterface_FontChanged);
            this.SizeChanged += new System.EventHandler(this.UserAddEditInterface_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox snils;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox polis;
        private System.Windows.Forms.DateTimePicker birthday;
    }
}
