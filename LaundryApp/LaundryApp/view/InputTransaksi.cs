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
        public InputTransaksi()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaPelanggan.Text) ||
        string.IsNullOrWhiteSpace(txtBeratTotal.Text) ||
        cmbJenisService.SelectedIndex == -1 ||
        dtpTanggalMasuk.Value == null ||
        dtpTanggalSelesai.Value == null ||
        string.IsNullOrWhiteSpace(txtTotalHarga.Text) ||
        (!rdoCash.Checked && !rdoTransfer.Checked))
            {
                MessageBox.Show("Mohon lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // SIMPAN DATA KE DATABASE ATAU LIST
            string namaPelanggan = txtNamaPelanggan.Text;
            string jenisPakaian = string.Join(", ", lstJenisPakaian.SelectedItems);
            double beratTotal = double.Parse(txtBeratTotal.Text);
            string jenisService = cmbJenisService.SelectedItem.ToString();
            DateTime tanggalMasuk = dtpTanggalMasuk.Value;
            DateTime tanggalSelesai = dtpTanggalSelesai.Value;
            bool setrikaUap = chkSetrikaUap.Checked;
            bool hanger = chkHanger.Checked;
            string metodePembayaran = rdoCash.Checked ? "Cash" : "Transfer";
            double totalHarga = double.Parse(txtTotalHarga.Text);

            MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form setelah input
            ResetForm();
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
            // Perhitungan otomatis untuk total harga
            if (double.TryParse(txtBeratTotal.Text, out double berat))
            {
                double hargaPerKg = 5000; // Harga per kg (contoh)
                txtTotalHarga.Text = (berat * hargaPerKg).ToString();
            }
        }
    }
}

