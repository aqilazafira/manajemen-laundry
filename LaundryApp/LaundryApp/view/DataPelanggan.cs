using LaundryApp.controller;
using LaundryApp.lib;
using LaundryApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp.view
{
    public partial class DataPelanggan : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Pelanggan m_pelanggan = new M_Pelanggan();
        string id_pelanggan;

        public DataPelanggan()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            txtNamaPelanggan.Text = "";
            txtNoHP.Text = "";
            dtpTanggalDaftar.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNamaPelanggan.Text == "" || txtNoHP.Text == "" || dtpTanggalDaftar.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelanggan pelanggan = new Pelanggan();
                m_pelanggan.Nama = txtNamaPelanggan.Text;
                m_pelanggan.Nohp = txtNoHP.Text;
                m_pelanggan.Tanggal_daftar = dtpTanggalDaftar.Value.ToString("yyyy-MM-dd");
                pelanggan.Update(m_pelanggan, id_pelanggan);

                ResetForm();
                Tampil();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Pelanggan pelanggan = new Pelanggan();
                pelanggan.Delete(id_pelanggan);
                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        public void Tampil()
        {
            dataGridViewPelanggan.DataSource = koneksi.ShowData("SELECT id_pelanggan, nama, nohp, DATE_FORMAT(tanggal_daftar, '%Y-%m-%d') AS tanggal_daftar FROM t_pelanggan");

            dataGridViewPelanggan.Columns[0].HeaderText = "ID";
            dataGridViewPelanggan.Columns[1].HeaderText = "Nama Pelanggan";
            dataGridViewPelanggan.Columns[2].HeaderText = "No. HP";
            dataGridViewPelanggan.Columns[3].HeaderText = "Tanggal Daftar";
        }

        private void DataPelanggan_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void txtCariData_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPelanggan.DataSource = koneksi.ShowData("SELECT id_pelanggan, nama, nohp, DATE_FORMAT(tanggal_daftar, 'yyyy-MM-dd') AS tanggal_daftar FROM t_pelanggan WHERE id_pelanggan LIKE '%" + txtCariData.Text + "%' OR nama LIKE '%" + txtCariData.Text + "%' OR nohp LIKE '%" + txtCariData.Text + "%' OR tanggal_daftar LIKE '%");
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "ReportPelanggan.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt} ({count}){extension}");
                    count++;
                }
                // Membuat instance dari ketas Excel
                Excel excel_lib = new Excel();
                // Memanggit metode ExportToExcet
                excel_lib.ExportToExcel(dataGridViewPelanggan, filePath);
                // Notifikasi berhasil
                MessageBox.Show("Data berhasil diekspor ke file Excel.",
                                "Informasi",
                                MessageBoxButtons.OK ,
                                MessageBoxIcon.Information);
            }
        }

        private void dataGridViewPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pelanggan = dataGridViewPelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaPelanggan.Text = dataGridViewPelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNoHP.Text = dataGridViewPelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
            string dateString = dataGridViewPelanggan.Rows[e.RowIndex].Cells[3].Value?.ToString();

            string[] formats = { "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy", "yyyyMMdd", "dd-MM-yyyy" };

            if (DateTime.TryParseExact(dateString, formats, System.Globalization.CultureInfo.InvariantCulture,
                                       System.Globalization.DateTimeStyles.None, out DateTime tanggalDaftar))
            {
                dtpTanggalDaftar.Value = tanggalDaftar;
            }
            else
            {
                MessageBox.Show("Invalid date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            ResetForm();
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
