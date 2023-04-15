using System;
using System.Linq;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class UserAddEditInterface : UserControl
    {
        /// <summary>
        /// Контрол, который может выводить информацию о клиенте, а также дает возможность изменять ее
        /// </summary>
        public UserAddEditInterface()
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
        public DateTime Birhtday
        {
            get => birthday.Value;
            set => birthday.Value = value;
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
                label8.Visible = value;
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
                label7.Visible = value;
            }
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
                label1.Visible = value;
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
                label2.Visible = value;
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
                label3.Visible = value;
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
                label4.Visible = value;
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
                label5.Visible = value;
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
                label6.Visible = value;
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
                label9.Visible = value;
            }
        }

        private void resize()
            =>Height = (tableLayoutPanel1.Controls.OfType<TextBox>().Count(t => t.Visible) + 1) * label1.Height + 3;

        private void UserAddEditInterface_SizeChanged(object sender, EventArgs e)
            => resize();

        private void UserAddEditInterface_Load(object sender, EventArgs e)
            => resize();

        private void UserAddEditInterface_FontChanged(object sender, EventArgs e)
            => resize();

        private void id_VisibleChanged(object sender, EventArgs e) => resize();
    }
}
