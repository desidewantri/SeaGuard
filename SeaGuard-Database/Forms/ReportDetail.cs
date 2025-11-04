using SeaGuard_Database.Data;
using SeaGuard_Database.Helpers;
using SeaGuard_Database.Models;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SeaGuard_Database.Forms
{
    public partial class ReportDetail : Form
    {
        private readonly ReportRepository _repo = new ReportRepository();
        private Report? _data; 

        public ReportDetail()
        {
            InitializeComponent();
            InitUi(); 
        }

        public ReportDetail(Report data) : this() 
        {
            _data = data;
            LoadToFields();
        }

        private void InitUi()
        {
            DropdownCategory.Items.AddRange(new object[]
            {
                "Oil Spill", "Plastic", "Fishing Net", "Chemical", "Other"
            });
            DropdownCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            if (PicturePhoto != null) PicturePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            if (PictureMap != null) PictureMap.SizeMode = PictureBoxSizeMode.Zoom;

            TextLatitude.KeyPress += OnlyNumberComma;
            TextLongitude.KeyPress += OnlyNumberComma;
        }

        private void LoadToFields()
        {
            if (_data == null) return;

            if (!string.IsNullOrWhiteSpace(_data.Category) &&
                DropdownCategory.Items.Contains(_data.Category))
                DropdownCategory.SelectedItem = _data.Category;
            else
                DropdownCategory.SelectedIndex = 0;

            TextLatitude.Text = _data.Latitude ?? "";
            TextLongitude.Text = _data.Longitude ?? "";
            TextNotes.Text = _data.Notes ?? "";

            var abs = ResolvePhotoAbsolute(_data.PhotoPath);
            PicturePhoto.ImageLocation = File.Exists(abs) ? abs : null;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(DropdownCategory.Text))
            {
                MessageBox.Show("Pilih kategori terlebih dahulu.");
                return false;
            }

            if (!double.TryParse(TextLatitude.Text.Replace(',', '.'),
                    NumberStyles.Float, CultureInfo.InvariantCulture, out var lat) ||
                !double.TryParse(TextLongitude.Text.Replace(',', '.'),
                    NumberStyles.Float, CultureInfo.InvariantCulture, out var lng))
            {
                MessageBox.Show("Latitude atau Longitude tidak valid.");
                return false;
            }

            return true;
        }

        private void OnlyNumberComma(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private static string? SavePhotoToApp(string? sourceFullPath)
        {
            if (string.IsNullOrWhiteSpace(sourceFullPath) || !File.Exists(sourceFullPath))
                return null;

            var baseDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "SeaGuard", "photos");
            Directory.CreateDirectory(baseDir);

            var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(sourceFullPath);
            var dest = Path.Combine(baseDir, fileName);
            File.Copy(sourceFullPath, dest, overwrite: false);
            return fileName;
        }

        private static string ResolvePhotoAbsolute(string? relativeOrAbsolute)
        {
            if (string.IsNullOrWhiteSpace(relativeOrAbsolute)) return "";
            if (Path.IsPathRooted(relativeOrAbsolute)) return relativeOrAbsolute;

            var baseDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "SeaGuard", "photos");
            return Path.Combine(baseDir, relativeOrAbsolute);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Navigator.Go(this, new Home());
        }

        private void DropdownCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPhoto_Click_1(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Choose photo",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var rel = SavePhotoToApp(ofd.FileName);
                if (_data != null)
                {
                    _data.PhotoPath = rel;
                    var abs = ResolvePhotoAbsolute(rel);
                    PicturePhoto.ImageLocation = abs;
                }
            }
        }

        private void PicturePhoto_Click(object sender, EventArgs e)
        {

        }

        private void TextLatitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextLongitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object? sender, EventArgs e)
        {
            if (_data == null || string.IsNullOrWhiteSpace(_data.Id))
            {
                MessageBox.Show("Data tidak valid.");
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus report ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _repo.Delete(_data.Id);
                    MessageBox.Show("Report berhasil dihapus.");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus report.\n" + ex.Message);
                }
            }
        }

        private void btnSave_Click_1(object? sender, EventArgs e)
        {
            if (_data == null)
            {
                MessageBox.Show("Data belum dimuat.");
                return;
            }

            if (!ValidateInputs()) return;

            _data.Category = DropdownCategory.Text;
            _data.Latitude = TextLatitude.Text.Trim();
            _data.Longitude = TextLongitude.Text.Trim();
            _data.Notes = TextNotes.Text.Trim();
            _data.Status = string.IsNullOrWhiteSpace(_data.Status) ? "Pending" : _data.Status;

            try
            {
                _repo.Update(_data);
                MessageBox.Show("Perubahan disimpan.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan perubahan.\n" + ex.Message);
            }
        }
    }
}
