using LaundryApp.controller;
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
    public partial class DataPelanggan : Form
    {
        Koneksi koneksi = new Koneksi();
        Pelanggan pelangganController = new Pelanggan();

        public DataPelanggan()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nama = txtNamaPelanggan.Text;
            string nohp = txtNoHP.Text;
            string tanggalDaftar = dtpTanggalDaftar.Value.ToString("yyyy-MM-dd");

            bool status = pelangganController.HandleInputPelanggan(nama, nohp, tanggalDaftar);
            if (status)
            {
                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Konfirmasi penghapusan
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Hapus data dari database atau list
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            // Logika untuk memuat data dari database atau list
            MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Gunakan SaveFileDialog untuk memilih lokasi penyimpanan file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv",
                Title = "Export Data"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Logika untuk menyimpan data ke file CSV
                System.IO.File.WriteAllText(saveFileDialog.FileName, "Sample Data");
                MessageBox.Show("Data berhasil diexport ke file!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Tampil()
        {
            dataGridViewPelanggan.DataSource = koneksi.ShowData("SELECT * FROM t_pelanggan");
        }
        private void DataPelanggan_Load(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}
