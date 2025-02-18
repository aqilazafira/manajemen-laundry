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
    public partial class PenyelesaianTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Transaksi m_transaksi = new M_Transaksi();
        string id_transaksi;
        public PenyelesaianTransaksi()
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
                    int total_final = total + hanger;
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

        public void Tampil()
        {
            dataGridViewPenyelesaianTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_pelanggan.id_pelanggan, jenis_pakaian, berat_total, DATE_FORMAT(tanggal_masuk, '%Y-%m-%d') AS tanggal_masuk, DATE_FORMAT(tanggal_selesai, '%Y-%m-%d') AS tanggal_selesai, metode_pembayaran, jenis_service, total_harga FROM t_transaksi JOIN t_pelanggan ON t_pelanggan.id_pelanggan = t_transaksi.id_pelanggan");

            dataGridViewPenyelesaianTransaksi.Columns[0].HeaderText = "ID";
            dataGridViewPenyelesaianTransaksi.Columns[1].HeaderText = "ID Pelanggan";
            dataGridViewPenyelesaianTransaksi.Columns[2].HeaderText = "Jenis Pakaian";
            dataGridViewPenyelesaianTransaksi.Columns[3].HeaderText = "Berat Total";
            dataGridViewPenyelesaianTransaksi.Columns[4].HeaderText = "Tanggal Masuk";
            dataGridViewPenyelesaianTransaksi.Columns[5].HeaderText = "Tanggal Selesai";
            dataGridViewPenyelesaianTransaksi.Columns[6].HeaderText = "Metode Pembayaran";
            dataGridViewPenyelesaianTransaksi.Columns[7].HeaderText = "Jenis Service";
            dataGridViewPenyelesaianTransaksi.Columns[8].HeaderText = "Setrika Uap";
            dataGridViewPenyelesaianTransaksi.Columns[9].HeaderText = "Hanger";
            dataGridViewPenyelesaianTransaksi.Columns[10].HeaderText = "Total Harga";

            dataGridViewPenyelesaianTransaksi.Columns[10].DefaultCellStyle.Format = "Rp ###,###";
        }
        private void PenyelesaianTransaksi_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void txtBeratTotal_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dataGridViewPenyelesaianTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxIdPelanggan.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            lstJenisPakaian.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBeratTotal.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNoHP.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpTanggalMasuk.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpTanggalSelesai.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (rdoCash.Checked)
            {
                rdoMenyusul.Checked = false;
                rdoTransfer.Checked = false;
                rdoCash.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (rdoMenyusul.Checked)
            {
                rdoCash.Checked = false;
                rdoTransfer.Checked = false;
                rdoMenyusul.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (rdoTransfer.Checked)
            {
                rdoCash.Checked = false;
                rdoMenyusul.Checked = false;
                rdoTransfer.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            cmbJenisService.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[8].Value.ToString();
            chkSetrikaUap.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[9].Value.ToString();
            chkHanger.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtTotalHarga.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtCariData.Text = dataGridViewPenyelesaianTransaksi.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void txtCariData_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPenyelesaianTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_pelanggan.id_pelanggan, jenis_pakaian, berat_total, tanggal_masuk, tanggal_selesai, metode_pembayaran, jenis_service, total_harga FROM t_transaksi JOIN t_pelanggan ON t_pelanggan.id_pelanggan = t_transaksi.id_pelanggan " +
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
