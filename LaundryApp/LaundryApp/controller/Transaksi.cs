using LaundryApp.model;
using System;
using System.Collections.Generic;
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
                    "(jenis_pakaian, berat_total, tanggal_masuk, tanggal_selesai, metode_pembayaran, jenis_service, total_harga) VALUES('" +
                    transaksi.Jenis_pakaian + "','" + transaksi.Berat_total + "','" + transaksi.Tanggal_masuk + "','" + transaksi.Tanggal_selesai + "','" + transaksi.Metode_pembayaran + "','" + transaksi.Jenis_service + "','" + transaksi.Total_harga + "')");
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
