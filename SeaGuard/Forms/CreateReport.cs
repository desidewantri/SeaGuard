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
    public partial class CreateReport : Form
    {
        private string? _photoPath = null;

        public CreateReport()
        {
            InitializeComponent();

            DropdownCategory.Items.AddRange(new object[]
            {
                "Oil Spill", "Plastic", "Fishing Net", "Chemical", "Other"
            });
            DropdownCategory.SelectedIndex = 0;

            if (PictureMap != null) PictureMap.SizeMode = PictureBoxSizeMode.Zoom;
            if (PicturePhoto != null) PicturePhoto.SizeMode = PictureBoxSizeMode.Zoom;

            TextLatitude.KeyPress += OnlyNumberComma;
            TextLongitude.KeyPress += OnlyNumberComma;
        }

        private void lblCreate_Click(object sender, EventArgs e) { } 

        private void DropdownCategory_SelectedIndexChanged(object sender, EventArgs e) { } 

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Choose photo",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _photoPath = ofd.FileName;
                if (File.Exists(_photoPath))
                {
                    PicturePhoto.ImageLocation = _photoPath;
                }
            }
        }

        private void PicturePhoto_Click(object sender, EventArgs e) { }
        private void TextLatitude_TextChanged(object sender, EventArgs e) { }
        private void TextLongitude_TextChanged(object sender, EventArgs e) { }
        private void TextNotes_TextChanged(object sender, EventArgs e) { }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string? relativePhoto = SavePhotoToApp(_photoPath);

                var repo = new ReportRepository();
                repo.Insert(
                    DropdownCategory.Text,
                    relativePhoto ?? "",
                    TextLatitude.Text.Trim(),
                    TextLongitude.Text.Trim(),
                    TextNotes.Text.Trim()
                );

                MessageBox.Show("Report tersimpan");
                Navigator.Go(this, new Forms.ReportsList()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan. " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigator.Go(this, new Forms.Home());
        }

        private void PictureMap_Click(object sender, EventArgs e) { }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(DropdownCategory.Text))
            {
                MessageBox.Show("Pilih kategori.");
                DropdownCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TextLatitude.Text) || string.IsNullOrWhiteSpace(TextLongitude.Text))
            {
                MessageBox.Show("Isi latitude dan longitude.");
                TextLatitude.Focus();
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
            var tb = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',' && tb != null && tb.Text.Contains(','))
                e.Handled = true;
        }

        private void ClearForm()
        {
            DropdownCategory.SelectedIndex = 0;
            TextLatitude.Clear();
            TextLongitude.Clear();
            TextNotes.Clear();
            _photoPath = null;
            PictureMap.ImageLocation = null;
            PicturePhoto.Image = null;
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
    }
}