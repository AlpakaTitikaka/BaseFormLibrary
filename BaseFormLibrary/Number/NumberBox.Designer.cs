using System.Windows.Forms;

namespace BaseFormLibrary.Number
{
    partial class NumberBox
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
            this.NumberText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberText
            // 
            this.NumberText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberText.Location = new System.Drawing.Point(0, 0);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(249, 20);
            this.NumberText.TabIndex = 0;
            this.NumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberText_KeyPress);
            // 
            // NumberBox
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.NumberText);
            this.Name = "NumberBox";
            this.Size = new System.Drawing.Size(249, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NumberText;
    }
}
