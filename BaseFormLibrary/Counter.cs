using BaseFormLibrary.Count;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class Counter : Component
    {
        public Counter()
        {
            InitializeComponent();
        }

        public Counter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private CounterForm form = new CounterForm();

        public int Count() => Count(Value);

        public int Count(int startValue)
        {
            CounterForm f = new CounterForm();
            f.Value = startValue;
            f.MaxValue = MaxValue;
            f.Font = Font;
            f.Text = Text;
            f.BackColor = BackColor;
            f.ForeColor = ForeColor;
            f.SetButtonTitle = SetText;
            f.SetCountColor = SetColor;
            f.CancelCounterColor = CancelColor;
            int value = startValue;
            if (f.ShowDialog(ParentForm) == DialogResult.OK)
                value = f.Value;
            f.Dispose();
            return value;
        }

        public int Value
        {
            get => form.Value; set => form.Value = value;
        }
        public int MaxValue
        {
            get => form.MaxValue; set => form.MaxValue = value;
        }
        public Font Font
        {
            get => form.Font; set => form.Font = value;
        }
        public string Text
        {
            get => form.Title; set => form.Title = value;
        }
        public Color BackColor
        {
            get => form.BackColor; set => form.BackColor = value;
        }
        public Color ForeColor 
        { 
            get => form.ForeColor; set => form.ForeColor = value;
        }
        public string SetText
        {
            get => form.SetButtonTitle; set => form.SetButtonTitle = value;
        }
        public Color SetColor
        {
            get => form.SetCountColor; set => form.SetCountColor = value;
        }
        public Form ParentForm
        {
            get; set;
        }
        public Color CancelColor
        {
            get => form.CancelCounterColor; set => form.CancelCounterColor = value; 
        }
    }
}
