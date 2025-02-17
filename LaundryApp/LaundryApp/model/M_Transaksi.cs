using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryApp.model
{
    internal class M_Transaksi
    {
        public int Id { get; set; }
        public string NamaPelanggan { get; set; }
        public string JenisPakaian { get; set; }
        public double BeratTotal { get; set; }
        public string JenisService { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public DateTime TanggalSelesai { get; set; }
        public bool SetrikaUap { get; set; }
        public bool Hanger { get; set; }
        public string MetodePembayaran { get; set; }
        public double TotalHarga { get; set; }

        public M_Transaksi()
        {
        }

        public M_Transaksi(int id, string namaPelanggan, string jenisPakaian, double beratTotal, string jenisService, DateTime tanggalMasuk, DateTime tanggalSelesai, bool setrikaUap, bool hanger, string metodePembayaran, double totalHarga)
        {
            Id = id;
            NamaPelanggan = namaPelanggan;
            JenisPakaian = jenisPakaian;
            BeratTotal = beratTotal;
            JenisService = jenisService;
            TanggalMasuk = tanggalMasuk;
            TanggalSelesai = tanggalSelesai;
            SetrikaUap = setrikaUap;
            Hanger = hanger;
            MetodePembayaran = metodePembayaran;
            TotalHarga = totalHarga;
        }
    }
}
