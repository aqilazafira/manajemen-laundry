using LaundryApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp.controller
{
    
    internal class Pelanggan
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(M_Pelanggan pelanggan)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_pelanggan " +
                    "(nama, nohp, tanggal_daftar) VALUES('" + pelanggan.Nama + "', '" + 
                    pelanggan.Nohp + "','" + pelanggan.Tanggal_daftar + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
