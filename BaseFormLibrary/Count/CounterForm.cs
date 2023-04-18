using System.Drawing;
using System.Windows.Forms;

namespace BaseFormLibrary.Count
{
    public partial class CounterForm : Form
    {
        public CounterForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => Text; 
            set => Text = value;
        }

        public string SetButtonTitle
        {
            get => SetCount.Text; 
            set => SetCount.Text = value;
        }

        public Color SetCountColor
        {
            get => SetCount.BackColor; 
            set => SetCount.BackColor = value;
        }
        public Color CancelCounterColor
        {
            get => CancelCounter.BackColor;
            set => CancelCounter.BackColor = value;
        }

        public int Value
        {
            get => (int)CountNumber.Value;
            set => CountNumber.Value = value;
        }
        public int MaxValue 
        { 
            get => (int)CountNumber.Maximum; 
            set => CountNumber.Maximum = value; 
        }

    }
}
