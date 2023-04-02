using System;
using System.Collections.Generic;
using System.Data;
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

        private void polis_VisibleChanged(object sender, EventArgs e)
            => label8.Visible = ((TextBox)sender).Visible;

        private void snils_VisibleChanged(object sender, EventArgs e)
            => label7.Visible = ((TextBox)sender).Visible;


        public void Clear()
        {
            for (int i = 0; i < Controls.OfType<TextBox>().Count(); i ++)
                Controls.OfType<TextBox>().ElementAt(i).Text = "";
        }
        public void SetValues(string fullname, string passport, DateTime birthday, string address, string phone, string email)
        {
            FullName = fullname;
            Passport = passport;
            Birhtday = birthday;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public void SetValues(string fullname, string passport, DateTime birthday, string address, string phone, string email, string polis)
        {
            SetValues(fullname, passport, birthday, address, phone, email);
            Polis = polis;
        }

        public void SetValues(string fullname, string passport, DateTime birthday, string address, string phone, string email, string polis, string snils)
        {
            SetValues(fullname, passport, birthday, address, phone, email, polis);
            Snils = snils;
        }
        public void SetValues(int id, string fullname, string passport, DateTime birthday, string address, string phone, string email)
        {
            SetValues(fullname, passport, birthday, address, phone, email);
            Id = id.ToString();
        }

        public void SetValues(int id, string fullname, string passport, DateTime birthday, string address, string phone, string email, string polis)
        {
            SetValues(id, fullname, passport, birthday, address, phone, email);
            Polis = polis;
        }

        public void SetValues(int id, string fullname, string passport, DateTime birthday, string address, string phone, string email, string polis, string snils)
        {
            SetValues(id, fullname, passport, birthday, address, phone, email, polis);
            Snils = snils;
        }

        private void resize()
            =>Height = (tableLayoutPanel1.Controls.OfType<TextBox>().Count(t => t.Visible) + 1) * label1.Height + 3;

        private void UserAddEditInterface_SizeChanged(object sender, EventArgs e)
            => resize();

        private void UserAddEditInterface_Load(object sender, EventArgs e)
            => resize();

        private void label7_VisibleChanged(object sender, EventArgs e)
            => resize();

        private void UserAddEditInterface_FontChanged(object sender, EventArgs e)
            => resize();

        private void id_VisibleChanged(object sender, EventArgs e)
            => label1.Visible = ((TextBox)sender).Visible;
    }
}
