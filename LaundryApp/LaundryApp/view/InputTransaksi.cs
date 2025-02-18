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
    public partial class InputTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Transaksi m_transaksi = new M_Transaksi();
        string id_transaksi;

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                m_transaksi.Tanggal_masuk = dtpTanggalMasuk.Value.ToString("yyyy-MM-dd");
                m_transaksi.Tanggal_selesai = dtpTanggalSelesai.Value.ToString("yyyy-MM-dd");
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
                transaksi.Insert(m_transaksi);

                ResetForm();
                DataTransaksi dt = new DataTransaksi();
                this.Hide();
                dt.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
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

        private void txtBeratTotal_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void cmbJenisService_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void txtTotalHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIdPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNamaPelanggan();
            getNohp();
        }

        private void chkSetrikaUap_CheckedChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void chkHanger_CheckedChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            ResetForm();
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
