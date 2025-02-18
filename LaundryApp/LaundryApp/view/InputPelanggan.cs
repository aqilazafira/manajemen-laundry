using LaundryApp.controller;
using LaundryApp.model;
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
    public partial class InputPelanggan : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Pelanggan m_pelanggan = new M_Pelanggan();

        public InputPelanggan()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            txtNamaPelanggan.Text = "";
            txtNoHP.Text = "";
            dtpTanggalDaftar.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                m_pelanggan.Tanggal_daftar = dtpTanggalDaftar.ToString();
                pelanggan.Insert(m_pelanggan);

                ResetForm();
                DataPelanggan dp = new DataPelanggan();
                this.Hide();
                dp.Show();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
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
