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

        private void lblList_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Home());
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReports.CurrentRow == null)
                {
                    MessageBox.Show("Pilih satu baris terlebih dahulu.");
                    return;
                }

                string id = dgvReports.CurrentRow.Cells["id"]?.Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("ID tidak valid atau tidak ditemukan.");
                    return;
                }

                Report? data = _repo.GetById(id);
                if (data == null)
                {
                    MessageBox.Show("Data tidak ditemukan di database.");
                    return;
                }

                var detail = new ReportDetail();
                detail.StartPosition = FormStartPosition.CenterScreen;

                this.Hide();
                detail.FormClosed += (_, __) =>
                {
                    this.Show();
                    DataTable dt = _repo.SelectAll();
                    dgvReports.DataSource = dt;
                };
                detail.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuka detail: " + ex.Message);
            }
            var row = dgvReports.CurrentRow;
            if (row == null) return;

            var report = row.DataBoundItem as Report;
            if (report == null) return;

            using var f = new ReportDetail(report);
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = _repo.SelectAll();
                dgvReports.DataSource = dt;
                MessageBox.Show("Data berhasil diperbarui.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message);
            }
        }

        private void dgvReports_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnDetail_Click(this, EventArgs.Empty);
        }
    }
}
