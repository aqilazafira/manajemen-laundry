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
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void ResetForm()
        {
            txtCariData.Text = "";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtCariData_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPenyelesaianTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_pelanggan.id_pelanggan, jenis_pakaian, berat_total, tanggal_masuk, tanggal_selesai, metode_pembayaran, jenis_service, total_harga FROM t_transaksi JOIN t_pelanggan ON t_pelanggan.id_pelanggan = t_transaksi.id_pelanggan " +
                "WHERE id_transaksi LIKE '%" + txtCariData.Text + "%' OR t_pelanggan.id_pelanggan LIKE '%" + txtCariData.Text + "%' OR nama LIKE '%" + txtCariData.Text + "%' OR jenis_pakaian LIKE '%" + txtCariData.Text + "%' OR berat_total LIKE '%" + txtCariData.Text + "%' OR tanggal_masuk LIKE '%" + txtCariData.Text + "%' OR tanggal_selesai LIKE '%" + txtCariData.Text + "%' OR metode_pembayaran LIKE '%" + txtCariData.Text + "%' OR jenis_service LIKE '%" + txtCariData.Text + "%' OR total_harga LIKE '%" + txtCariData.Text + "%'");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void btnSelesaikan_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
