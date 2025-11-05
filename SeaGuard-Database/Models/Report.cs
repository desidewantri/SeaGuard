using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaGuard_Database.Models
{
    public class Report
    {
        public string? Id { get; set; } = "";
        public string? Category { get; set; }
        public virtual string GetSummary()
        {
            return $"Kategori: {Category}";
        }
        public string? PhotoPath { get; set; } = string.Empty;
        public string? Latitude { get; set; } = string.Empty;
        public string? Longitude { get; set; } = string.Empty;
        public string? Notes { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public class PlasticReport : Report
        {
            public override string GetSummary()
            {
                return $"[Plastic Report] Laporan terkait sampah plastik di laut.";
            }
        }

        public class OilSpillReport : Report
        {
            public override string GetSummary()
            {
                return $"[Oil Spill Report] Laporan kebocoran minyak di perairan.";
            }
        }

        public class FishingNetReport : Report
        {
            public override string GetSummary()
            {
                return $"[Fishing Net Report] Laporan jaring nelayan yang terdampar.";
            }
        }

        public class ChemicalReport : Report
        {
            public override string GetSummary()
            {
                return $"[Chemical Report] Laporan bahan kimia berbahaya di laut.";
            }
        }

        public class OtherReport : Report
        {
            public override string GetSummary()
            {
                return $"[Other Report] Laporan kategori umum lainnya.";
            }
        }
    }

}
