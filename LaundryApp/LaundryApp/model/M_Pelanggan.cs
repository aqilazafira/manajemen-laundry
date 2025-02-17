using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryApp.model
{
    internal class M_Pelanggan
    {
        string nama, nohp, tanggal_daftar;

        public M_Pelanggan()
        {

        }

        public M_Pelanggan(string nama, string nohp, string tanggal_daftar)
        {
            this.Nama = nama;
            this.Nohp = nohp;
            this.Tanggal_daftar = tanggal_daftar;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Nohp { get => nohp; set => nohp = value; }
        public string Tanggal_daftar { get => tanggal_daftar; set => tanggal_daftar = value; }
    }
}
