using System.Linq;
using System.Windows.Forms;

namespace BaseFormLibrary.User
{
    /// <summary>
    /// Контрол, который может выводить информацию о клиенте без возможности ее редактирования (в запущенной программе)
    /// </summary>
    public partial class UserOutInterface : UserControl
    {
        /// <summary>
        /// Контрол, который может выводить информацию о клиенте без возможности ее редактирования (в запущенной программе)
        /// </summary>
        public UserOutInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Код клиента
        /// </summary>
        public string Id
        {
            get => id.Text;
            set => id.Text = value;
        }
        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string FullName
        {
            get => fullName.Text;
            set => fullName.Text = value;
        }
        /// <summary>
        /// Паспортные данные клиента
        /// </summary>
        public string Passport
        {
            get => passport.Text;
            set => passport.Text = value;
        }
        /// <summary>
        /// Адрес клиента
        /// </summary>
        public string Address
        {
            get => address.Text;
            set => address.Text = value;
        }
        /// <summary>
        /// Телефон клиента
        /// </summary>
        public string Phone
        {
            get => phone.Text;
            set => phone.Text = value;
        }
        /// <summary>
        /// Почта клиента
        /// </summary>
        public string Email
        {
            get => email.Text;
            set => email.Text = value;
        }
        /// <summary>
        /// Полис клиента
        /// </summary>
        public string Polis
        {
            get => polis.Text;
            set => polis.Text = value;
        }
        /// <summary>
        /// СНИЛС клиента
        /// </summary>
        public string Snils
        {
            get => snils.Text;
            set => snils.Text = value;
        }
        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public string Birhtday
        {
            get => birthday.Text;
            set => birthday.Text = value;
        }
        /// <summary>
        /// Добавить код
        /// </summary>
        public bool AddId
        {
            get => id.Visible;
            set
            {
                id.Visible = value;
                Title9.Visible = value;
            }
        }
        /// <summary>
        /// Добавить ФИО
        /// </summary>
        public bool AddFullName
        {
            get => fullName.Visible;
            set
            { 
                fullName.Visible = value;
                Title1.Visible = value;
            }
        }
        /// <summary>
        /// Добавить паспорт
        /// </summary>
        public bool AddPassport
        {
            get => passport.Visible;
            set
            {
                passport.Visible = value;
                Title2.Visible = value;
            }
        }
        /// <summary>
        /// Добавить адрес
        /// </summary>
        public bool AddAddress
        {
            get => address.Visible;
            set
            {
                address.Visible = value;
                Title5.Visible = value;
            }
        }
        /// <summary>
        /// Добавить телефон
        /// </summary>
        public bool AddPhone
        {
            get => phone.Visible;
            set
            {
                phone.Visible = value;
                Title4.Visible = value;
            }
        }
        /// <summary>
        /// Добавить почту
        /// </summary>
        public bool AddEmail
        {
            get => email.Visible;
            set
            {
                email.Visible = value;
                Title3.Visible = value;
            }
        }
        /// <summary>
        /// Добавить дату рождения
        /// </summary>
        public bool AddBirhtday
        {
            get => birthday.Visible;
            set
            {
                birthday.Visible = value;
                Title8.Visible = value;
            }
        }
        /// <summary>
        /// Добавить полис
        /// </summary>
        public bool AddPolis
        {
            get => polis.Visible;
            set
            {
                polis.Visible = value;
                Title7.Visible = value;
            }
        }
        /// <summary>
        /// Добавить СНИЛС
        /// </summary>
        public bool AddSnils
        {
            get => snils.Visible;
            set
            { 
                snils.Visible = value; 
                Title6.Visible = value;
            }
        }
        /// <summary>
        /// Устанавливает значение контрола
        /// </summary>
        /// <param name="items">Массив string</param>
        public void SetValues(string[] items)
        {
            Control[] controls = UserInfo.Controls.OfType<Label>().
                Where(l => l.Visible == true && l.Tag != null).OrderBy(l => l.Tag).ToArray();
            for (int i = 0; i < controls.Count(); i++)
                controls[i].Text = items[i];
        }
    }
}
