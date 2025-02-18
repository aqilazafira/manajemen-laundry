using LaundryApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp.controller
{
    internal class CekRegister
    {
        Koneksi koneksi = new Koneksi();
        public bool Insert(M_User user)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_user " +
                    "(username, email, password) VALUES('" + user.Username + "', '" +
                    user.Email + "','" + user.Password + "')");
                status = true;
                MessageBox.Show("Berhasil registrasi.", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal registrasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
