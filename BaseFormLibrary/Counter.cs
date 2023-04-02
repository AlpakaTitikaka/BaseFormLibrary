using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class Counter : Form
    {
        public Counter(int value, int maxValue)
        {
            InitializeComponent();
            Value = value;
            MaxValue = maxValue;
        }
        public int Value
        {
            get => (int)CountNumber.Value;
            set => CountNumber.Value = value;
        }
        public int MaxValue { set => CountNumber.Maximum = value; }
    }
}
