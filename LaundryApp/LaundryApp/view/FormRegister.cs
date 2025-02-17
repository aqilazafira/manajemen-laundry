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

namespace LaundryApp.view
{
    public partial class FormRegister : Form
    {
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
                string username = txtUsername.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string retypePassword = txtRetypePassword.Text;

                try
                {
                    Koneksi koneksi = new Koneksi();
                    string query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                    var parameters = new Dictionary<string, object>
                {
                    { "@Username", username },
                    { "@Password", password },
                    { "@Email", email }
                };

                    koneksi.ExecuteQuery(query, parameters);
                    MessageBox.Show("Registrasi berhasil.");
                    FormLogin login = new FormLogin();
                    this.Hide();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
