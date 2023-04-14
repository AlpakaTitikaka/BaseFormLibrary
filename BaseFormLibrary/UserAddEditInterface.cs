using System;
using System.Linq;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class UserAddEditInterface : UserControl
    {
        public UserAddEditInterface()
        {
            InitializeComponent();
        }

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
        public DateTime Birhtday
        {
            get => birthday.Value;
            set => birthday.Value = value;
        }
        public bool AddPolis
        {
            get => polis.Visible;
            set 
            { 
                polis.Visible = value; 
                label8.Visible = value;
            }
        }
        public bool AddSnils
        {
            get => snils.Visible;
            set 
            { 
                snils.Visible = value; 
                label7.Visible = value;
            }
        }
        public bool AddId
        {
            get => id.Visible;
            set 
            { 
                id.Visible = value; 
                label1.Visible = value;
            }
        }
        public bool AddFullName
        {
            get => fullName.Visible;
            set 
            { 
                fullName.Visible = value;
                label2.Visible = value;
            }
        }
        public bool AddPassport
        {
            get => passport.Visible;
            set 
            { 
                passport.Visible = value; 
                label3.Visible = value;
            }
        }
        public bool AddAddress
        {
            get => address.Visible;
            set 
            { 
                address.Visible = value; 
                label4.Visible = value;
            }
        }
        public bool AddPhone
        {
            get => phone.Visible;
            set 
            { 
                phone.Visible = value; 
                label5.Visible = value;
            }
        }
        public bool AddEmail
        {
            get => email.Visible;
            set
            {
                email.Visible = value;
                label6.Visible = value;
            }
        }
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
