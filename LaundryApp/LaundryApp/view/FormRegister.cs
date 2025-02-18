using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaundryApp.controller;
using LaundryApp.model;

namespace LaundryApp.view
{
    public partial class FormRegister : Form
    {
        Koneksi koneksi = new Koneksi();
        M_User m_user = new M_User(); 

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
        }

        public void ResetForm()
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtRetypePassword.Text = "";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtRetypePassword.Text == "")
            {
                MessageBox.Show("Username, Email, Password, dan validasi Password tidak boleh kosong!");
            }
            else if (txtPassword.Text != txtRetypePassword.Text) 
            {
                MessageBox.Show("Password dan validasi Password tidak sama!");
            }
            else
            {
                CekRegister cekregister = new CekRegister();
                m_user.Username = txtUsername.Text;
                m_user.Email = txtEmail.Text;
                m_user.Password = txtPassword.Text;
                cekregister.Insert(m_user);

                ResetForm();
                FormLogin fl = new FormLogin();
                this.Hide();
                fl.Show();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            this.Hide();
            home.Show();
        }
    }
}
