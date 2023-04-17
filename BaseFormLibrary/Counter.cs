using BaseFormLibrary.Count;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class Counter : Component
    {
        /// <summary>
        /// Компонент, который открывает форму-счетчик для получения значения
        /// </summary>
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
        /// <summary>
        /// Метод вызывает форму-счетчик и возвращает значение из нее
        /// </summary>
        /// <returns>Значение счетчика</returns>
        public int Count() => Count(Value);
        /// <summary>
        /// Метод вызывает форму-счетчик, в качестве значения в строке использует начальное входное значение и возвращает значение из нее
        /// </summary>
        /// <param name="startValue">Начальное значение</param>
        /// <returns>Значение счетчика</returns>
        public int Count(int startValue)
        {
            CounterForm f = new CounterForm();
            f.Value = startValue;
            f.MaxValue = MaxValue;
            f.Font = Font;
            f.Text = Title;
            f.BackColor = BackColor;
            f.ForeColor = ForeColor;
            f.SetButtonTitle = ButtonSetText;
            f.SetCountColor = ButtonSetColor;
            f.CancelCounterColor = CancelButtonColor;
            int value = startValue;
            if (f.ShowDialog(ParentForm) == DialogResult.OK)
                value = f.Value;
            f.Dispose();
            return value;
        }
        /// <summary>
        /// Значение в строке счетчика
        /// </summary>
        public int Value
        {
            get => form.Value; 
            set => form.Value = value;
        }
        /// <summary>
        /// Максимальное начение в строке счетчика
        /// </summary>
        public int MaxValue
        {
            get => form.MaxValue; 
            set => form.MaxValue = value;
        }
        /// <summary>
        /// Стиль оформления формы (шрифт, кегль и др)
        /// </summary>
        public Font Font
        {
            get => form.Font; 
            set => form.Font = value;
        }
        /// <summary>
        /// Заголовок счетчика
        /// </summary>
        public string Title
        {
            get => form.Title; 
            set => form.Title = value;
        }
        /// <summary>
        /// Цвет формы
        /// </summary>
        public Color BackColor
        {
            get => form.BackColor; 
            set => form.BackColor = value;
        }
        /// <summary>
        /// Цвет надписей
        /// </summary>
        public Color ForeColor 
        { 
            get => form.ForeColor; 
            set => form.ForeColor = value;
        }
        /// <summary>
        /// Надпись на кнопке установления значения
        /// </summary>
        public string ButtonSetText
        {
            get => form.SetButtonTitle; 
            set => form.SetButtonTitle = value;
        }
        /// <summary>
        /// Цвет кнопки установления значения
        /// </summary>
        public Color ButtonSetColor
        {
            get => form.SetCountColor; 
            set => form.SetCountColor = value;
        }
        /// <summary>
        /// Родительская форма, к которой принадлежит счетчик
        /// </summary>
        public Form ParentForm { get; set; }
        /// <summary>
        /// Цвет кнопки отмены действия
        /// </summary>
        public Color CancelButtonColor
        {
            get => form.CancelCounterColor; 
            set => form.CancelCounterColor = value; 
        }
    }
}
