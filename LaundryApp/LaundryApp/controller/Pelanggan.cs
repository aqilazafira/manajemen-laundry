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

        public bool Update(M_Pelanggan pelanggan, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_pelanggan " +
                    "(nama, nohp, DATE_FORMAT(tanggal_daftar, 'yyyy-MM-dd')AS tanggal_daftar) VALUES('" + pelanggan.Nama + "', '" +
                    pelanggan.Nohp + "','" + pelanggan.Tanggal_daftar + "' WHERE id_pelanggan = '" + id + "'");

                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_pelanggan WHERE id_pelanggan = '" + id + "'");

                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool HandleInputPelanggan(string nama, string nohp, string tanggal_daftar)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(nohp) || string.IsNullOrWhiteSpace(tanggal_daftar))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            M_Pelanggan pelanggan = new M_Pelanggan(nama, nohp, tanggal_daftar);
            return Insert(pelanggan);
        }
    }
}
