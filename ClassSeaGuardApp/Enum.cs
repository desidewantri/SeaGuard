using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSeaGuardApp
{
    // Status validasi laporan sampah
    public enum StatusValidasi
    {
        Menunggu,
        Valid,
        TidakValid
    }

    // Kategori sampah
    public enum KategoriSampah
    {
        Plastik,
        Logam,
        Kaca,
        Organik,
        Lainnya
    }
}
