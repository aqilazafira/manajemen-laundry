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
        M_Pelanggan m_plgn = new M_Pelanggan();
        Pelanggan pelangganController = new Pelanggan();

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
            string nama = txtNamaPelanggan.Text;
            string nohp = txtNoHP.Text;
            string tanggalDaftar = dtpTanggalDaftar.Value.ToString("yyyy-MM-dd");

            bool status = pelangganController.HandleInputPelanggan(nama, nohp, tanggalDaftar);
            if (status)
            {
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
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
