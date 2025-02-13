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
    public partial class DataTransaksi : Form
    {
        public DataTransaksi()
        {
            InitializeComponent();
        }

        private void txtBeratTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Logika untuk update data
            if (string.IsNullOrWhiteSpace(txtNamaPelanggan.Text) || string.IsNullOrWhiteSpace(txtBeratTotal.Text))
            {
                MessageBox.Show("Mohon pilih data yang akan diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update data ke database atau list
            MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshData(); // Refresh data setelah update
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Konfirmasi penghapusan
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Hapus data dari database atau list
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData(); // Refresh data setelah penghapusan
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData(); // Method untuk memuat ulang data
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
    }
    }