using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryApp.model
{
    internal class M_Transaksi
    {
        string id_pelanggan, jenis_pakaian, berat_total, tanggal_masuk, tanggal_selesai, metode_pembayaran, jenis_service, setrika_uap, hanger, total_harga;

        public M_Transaksi()
        {

        }

        public M_Transaksi(string id_pelanggan, string jenis_pakaian, string berat_total, string tanggal_masuk, string tanggal_selesai, string metode_pembayaran, string jenis_service, string setrika_uap, string hanger, string total_harga)
        {
            this.Id_pelanggan = id_pelanggan;
            this.Jenis_pakaian = jenis_pakaian;
            this.Berat_total = berat_total;
            this.Tanggal_masuk = tanggal_masuk;
            this.Tanggal_selesai = tanggal_selesai;
            this.Metode_pembayaran = metode_pembayaran;
            this.Jenis_service = jenis_service;
            this.Setrika_uap = setrika_uap;
            this.Hanger = hanger;
            this.Total_harga = total_harga;
        }

        public string Id_pelanggan { get => id_pelanggan; set => id_pelanggan = value; }
        public string Jenis_pakaian { get => jenis_pakaian; set => jenis_pakaian = value; }
        public string Berat_total { get => berat_total; set => berat_total = value; }
        public string Tanggal_masuk { get => tanggal_masuk; set => tanggal_masuk = value; }
        public string Tanggal_selesai { get => tanggal_selesai; set => tanggal_selesai = value; }
        public string Metode_pembayaran { get => metode_pembayaran; set => metode_pembayaran = value; }
        public string Jenis_service { get => jenis_service; set => jenis_service = value; }
        public string Setrika_uap { get => setrika_uap; set => setrika_uap = value; }
        public string Hanger { get => hanger; set => hanger = value; }
        public string Total_harga { get => total_harga; set => total_harga = value; }
    }
}
