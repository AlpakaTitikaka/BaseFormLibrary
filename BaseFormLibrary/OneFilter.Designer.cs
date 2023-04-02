namespace BaseFormLibrary
{
    partial class OneFilter
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
            this.label4 = new System.Windows.Forms.Label();
            this.MaxPriceString = new System.Windows.Forms.TextBox();
            this.MinPriceString = new System.Windows.Forms.TextBox();
            this.Title2 = new System.Windows.Forms.Label();
            this.ClearFilters = new System.Windows.Forms.Button();
            this.Title1 = new System.Windows.Forms.Label();
            this.AllFilters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            // 
            // MaxPriceString
            // 
            this.MaxPriceString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MaxPriceString.Location = new System.Drawing.Point(108, 63);
            this.MaxPriceString.Margin = new System.Windows.Forms.Padding(2);
            this.MaxPriceString.Name = "MaxPriceString";
            this.MaxPriceString.Size = new System.Drawing.Size(80, 20);
            this.MaxPriceString.TabIndex = 11;
            this.MaxPriceString.TextChanged += new System.EventHandler(this.MinPriceString_TextChanged);
            // 
            // MinPriceString
            // 
            this.MinPriceString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MinPriceString.Location = new System.Drawing.Point(10, 63);
            this.MinPriceString.Margin = new System.Windows.Forms.Padding(2);
            this.MinPriceString.Name = "MinPriceString";
            this.MinPriceString.Size = new System.Drawing.Size(80, 20);
            this.MinPriceString.TabIndex = 10;
            this.MinPriceString.TextChanged += new System.EventHandler(this.MinPriceString_TextChanged);
            // 
            // Title2
            // 
            this.Title2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title2.AutoSize = true;
            this.Title2.Location = new System.Drawing.Point(3, 47);
            this.Title2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(33, 13);
            this.Title2.TabIndex = 9;
            this.Title2.Text = "Цена";
            // 
            // ClearFilters
            // 
            this.ClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClearFilters.Location = new System.Drawing.Point(0, 112);
            this.ClearFilters.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFilters.Name = "ClearFilters";
            this.ClearFilters.Size = new System.Drawing.Size(199, 25);
            this.ClearFilters.TabIndex = 4;
            this.ClearFilters.Text = "Очистить фильтры";
            this.ClearFilters.UseVisualStyleBackColor = true;
            this.ClearFilters.Click += new System.EventHandler(this.ClearFilters_Click);
            // 
            // Title1
            // 
            this.Title1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title1.AutoSize = true;
            this.Title1.Location = new System.Drawing.Point(2, 0);
            this.Title1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(47, 13);
            this.Title1.TabIndex = 13;
            this.Title1.Text = "Фильтр";
            // 
            // AllFilters
            // 
            this.AllFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AllFilters.FormattingEnabled = true;
            this.AllFilters.Location = new System.Drawing.Point(11, 15);
            this.AllFilters.Margin = new System.Windows.Forms.Padding(2);
            this.AllFilters.Name = "AllFilters";
            this.AllFilters.Size = new System.Drawing.Size(177, 21);
            this.AllFilters.TabIndex = 14;
            this.AllFilters.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // OneFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllFilters);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxPriceString);
            this.Controls.Add(this.MinPriceString);
            this.Controls.Add(this.ClearFilters);
            this.Controls.Add(this.Title2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "OneFilter";
            this.Size = new System.Drawing.Size(200, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Button ClearFilters;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.ComboBox AllFilters;
        private System.Windows.Forms.TextBox MaxPriceString;
        private System.Windows.Forms.TextBox MinPriceString;
    }
}
