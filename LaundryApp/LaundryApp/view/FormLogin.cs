using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp.view
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleeh kosong!");
            }
            else
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                bool status = login.cek_login(username, password);
                if (status) 
                {
                    MessageBox.Show("Login berhasil", "Berhasil");
                    ParentForm pform = new ParentForm();
                    this.Hide();
                    pform.Show();
                }
                else
                {
                    MessageBox.Show("Gagal login", "Gagal");
                }
            }
        }
    }
}
