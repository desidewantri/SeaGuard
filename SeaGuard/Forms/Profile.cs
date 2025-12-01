using SeaGuard_Database.Data;
using SeaGuard_Database.Helpers;
using SeaGuard_Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SeaGuard_Database.Forms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void profile_Load(object sender, EventArgs e) { }
        private void tabPage9_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Login());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Home());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
