using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public partial class UserOutInterface : UserControl
    {
        public UserOutInterface()
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
        public string Birhtday
        {
            get => birthday.Text;
            set => birthday.Text = value;
        }
        public bool AddPolis
        {
            get => polis.Visible;
            set => polis.Visible = value;
        }
        public bool AddSnils
        {
            get => snils.Visible;
            set => snils.Visible = value;
        }
        public bool AddId
        {
            get => id.Visible;
            set => id.Visible = value;
        }

        public void SetValues(string fullname, string passport, string birthday, string address, string phone, string email)
        {
            FullName = fullname;
            Passport = passport;
            Birhtday = birthday;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public void SetValues(string fullname, string passport, string birthday, string address, string phone, string email, string polis)
        {
            SetValues(fullname, passport, birthday, address, phone, email);
            Polis = polis;
        }

        public void SetValues(string fullname, string passport, string birthday, string address, string phone, string email, string polis, string snils)
        {
            SetValues(fullname, passport, birthday, address, phone, email, polis);
            Snils = snils;
        }
        public void SetValues(int id, string fullname, string passport, string birthday, string address, string phone, string email)
        { 
            SetValues(fullname, passport, birthday, address, phone, email);
            Id = id.ToString();
        }

        public void SetValues(int id, string fullname, string passport, string birthday, string address, string phone, string email, string polis)
        {
            SetValues(id, fullname, passport, birthday, address, phone, email);
            Polis = polis;
        }

        public void SetValues(int id, string fullname, string passport, string birthday, string address, string phone, string email, string polis, string snils)
        {
            SetValues(id, fullname, passport, birthday, address, phone, email, polis);
            Snils = snils;
        }

        private void polis_VisibleChanged(object sender, EventArgs e)
            => Title7.Visible = ((Label)sender).Visible;

        private void snils_VisibleChanged(object sender, EventArgs e)
            => Title6.Visible = ((Label)sender).Visible;

        private void id_VisibleChanged(object sender, EventArgs e)
            => Title9.Visible = ((Label)sender).Visible;
    }
}
