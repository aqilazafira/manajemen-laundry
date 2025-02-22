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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonInputTransaksi_Click(object sender, EventArgs e)
        {
            InputTransaksi inptr = new InputTransaksi();
            this.Hide();
            inptr.Show();
        }

        private void buttonDataTransaksi_Click(object sender, EventArgs e)
        {
            DataTransaksi dt = new DataTransaksi();
            this.Hide();
            dt.Show();
        }

        private void buttonDataPelanggan_Click(object sender, EventArgs e)
        {
            DataPelanggan dp = new DataPelanggan();
            this.Hide();
            dp.Show();
        }

        private void buttonInputPelanggan_Click(object sender, EventArgs e)
        {
            InputPelanggan ip = new InputPelanggan();
            this.Hide();
            ip.Show();
        }

        private void buttonPenyelesaianTransaksi_Click(object sender, EventArgs e)
        {
            PenyelesaianTransaksi pt = new PenyelesaianTransaksi();
            this.Hide();
            pt.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
