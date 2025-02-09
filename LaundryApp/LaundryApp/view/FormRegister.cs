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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(retypePassword) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != retypePassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

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
                MessageBox.Show("Registration successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
