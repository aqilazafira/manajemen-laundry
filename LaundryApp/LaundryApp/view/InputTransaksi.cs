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
    public partial class InputTransaksi : Form
    {
        Transaksi transaksiController = new Transaksi();

        public InputTransaksi()
        {
            InitializeComponent();
            SetupInitialControls();
        }

        private void SetupInitialControls()
        {
            // Setup Jenis Service ComboBox
            cmbJenisService.Items.AddRange(new string[] {
                "Cuci Basah",
                "Cuci Kering",
                "Cuci Setrika"
            });

            dtpTanggalMasuk.Value = DateTime.Now;
            dtpTanggalSelesai.Value = DateTime.Now.AddDays(2);

            txtBeratTotal.TextChanged += txtBeratTotal_TextChanged;
            cmbJenisService.SelectedIndexChanged += cmbJenisService_SelectedIndexChanged;
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string namaPelanggan = txtNamaPelanggan.Text;
                string jenisPakaian = lstJenisPakaian.Text;
                double beratTotal = double.Parse(txtBeratTotal.Text);
                string jenisService = cmbJenisService.SelectedItem?.ToString() ?? "";
                DateTime tanggalMasuk = dtpTanggalMasuk.Value;
                DateTime tanggalSelesai = dtpTanggalSelesai.Value;
                bool setrikaUap = chkSetrikaUap.Checked;
                bool hanger = chkHanger.Checked;
                string metodePembayaran = rdoCash.Checked ? "Cash" : "Transfer";
                double totalHarga = double.Parse(txtTotalHarga.Text.Replace(",", ""));

                bool status = transaksiController.HandleInputTransaksi(
                    namaPelanggan, jenisPakaian, beratTotal, jenisService,
                    tanggalMasuk, tanggalSelesai, setrikaUap, hanger,
                    metodePembayaran, totalHarga);

                if (status)
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBeratTotal.Text))
            {
                MessageBox.Show("Berat total harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbJenisService.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih jenis service!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rdoCash.Checked && !rdoTransfer.Checked)
            {
                MessageBox.Show("Pilih metode pembayaran!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtNamaPelanggan.Clear();
            lstJenisPakaian.ClearSelected();
            txtBeratTotal.Clear();
            cmbJenisService.SelectedIndex = -1;
            dtpTanggalMasuk.Value = DateTime.Now;
            dtpTanggalSelesai.Value = DateTime.Now;
            chkSetrikaUap.Checked = false;
            chkHanger.Checked = false;
            rdoCash.Checked = false;
            rdoTransfer.Checked = false;
            txtTotalHarga.Clear();
        }

        private void txtBeratTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalHarga();
        }

        private void cmbJenisService_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalHarga();
        }

        private void CalculateTotalHarga()
        {
            if (!double.TryParse(txtBeratTotal.Text, out double berat))
                return;

            double hargaPerKg = 0;

            // Harga berdasarkan jenis service
            if (cmbJenisService.SelectedItem != null)
            {
                switch (cmbJenisService.SelectedItem.ToString())
                {
                    case "Cuci Basah":
                        hargaPerKg = 5000;
                        break;
                    case "Cuci Kering":
                        hargaPerKg = 7000;
                        break;
                    case "Cuci Setrika":
                        hargaPerKg = 10000;
                        break;
                }
            }

            double totalHarga = berat * hargaPerKg;

            // Tambahan biaya untuk layanan tambahan
            if (chkSetrikaUap.Checked)
                totalHarga += berat * 3000; // Tambahan Rp 3.000/kg untuk setrika uap

            if (chkHanger.Checked)
                totalHarga += 2000; // Tambahan Rp 2.000 untuk hanger

            txtTotalHarga.Text = totalHarga.ToString("N0");
        }

        private void txtTotalHarga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
