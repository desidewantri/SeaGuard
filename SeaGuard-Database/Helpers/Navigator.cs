using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaGuard_Database.Helpers
{
    public static class Navigator
    {
        public static void Go(Form from, Form to)
        {
            to.StartPosition = FormStartPosition.CenterScreen;
            to.Show();
            from.Hide();
            to.FormClosed += (s, e) => from.Show();
        }
    }

    public class BaseForm : Form
    {
        protected void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
