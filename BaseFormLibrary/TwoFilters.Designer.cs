namespace BaseFormLibrary
{
    partial class TwoFilters
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
            this.AllFilters1 = new System.Windows.Forms.ComboBox();
            this.Title1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxPriceString = new System.Windows.Forms.TextBox();
            this.MinPriceString = new System.Windows.Forms.TextBox();
            this.ClearFilters = new System.Windows.Forms.Button();
            this.Title3 = new System.Windows.Forms.Label();
            this.AllFilters2 = new System.Windows.Forms.ComboBox();
            this.Title2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AllFilters1
            // 
            this.AllFilters1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AllFilters1.FormattingEnabled = true;
            this.AllFilters1.Location = new System.Drawing.Point(11, 15);
            this.AllFilters1.Name = "AllFilters1";
            this.AllFilters1.Size = new System.Drawing.Size(177, 21);
            this.AllFilters1.TabIndex = 21;
            this.AllFilters1.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // Title1
            // 
            this.Title1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title1.AutoSize = true;
            this.Title1.Location = new System.Drawing.Point(2, 2);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(53, 13);
            this.Title1.TabIndex = 20;
            this.Title1.Text = "Фильтр1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "-";
            // 
            // MaxPriceString
            // 
            this.MaxPriceString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MaxPriceString.Location = new System.Drawing.Point(107, 107);
            this.MaxPriceString.Name = "MaxPriceString";
            this.MaxPriceString.Size = new System.Drawing.Size(80, 20);
            this.MaxPriceString.TabIndex = 18;
            this.MaxPriceString.TextChanged += new System.EventHandler(this.MinPriceString_TextChanged);
            // 
            // MinPriceString
            // 
            this.MinPriceString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MinPriceString.Location = new System.Drawing.Point(11, 107);
            this.MinPriceString.Name = "MinPriceString";
            this.MinPriceString.Size = new System.Drawing.Size(80, 20);
            this.MinPriceString.TabIndex = 17;
            this.MinPriceString.TextChanged += new System.EventHandler(this.MinPriceString_TextChanged);
            // 
            // ClearFilters
            // 
            this.ClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClearFilters.Location = new System.Drawing.Point(1, 133);
            this.ClearFilters.Name = "ClearFilters";
            this.ClearFilters.Size = new System.Drawing.Size(199, 25);
            this.ClearFilters.TabIndex = 15;
            this.ClearFilters.Text = "Очистить фильтры";
            this.ClearFilters.UseVisualStyleBackColor = true;
            this.ClearFilters.Click += new System.EventHandler(this.ClearFilters_Click);
            // 
            // Title3
            // 
            this.Title3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title3.AutoSize = true;
            this.Title3.Location = new System.Drawing.Point(2, 91);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(33, 13);
            this.Title3.TabIndex = 16;
            this.Title3.Text = "Цена";
            // 
            // AllFilters2
            // 
            this.AllFilters2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AllFilters2.FormattingEnabled = true;
            this.AllFilters2.Location = new System.Drawing.Point(11, 55);
            this.AllFilters2.Name = "AllFilters2";
            this.AllFilters2.Size = new System.Drawing.Size(177, 21);
            this.AllFilters2.TabIndex = 23;
            this.AllFilters2.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // Title2
            // 
            this.Title2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title2.AutoSize = true;
            this.Title2.Location = new System.Drawing.Point(2, 39);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(53, 13);
            this.Title2.TabIndex = 22;
            this.Title2.Text = "Фильтр1";
            // 
            // TwoFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllFilters2);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.AllFilters1);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxPriceString);
            this.Controls.Add(this.MinPriceString);
            this.Controls.Add(this.ClearFilters);
            this.Controls.Add(this.Title3);
            this.Name = "TwoFilters";
            this.Size = new System.Drawing.Size(200, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AllFilters1;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaxPriceString;
        private System.Windows.Forms.TextBox MinPriceString;
        private System.Windows.Forms.Button ClearFilters;
        private System.Windows.Forms.Label Title3;
        private System.Windows.Forms.ComboBox AllFilters2;
        private System.Windows.Forms.Label Title2;
    }
}
