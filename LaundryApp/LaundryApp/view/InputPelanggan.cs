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
               MessageBox.Show("Data tidak boleh kosong", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelanggan plgn = new Pelanggan();
                m_plgn.Nama = txtNamaPelanggan.Text;
                m_plgn.Nohp = txtNoHP.Text;
                m_plgn.Tanggal_daftar = dtpTanggalDaftar.Text;

                plgn.Insert(m_plgn);
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
