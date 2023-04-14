namespace BaseFormLibrary
{
    partial class Filter
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
            this.Filters1 = new System.Windows.Forms.ComboBox();
            this.PricePanel = new System.Windows.Forms.Panel();
            this.FiltersOnPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FilterPanel3 = new System.Windows.Forms.Panel();
            this.Filters3 = new System.Windows.Forms.ComboBox();
            this.Title4 = new System.Windows.Forms.Label();
            this.FilterPanel1 = new System.Windows.Forms.Panel();
            this.FilterPanel2 = new System.Windows.Forms.Panel();
            this.Filters2 = new System.Windows.Forms.ComboBox();
            this.Title3 = new System.Windows.Forms.Label();
            this.PricePanel.SuspendLayout();
            this.FiltersOnPanel.SuspendLayout();
            this.FilterPanel3.SuspendLayout();
            this.FilterPanel1.SuspendLayout();
            this.FilterPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxPriceString
            // 
            this.MaxPriceString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxPriceString.Location = new System.Drawing.Point(115, 19);
            this.MaxPriceString.Margin = new System.Windows.Forms.Padding(2);
            this.MaxPriceString.Name = "MaxPriceString";
            this.MaxPriceString.Size = new System.Drawing.Size(80, 20);
            this.MaxPriceString.TabIndex = 11;
            this.MaxPriceString.TextChanged += new System.EventHandler(this.MinPriceString_TextChanged);
            // 
            // MinPriceString
            // 
            this.MinPriceString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MinPriceString.Location = new System.Drawing.Point(4, 19);
            this.MinPriceString.Margin = new System.Windows.Forms.Padding(2);
            this.MinPriceString.Name = "MinPriceString";
            this.MinPriceString.Size = new System.Drawing.Size(80, 20);
            this.MinPriceString.TabIndex = 10;
            this.MinPriceString.TextChanged += new System.EventHandler(this.MinPriceString_TextChanged);
            // 
            // Title2
            // 
            this.Title2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Title2.AutoSize = true;
            this.Title2.Location = new System.Drawing.Point(1, 3);
            this.Title2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(33, 13);
            this.Title2.TabIndex = 9;
            this.Title2.Text = "Цена";
            // 
            // ClearFilters
            // 
            this.ClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearFilters.Location = new System.Drawing.Point(2, 201);
            this.ClearFilters.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFilters.Name = "ClearFilters";
            this.ClearFilters.Size = new System.Drawing.Size(199, 30);
            this.ClearFilters.TabIndex = 4;
            this.ClearFilters.Text = "Очистить фильтры";
            this.ClearFilters.UseVisualStyleBackColor = true;
            this.ClearFilters.Click += new System.EventHandler(this.ClearFilters_Click);
            // 
            // Title1
            // 
            this.Title1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Title1.AutoSize = true;
            this.Title1.Location = new System.Drawing.Point(1, 3);
            this.Title1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(47, 13);
            this.Title1.TabIndex = 13;
            this.Title1.Text = "Фильтр";
            // 
            // Filters1
            // 
            this.Filters1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Filters1.FormattingEnabled = true;
            this.Filters1.Location = new System.Drawing.Point(4, 19);
            this.Filters1.Margin = new System.Windows.Forms.Padding(2);
            this.Filters1.Name = "Filters1";
            this.Filters1.Size = new System.Drawing.Size(190, 21);
            this.Filters1.TabIndex = 14;
            this.Filters1.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // PricePanel
            // 
            this.PricePanel.AutoSize = true;
            this.PricePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PricePanel.Controls.Add(this.MinPriceString);
            this.PricePanel.Controls.Add(this.MaxPriceString);
            this.PricePanel.Controls.Add(this.Title2);
            this.PricePanel.Controls.Add(this.label4);
            this.PricePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PricePanel.Location = new System.Drawing.Point(3, 150);
            this.PricePanel.Name = "PricePanel";
            this.PricePanel.Size = new System.Drawing.Size(197, 46);
            this.PricePanel.TabIndex = 15;
            this.PricePanel.VisibleChanged += new System.EventHandler(this.PricePanel_VisibleChanged);
            // 
            // FiltersOnPanel
            // 
            this.FiltersOnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersOnPanel.AutoSize = true;
            this.FiltersOnPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FiltersOnPanel.ColumnCount = 1;
            this.FiltersOnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FiltersOnPanel.Controls.Add(this.FilterPanel3, 0, 2);
            this.FiltersOnPanel.Controls.Add(this.FilterPanel1, 0, 0);
            this.FiltersOnPanel.Controls.Add(this.ClearFilters, 0, 4);
            this.FiltersOnPanel.Controls.Add(this.PricePanel, 0, 3);
            this.FiltersOnPanel.Controls.Add(this.FilterPanel2, 0, 1);
            this.FiltersOnPanel.Location = new System.Drawing.Point(0, 0);
            this.FiltersOnPanel.Name = "FiltersOnPanel";
            this.FiltersOnPanel.RowCount = 5;
            this.FiltersOnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FiltersOnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FiltersOnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FiltersOnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FiltersOnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FiltersOnPanel.Size = new System.Drawing.Size(203, 233);
            this.FiltersOnPanel.TabIndex = 16;
            // 
            // FilterPanel3
            // 
            this.FilterPanel3.AutoSize = true;
            this.FilterPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterPanel3.Controls.Add(this.Filters3);
            this.FilterPanel3.Controls.Add(this.Title4);
            this.FilterPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterPanel3.Location = new System.Drawing.Point(3, 99);
            this.FilterPanel3.Name = "FilterPanel3";
            this.FilterPanel3.Size = new System.Drawing.Size(197, 45);
            this.FilterPanel3.TabIndex = 15;
            this.FilterPanel3.Tag = "1";
            // 
            // Filters3
            // 
            this.Filters3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Filters3.FormattingEnabled = true;
            this.Filters3.Location = new System.Drawing.Point(4, 19);
            this.Filters3.Margin = new System.Windows.Forms.Padding(2);
            this.Filters3.Name = "Filters3";
            this.Filters3.Size = new System.Drawing.Size(190, 21);
            this.Filters3.TabIndex = 14;
            this.Filters3.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // Title4
            // 
            this.Title4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Title4.AutoSize = true;
            this.Title4.Location = new System.Drawing.Point(1, 3);
            this.Title4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title4.Name = "Title4";
            this.Title4.Size = new System.Drawing.Size(47, 13);
            this.Title4.TabIndex = 13;
            this.Title4.Text = "Фильтр";
            // 
            // FilterPanel1
            // 
            this.FilterPanel1.AutoSize = true;
            this.FilterPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterPanel1.Controls.Add(this.Filters1);
            this.FilterPanel1.Controls.Add(this.Title1);
            this.FilterPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterPanel1.Location = new System.Drawing.Point(3, 3);
            this.FilterPanel1.Name = "FilterPanel1";
            this.FilterPanel1.Size = new System.Drawing.Size(197, 45);
            this.FilterPanel1.TabIndex = 0;
            this.FilterPanel1.Tag = "1";
            // 
            // FilterPanel2
            // 
            this.FilterPanel2.AutoSize = true;
            this.FilterPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterPanel2.Controls.Add(this.Filters2);
            this.FilterPanel2.Controls.Add(this.Title3);
            this.FilterPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterPanel2.Location = new System.Drawing.Point(3, 54);
            this.FilterPanel2.Name = "FilterPanel2";
            this.FilterPanel2.Size = new System.Drawing.Size(197, 39);
            this.FilterPanel2.TabIndex = 15;
            this.FilterPanel2.Tag = "1";
            // 
            // Filters2
            // 
            this.Filters2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Filters2.FormattingEnabled = true;
            this.Filters2.Location = new System.Drawing.Point(4, 16);
            this.Filters2.Margin = new System.Windows.Forms.Padding(2);
            this.Filters2.Name = "Filters2";
            this.Filters2.Size = new System.Drawing.Size(190, 21);
            this.Filters2.TabIndex = 14;
            this.Filters2.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // Title3
            // 
            this.Title3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Title3.AutoSize = true;
            this.Title3.Location = new System.Drawing.Point(1, 3);
            this.Title3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(47, 13);
            this.Title3.TabIndex = 13;
            this.Title3.Text = "Фильтр";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.FiltersOnPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(206, 236);
            this.FontChanged += new System.EventHandler(this.Filter_FontChanged);
            this.PricePanel.ResumeLayout(false);
            this.PricePanel.PerformLayout();
            this.FiltersOnPanel.ResumeLayout(false);
            this.FiltersOnPanel.PerformLayout();
            this.FilterPanel3.ResumeLayout(false);
            this.FilterPanel3.PerformLayout();
            this.FilterPanel1.ResumeLayout(false);
            this.FilterPanel1.PerformLayout();
            this.FilterPanel2.ResumeLayout(false);
            this.FilterPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Button ClearFilters;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.ComboBox Filters1;
        private System.Windows.Forms.TextBox MaxPriceString;
        private System.Windows.Forms.TextBox MinPriceString;
        private System.Windows.Forms.Panel PricePanel;
        private System.Windows.Forms.TableLayoutPanel FiltersOnPanel;
        private System.Windows.Forms.Panel FilterPanel1;
        private System.Windows.Forms.ComboBox Filters3;
        private System.Windows.Forms.Label Title4;
        private System.Windows.Forms.Panel FilterPanel2;
        private System.Windows.Forms.ComboBox Filters2;
        private System.Windows.Forms.Label Title3;
        private System.Windows.Forms.Panel FilterPanel3;
    }
}
