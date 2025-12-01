using SeaGuard_Database.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaGuard_Database.Forms
{
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();
        }

        private void btnCard1_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Resources", "Modul_Sampah_Plastik.pdf");

            if (!File.Exists(pdfPath))
            {
                MessageBox.Show("File modul tidak ditemukan:\n" + pdfPath);
                return;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = pdfPath,
                UseShellExecute = true
            });
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Navigator.Go(this, new Home());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Resources", "Modul_Sampah_Plastik.pdf");

            if (!File.Exists(pdfPath))
            {
                MessageBox.Show("File modul tidak ditemukan:\n" + pdfPath);
                return;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = pdfPath,
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Resources", "Modul_Sampah_Plastik.pdf");

            if (!File.Exists(pdfPath))
            {
                MessageBox.Show("File modul tidak ditemukan:\n" + pdfPath);
                return;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = pdfPath,
                UseShellExecute = true
            });
        }
    }
}
