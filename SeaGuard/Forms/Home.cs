using SeaGuard_Database.Helpers;
using System;
using System.Windows.Forms;

namespace SeaGuard_Database.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // --- Tombol Create Report ---
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new CreateReport());
        }

        // --- Tombol Report List ---
        private void btnList_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new ReportsList());
        }

        // --- Tombol Heatmap ---
        private void btnHeatmap_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Heatmap());
        }

        // --- Tombol Modul Edukasi ---
        private void btnEducation_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Education());
        }

        // --- Tombol Profile ---
        private void btnProfile_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Profile());
        }

        // --- Tombol Logout ---
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e) { }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}