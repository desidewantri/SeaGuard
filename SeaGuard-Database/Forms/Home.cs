using SeaGuard_Database.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaGuard_Database.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new CreateReport());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new ReportsList());
        }

        private void btnHeatmap_Click(object sender, EventArgs e)
        {

        }

        private void btnEducation_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
