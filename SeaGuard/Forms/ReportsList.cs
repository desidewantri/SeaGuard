using System;
using System.Data;
using System.Windows.Forms;
using SeaGuard_Database.Data;
using SeaGuard_Database.Helpers;
using SeaGuard_Database.Models;

namespace SeaGuard_Database.Forms
{
    public partial class ReportsList : Form
    {
        private readonly ReportRepository _repo = new ReportRepository();

        public ReportsList()
        {
            InitializeComponent();
            this.Load += ReportsList_Load;
            dgvReports.CellDoubleClick += dgvReports_CellDoubleClick;
        }

        // --- Event Handler Pemuatan Data (Memperbaiki error CS0103) ---
        private void ReportsList_Load(object? sender, EventArgs e)
        {
            try
            {
                DataTable dt = _repo.SelectAll();
                dgvReports.AutoGenerateColumns = true;
                dgvReports.DataSource = dt;

                dgvReports.ReadOnly = true;
                dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReports.MultiSelect = false;
                dgvReports.RowHeadersVisible = false;
                dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void lblList_Click(object sender, EventArgs e) { } // Ditemukan di Designer.cs Anda

        // --- Tombol Kembali ke Home ---
        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Home());
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e) { } // Ditemukan di Designer.cs Anda

        // --- Tombol Detail Report ---
        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReports.CurrentRow == null)
                {
                    MessageBox.Show("Pilih satu baris terlebih dahulu.");
                    return;
                }

                // Logika Fallback mengambil data (dari ID atau DataBoundItem)
                Report? data = null;
                var row = dgvReports.CurrentRow;

                if (row.DataBoundItem is Report reportModel)
                {
                    data = reportModel;
                }
                else
                {
                    string id = row.Cells["id"]?.Value?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(id))
                    {
                        data = _repo.GetById(id);
                    }
                }

                if (data == null)
                {
                    MessageBox.Show("Data tidak ditemukan di database.");
                    return;
                }

                // Membuka Form ReportDetail
                using var f = new ReportDetail(data); // Menggunakan constructor yang menerima data
                f.ShowDialog();

                // Refresh data setelah form detail ditutup
                ReportsList_Load(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuka detail: " + ex.Message);
            }
        }

        // --- Tombol Refresh ---
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ReportsList_Load(this, EventArgs.Empty);
                MessageBox.Show("Data berhasil diperbarui.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message);
            }
        }

        // Double Click pada baris tabel akan memanggil tombol Detail
        private void dgvReports_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnDetail_Click(this, EventArgs.Empty);
        }
    }
}