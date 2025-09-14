using ClassSeaGuardApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSeaGuardApp
{
    internal class LaporanSampah
    {
        // Instance variable
        private int _laporanID;
        private string _foto;
        private KategoriSampah _kategori;
        private double _lat;
        private double _lon;
        private string _alamat;
        private StatusValidasi _statusValidasi;

        // Property
        public int LaporanID
        {
            get { return _laporanID; }
            set { _laporanID = value; }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public KategoriSampah Kategori
        {
            get { return _kategori; }
            set { _kategori = value; }
        }

        public double Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }

        public double Lon
        {
            get { return _lon; }
            set { _lon = value; }
        }

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public StatusValidasi StatusValidasi
        {
            get { return _statusValidasi; }
            set { _statusValidasi = value; }
        }

        // Method
        public void TampilkanLaporan()
        {
            // Menampilkan laporan
        }

        public void SetStatus(StatusValidasi status)
        {
            _statusValidasi = status;
        }
    }
}
