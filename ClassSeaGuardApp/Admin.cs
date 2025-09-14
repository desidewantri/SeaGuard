using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSeaGuardApp
{
    internal class Admin
    {
        // Instance variable
        private int _adminID;
        private string _nama;
        private string _email;

        // Property
        public int AdminID
        {
            get { return _adminID; }
            set { _adminID = value; }
        }

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Method
        public void VerifikasiLaporan()
        {
            // Verifikasi laporan dari user
        }

        public void KelolaDataPengguna()
        {
            // Kelola akun user
        }

        public void KelolaKontenEdukasi()
        {
            // Kelola modul edukasi
        }

        public void KelolaHeatmap()
        {
            // Kelola data heatmap
        }

        public void KirimNotifikasi()
        {
            // Kirim notifikasi
        }
    }
}
