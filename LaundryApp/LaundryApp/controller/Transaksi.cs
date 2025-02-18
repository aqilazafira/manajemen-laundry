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
    public class M_Transaksi
    {
        public string Nama_pelanggan { get; set; }
        public string Jenis_pakaian { get; set; }
        public double Berat_total { get; set; }
        public DateTime Tanggal_masuk { get; set; }
        public DateTime Tanggal_selesai { get; set; }
        public string Metode_pembayaran { get; set; }
        public string Jenis_service { get; set; }
        public bool Setrika_uap { get; set; }
        public bool Hanger { get; set; }
        public double Total_harga { get; set; }
    }
    internal class Transaksi
    {
        Koneksi koneksi = new Koneksi();
        public class Koneksi
        {
            private readonly string connectionString = "Your_Connection_String_Here";

            public SqlConnection OpenConnection()
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
        public class Transaksi
        {
            private readonly Koneksi koneksi = new Koneksi();

            public bool HandleInputTransaksi(
                string namaPelanggan,
                string jenisPakaian,
                double beratTotal,
                string jenisService,
                DateTime tanggalMasuk,
                DateTime tanggalSelesai,
                bool setrikaUap,
                bool hanger,
                string metodePembayaran,
                double totalHarga)
            {
                var transaksi = new M_Transaksi
                {
                    Nama_pelanggan = namaPelanggan,
                    Jenis_pakaian = jenisPakaian,
                    Berat_total = beratTotal,
                    Jenis_service = jenisService,
                    Tanggal_masuk = tanggalMasuk,
                    Tanggal_selesai = tanggalSelesai,
                    Setrika_uap = setrikaUap,
                    Hanger = hanger,
                    Metode_pembayaran = metodePembayaran,
                    Total_harga = totalHarga
                };

                return Insert(transaksi);
            }

            public bool Insert(M_Transaksi transaksi)
            {
                const string query = @"
                INSERT INTO t_transaksi (
                    nama_pelanggan,
                    jenis_pakaian, 
                    berat_total, 
                    tanggal_masuk, 
                    tanggal_selesai, 
                    metode_pembayaran, 
                    jenis_service,
                    setrika_uap,
                    hanger, 
                    total_harga
                ) VALUES (
                    @NamaPelanggan,
                    @JenisPakaian,
                    @BeratTotal,
                    @TanggalMasuk,
                    @TanggalSelesai,
                    @MetodePembayaran,
                    @JenisService,
                    @SetrikaUap,
                    @Hanger,
                    @TotalHarga
                )";

                try
                {
                    using (var connection = koneksi.OpenConnection())
                    using (var command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@NamaPelanggan", transaksi.Nama_pelanggan);
                        command.Parameters.AddWithValue("@JenisPakaian", transaksi.Jenis_pakaian);
                        command.Parameters.AddWithValue("@BeratTotal", transaksi.Berat_total);
                        command.Parameters.AddWithValue("@TanggalMasuk", transaksi.Tanggal_masuk);
                        command.Parameters.AddWithValue("@TanggalSelesai", transaksi.Tanggal_selesai);
                        command.Parameters.AddWithValue("@MetodePembayaran", transaksi.Metode_pembayaran);
                        command.Parameters.AddWithValue("@JenisService", transaksi.Jenis_service);
                        command.Parameters.AddWithValue("@SetrikaUap", transaksi.Setrika_uap);
                        command.Parameters.AddWithValue("@Hanger", transaksi.Hanger);
                        command.Parameters.AddWithValue("@TotalHarga", transaksi.Total_harga);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menyimpan data: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
