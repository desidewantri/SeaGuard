using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSeaGuardApp
{
    internal class Heatmap
    {
        // Instance variable
        private int _heatmapID;
        private string _lokasi;
        private int _intensitas;

        // Property
        public int HeatmapID
        {
            get { return _heatmapID; }
            set { _heatmapID = value; }
        }

        public string Lokasi
        {
            get { return _lokasi; }
            set { _lokasi = value; }
        }

        public int Intensitas
        {
            get { return _intensitas; }
            set { _intensitas = value; }
        }

        // Method
        public void UpdateHeatmap()
        {
            // Update data heatmap
        }

        public void TampilkanHeatmap()
        {
            // Menampilkan heatmap
        }
    }
}
