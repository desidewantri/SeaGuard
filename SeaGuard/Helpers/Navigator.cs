using System;
using System.Windows.Forms;

namespace SeaGuard_Database.Helpers
{
    public static class Navigator
    {
        // Bisa kembali, misal Login -> Registration, Home -> CreateReport
        public static void Go(Form from, Form to)
        {
            to.StartPosition = FormStartPosition.CenterScreen;
            to.FormClosed += (s, e) => from.Show();
            from.Hide();
            to.Show();
        }

        // Satu arah, misal Login -> Home
        public static void GoAndClose(Form from, Form to)
        {
            to.StartPosition = FormStartPosition.CenterScreen;
            to.FormClosed += (s, e) => from.Close();
            from.Hide();
            to.Show();
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
