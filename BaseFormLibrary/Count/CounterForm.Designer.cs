namespace BaseFormLibrary.Count
{
    partial class CounterForm
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
            this.CountNumber = new System.Windows.Forms.NumericUpDown();
            this.CancelCounter = new System.Windows.Forms.Button();
            this.SetCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // CountNumber
            // 
            this.CountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CountNumber.Location = new System.Drawing.Point(12, 12);
            this.CountNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountNumber.Name = "CountNumber";
            this.CountNumber.Size = new System.Drawing.Size(120, 20);
            this.CountNumber.TabIndex = 8;
            this.CountNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CancelCounter
            // 
            this.CancelCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelCounter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCounter.Location = new System.Drawing.Point(12, 70);
            this.CancelCounter.Name = "CancelCounter";
            this.CancelCounter.Size = new System.Drawing.Size(120, 23);
            this.CancelCounter.TabIndex = 7;
            this.CancelCounter.Text = "Отмена";
            this.CancelCounter.UseVisualStyleBackColor = true;
            // 
            // SetCount
            // 
            this.SetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SetCount.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SetCount.Location = new System.Drawing.Point(12, 41);
            this.SetCount.Name = "SetCount";
            this.SetCount.Size = new System.Drawing.Size(120, 23);
            this.SetCount.TabIndex = 6;
            this.SetCount.Text = "Установить";
            this.SetCount.UseVisualStyleBackColor = true;
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 100);
            this.ControlBox = false;
            this.Controls.Add(this.CountNumber);
            this.Controls.Add(this.CancelCounter);
            this.Controls.Add(this.SetCount);
            this.Name = "Counter";
            this.Text = "Количество";
            ((System.ComponentModel.ISupportInitialize)(this.CountNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CountNumber;
        private System.Windows.Forms.Button CancelCounter;
        private System.Windows.Forms.Button SetCount;
    }
}