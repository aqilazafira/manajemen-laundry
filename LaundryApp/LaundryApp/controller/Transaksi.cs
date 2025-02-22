using LaundryApp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp.controller
{
    internal class Transaksi
    {
        Koneksi koneksi = new Koneksi();
        public bool Insert(M_Transaksi transaksi)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_transaksi " +
                    "(nama, nohp, tanggal_daftar) VALUES('" + transaksi.Jenis_pakaian + "', '" +
                    transaksi.Berat_total + "','" + transaksi.Tanggal_masuk + "','" + transaksi.Tanggal_selesai + "','" + transaksi.Metode_pembayaran + "','" + transaksi.Jenis_service + "','" + transaksi.Setrika_uap + "','" + transaksi.Hanger + "','" + transaksi.Total_harga + "')");
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

        public bool Update(M_Transaksi transaksi, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_transaksi " +
                    "(nama, nohp, tanggal_daftar) VALUES('" + transaksi.Jenis_pakaian + "', '" +
                    transaksi.Berat_total + "','" + transaksi.Tanggal_masuk + "','" + transaksi.Tanggal_selesai + "','" + transaksi.Metode_pembayaran + "','" + transaksi.Jenis_service + "','" + transaksi.Setrika_uap + "','" + transaksi.Hanger + "','" + transaksi.Total_harga + "' WHERE id_transaksi='" + id + "'");
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
                koneksi.ExecuteQuery("DELETE FROM t_transaksi WHERE id_transaksi='" + id + "'");
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

        public bool HandleInputTransaksi(string id_pelanggan, string jenis_pakaian, string berat_total, string tanggal_masuk, string tanggal_selesai, string metode_pembayaran, string jenis_service, string setrika_uap, string hanger, string total_harga, string status_selesai)
        {
            if (string.IsNullOrWhiteSpace(id_pelanggan) || string.IsNullOrWhiteSpace(jenis_pakaian) || string.IsNullOrWhiteSpace(berat_total) || string.IsNullOrWhiteSpace(tanggal_masuk) || string.IsNullOrWhiteSpace(tanggal_selesai) || string.IsNullOrWhiteSpace(metode_pembayaran) || string.IsNullOrWhiteSpace(jenis_service) || string.IsNullOrWhiteSpace(total_harga))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            M_Transaksi transaksi = new M_Transaksi(id_pelanggan, jenis_pakaian, berat_total, tanggal_masuk, tanggal_selesai, metode_pembayaran, jenis_service, setrika_uap, hanger, total_harga, status_selesai);
            return Insert(transaksi);
        }
    }
}

