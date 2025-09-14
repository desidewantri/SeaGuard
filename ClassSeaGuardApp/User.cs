using ClassSeaGuardApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSeaGuardApp
{
    internal class User
    {
        // Instance variable
        private int _userID;
        private string _nama;
        private string _email;
        private string _password;

        // Property
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
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

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        // Method
        public bool Login(string email, string password)
        {
            // Dummy login
            if (email == "user@test.com" && password == "1234")
            {
                return true;
            }
            return false;
        }

        public void SignUp()
        {
            // Registrasi user
        }

        public void EditProfil()
        {
            // Edit data profil user
        }

        public LaporanSampah BuatLaporan()
        {
            // Membuat laporan sampah
            return new LaporanSampah();
        }

        public void LihatHeatmap()
        {
            // Melihat heatmap
        }

        public void AksesEdukasi()
        {
            // Mengakses modul edukasi
        }
    }
}
