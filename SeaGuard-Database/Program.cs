namespace SeaGuard_Database
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                using var conn = Data.DbConnection.GetConnection();
                conn.Open();
                MessageBox.Show("Koneksi PostgreSQL berhasil!", "Success");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal konek ke database:\n{ex.Message}", "Error");
                return;
            }

            Application.Run(new Forms.Home());
        }
    }
}