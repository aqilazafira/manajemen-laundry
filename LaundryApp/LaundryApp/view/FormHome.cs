using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp.view
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonLoginForm_Click(object sender, EventArgs e)
        {

            // Validasi Login
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "12345") // Contoh login statis
            {
                MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Arahkan ke FormInput
                Input formInput = new Input();
                formInput.Show();
                this.Hide();

                //Login
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRegisterForm_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi input tidak kosong
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Contoh: Simpan data ke file (nanti dapat diganti dengan database)
                System.IO.File.AppendAllText("users.txt", $"{username},{password}\n");

                MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Arahkan kembali ke FormLogin
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
