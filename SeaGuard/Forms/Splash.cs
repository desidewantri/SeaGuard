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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Shown += SplashScreen_Shown;
        }

        private async void SplashScreen_Shown(object sender, EventArgs e)
        {
            await Task.Delay(2000);

            var login = new Login();

            login.FormClosed += (s, args) => this.Close();

            this.Hide();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
