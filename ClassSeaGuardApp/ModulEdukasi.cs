using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSeaGuardApp
{
    internal class ModulEdukasi
    {
        // Instance variable
        private int _modulID;
        private string _judul;
        private string _konten;

        // Property
        public int ModulID
        {
            get { return _modulID; }
            set { _modulID = value; }
        }

        public string Judul
        {
            get { return _judul; }
            set { _judul = value; }
        }

        public string Konten
        {
            get { return _konten; }
            set { _konten = value; }
        }

        // Method
        public void AksesModul()
        {
            // User mengakses modul edukasi
        }

        public void UploadModul()
        {
            // Admin upload modul edukasi
        }
    }
}
