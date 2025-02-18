using LaundryApp.controller;
using LaundryApp.model;
using MySql.Data.MySqlClient;
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
        Koneksi koneksi = new Koneksi();
        M_Transaksi m_transaksi = new M_Transaksi();
        string id_transaksi;

        public DataTransaksi()
        {
            InitializeComponent();
        }

        public void GetDataTrx()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_pelanggan");
            while (reader.Read())
            {
                int id_pelanggan = reader.GetInt32("id_pelanggan");
                comboBoxIdPelanggan.Items.Add(id_pelanggan);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void ResetForm()
        {
            comboBoxIdPelanggan.SelectedIndex = -1;
            txtNamaPelanggan.Text = "";
            lstJenisPakaian.Text = "";
            txtBeratTotal.Text = "";
            txtNoHP.Text = "";
            dtpTanggalMasuk.Value = DateTime.Now;
            dtpTanggalSelesai.Value = DateTime.Now;
            rdoCash.Checked = false;
            rdoMenyusul.Checked = false;
            rdoTransfer.Checked = false;
            cmbJenisService.SelectedIndex = -1;
            chkSetrikaUap.Checked = false;
            chkHanger.Checked = false;
            txtTotalHarga.Text = "";
            txtCariData.Text = "";
        }

        public void getNamaPelanggan()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_pelanggan WHERE id_pelanggan = '" + comboBoxIdPelanggan.Text + "'");
            while (reader.Read())
            {
                string nama = reader.GetString("nama");
                txtNamaPelanggan.Text = nama;
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getNohp()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_pelanggan WHERE id_pelanggan = '" + comboBoxIdPelanggan.Text + "'");
            while (reader.Read())
            {
                int nohp = reader.GetInt32("nohp");
                txtNoHP.Text = nohp.ToString();
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getTotal()
        {
            if (int.TryParse(txtBeratTotal.Text, out int berat_total) && int.TryParse(cmbJenisService.Text, out int jenis_service))
            {
                int total = berat_total * jenis_service;
                int setrika_uap = 5000;
                int hanger = 5000;
                if (chkSetrikaUap.Checked)
                {
                    int total_final = total + setrika_uap;
                    txtTotalHarga.Text = total_final.ToString();
                }
                else if (chkHanger.Checked)
                {
                    int total_final= total + hanger;
                    txtTotalHarga.Text = total_final.ToString();
                }
                else if (chkSetrikaUap.Checked && chkHanger.Checked)
                {
                    int total_final = total + setrika_uap + hanger;
                    txtTotalHarga.Text = total_final.ToString();
                }
                else
                {
                    txtTotalHarga.Text = total.ToString();
                }
            }
        }

        private void txtBeratTotal_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxIdPelanggan.Text == "" || lstJenisPakaian.Text == "" || dtpTanggalMasuk.Text == "" || dtpTanggalSelesai.Text == "" || (!rdoCash.Checked && !rdoMenyusul.Checked && !rdoTransfer.Checked) || cmbJenisService.SelectedIndex == -1 || txtTotalHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Transaksi transaksi = new Transaksi();
                m_transaksi.Id_pelanggan = comboBoxIdPelanggan.Text;
                m_transaksi.Jenis_pakaian = lstJenisPakaian.Text;
                m_transaksi.Tanggal_masuk = dtpTanggalMasuk.ToString();
                m_transaksi.Tanggal_selesai = dtpTanggalSelesai.ToString();
                if (rdoCash.Checked)
                {
                    rdoMenyusul.Checked = false;
                    rdoTransfer.Checked = false;
                    m_transaksi.Metode_pembayaran = "Cash";
                }
                else if (rdoMenyusul.Checked)
                {
                    rdoCash.Checked = false;
                    rdoTransfer.Checked = false;
                    m_transaksi.Metode_pembayaran = "Menyusul";
                }
                else if (rdoTransfer.Checked)
                {
                    rdoCash.Checked = false;
                    rdoMenyusul.Checked = false;
                    m_transaksi.Metode_pembayaran = "Transfer";
                }
                m_transaksi.Jenis_service = cmbJenisService.Text;
                m_transaksi.Total_harga = txtTotalHarga.Text;

                transaksi.Update(m_transaksi, id_transaksi);

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
                Transaksi transaksi = new Transaksi();
                transaksi.Delete(id_transaksi);
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
            dataGridViewTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_pelanggan.id_pelanggan, jenis_pakaian, berat_total, DATE_FORMAT(tanggal_masuk, '%Y-%m-%d') AS tanggal_masuk, DATE_FORMAT(tanggal_selesai, '%Y-%m-%d') AS tanggal_selesai, metode_pembayaran, jenis_service, total_harga FROM t_transaksi JOIN t_pelanggan ON t_pelanggan.id_pelanggan = t_transaksi.id_pelanggan");

            dataGridViewTransaksi.Columns[0].HeaderText = "ID";
            dataGridViewTransaksi.Columns[1].HeaderText = "ID Pelanggan";
            dataGridViewTransaksi.Columns[2].HeaderText = "Jenis Pakaian";
            dataGridViewTransaksi.Columns[3].HeaderText = "Berat Total";
            dataGridViewTransaksi.Columns[4].HeaderText = "Tanggal Masuk";
            dataGridViewTransaksi.Columns[5].HeaderText = "Tanggal Selesai";
            dataGridViewTransaksi.Columns[6].HeaderText = "Metode Pembayaran";
            dataGridViewTransaksi.Columns[7].HeaderText = "Jenis Service";
            dataGridViewTransaksi.Columns[8].HeaderText = "Setrika Uap";
            dataGridViewTransaksi.Columns[9].HeaderText = "Hanger";
            dataGridViewTransaksi.Columns[10].HeaderText = "Total Harga";

            dataGridViewTransaksi.Columns[10].DefaultCellStyle.Format = "Rp ###,###";
        }
        private void DataTransaksi_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = dataGridViewTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxIdPelanggan.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            lstJenisPakaian.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBeratTotal.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNoHP.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpTanggalMasuk.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpTanggalSelesai.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (rdoCash.Checked)
            {
                rdoMenyusul.Checked = false;
                rdoTransfer.Checked = false;
                rdoCash.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (rdoMenyusul.Checked)
            {
                rdoCash.Checked = false;
                rdoTransfer.Checked = false;
                rdoMenyusul.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (rdoTransfer.Checked)
            {
                rdoCash.Checked = false;
                rdoMenyusul.Checked = false;
                rdoTransfer.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            cmbJenisService.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[8].Value.ToString();
            chkSetrikaUap.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[9].Value.ToString();
            chkHanger.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtTotalHarga.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtCariData.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void txtCariData_TextChanged(object sender, EventArgs e)
        {
            dataGridViewTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_pelanggan.id_pelanggan, jenis_pakaian, berat_total, tanggal_masuk, tanggal_selesai, metode_pembayaran, jenis_service, total_harga FROM t_transaksi JOIN t_pelanggan ON t_pelanggan.id_pelanggan = t_transaksi.id_pelanggan " +
                "WHERE id_transaksi LIKE '%" + txtCariData.Text + "%' OR t_pelanggan.id_pelanggan LIKE '%" + txtCariData.Text + "%' OR nama LIKE '%" + txtCariData.Text + "%' OR jenis_pakaian LIKE '%" + txtCariData.Text + "%' OR berat_total LIKE '%" + txtCariData.Text + "%' OR tanggal_masuk LIKE '%" + txtCariData.Text + "%' OR tanggal_selesai LIKE '%" + txtCariData.Text + "%' OR metode_pembayaran LIKE '%" + txtCariData.Text + "%' OR jenis_service LIKE '%" + txtCariData.Text + "%' OR total_harga LIKE '%" + txtCariData.Text + "%'");
        }

        private void comboBoxIdPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNamaPelanggan();
            getNohp();
        }

        private void cmbJenisService_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void chkSetrikaUap_CheckedChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void chkHanger_CheckedChanged(object sender, EventArgs e)
        {
            getTotal();
        }
    }
}
