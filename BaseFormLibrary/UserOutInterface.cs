using System.Linq;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class UserOutInterface : UserControl
    {
        public UserOutInterface()
        {
            InitializeComponent();
        }
        #region Информация
        public string Id
        {
            get => id.Text;
            set => id.Text = value;
        }
        public string FullName 
        { 
            get => fullName.Text; 
            set => fullName.Text = value; 
        }
        public string Passport
        {
            get => passport.Text;
            set => passport.Text = value;
        }
        public string Address
        {
            get => address.Text;
            set => address.Text = value;
        }
        public string Phone
        {
            get => phone.Text;
            set => phone.Text = value;
        }
        public string Email
        {
            get => email.Text;
            set => email.Text = value;
        }
        public string Polis
        {
            get => polis.Text;
            set => polis.Text = value;
        }
        public string Snils
        {
            get => snils.Text;
            set => snils.Text = value;
        }
        public string Birhtday
        {
            get => birthday.Text;
            set => birthday.Text = value;
        }
        #endregion
        #region Свойства
        public bool AddId
        {
            get => id.Visible;
            set
            {
                id.Visible = value;
                Title9.Visible = value;
            }
        }
        public bool AddFullName
        {
            get => fullName.Visible;
            set
            { 
                fullName.Visible = value;
                Title1.Visible = value;
            }
        }
        public bool AddPassport
        {
            get => passport.Visible;
            set
            {
                passport.Visible = value;
                Title2.Visible = value;
            }
        }
        public bool AddAddress
        {
            get => address.Visible;
            set
            {
                address.Visible = value;
                Title5.Visible = value;
            }
        }
        public bool AddPhone
        {
            get => phone.Visible;
            set
            {
                phone.Visible = value;
                Title4.Visible = value;
            }
        }
        public bool AddEmail
        {
            get => email.Visible;
            set
            {
                email.Visible = value;
                Title3.Visible = value;
            }
        }
        public bool AddBirhtday
        {
            get => birthday.Visible;
            set
            {
                birthday.Visible = value;
                Title8.Visible = value;
            }
        }
        public bool AddPolis
        {
            get => polis.Visible;
            set
            {
                polis.Visible = value;
                Title7.Visible = value;
            }
        }
        public bool AddSnils
        {
            get => snils.Visible;
            set
            { 
                snils.Visible = value; 
                Title6.Visible = value;
            }
        }
        #endregion

        public void SetValues(string[] items)
        {
            Control[] controls = UserInfo.Controls.OfType<Label>().
                Where(l => l.Visible == true && l.Tag != null).OrderBy(l => l.Tag).ToArray();
            for (int i = 0; i < controls.Count(); i++)
                controls[i].Text = items[i];
        }
    }
}
