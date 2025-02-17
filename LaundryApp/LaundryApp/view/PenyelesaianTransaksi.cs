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
    public partial class PenyelesaianTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        public PenyelesaianTransaksi()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataGridViewPenyelesaianTransaksi.DataSource = koneksi.ShowData("SELECT * FROM t_transaksi");
        }
        private void PenyelesaianTransaksi_Load(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}
