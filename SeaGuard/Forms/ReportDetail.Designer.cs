namespace SeaGuard_Database.Forms
{
    partial class ReportDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextNotes = new TextBox();
            TextLongitude = new TextBox();
            TextLatitude = new TextBox();
            PictureMap = new PictureBox();
            PicturePhoto = new PictureBox();
            btnBack = new Button();
            btnDelete = new Button();
            btnPhoto = new Button();
            lblNotes = new Label();
            lblLongitude = new Label();
            lblLatitude = new Label();
            lblPhoto = new Label();
            lblCategory = new Label();
            DropdownCategory = new ComboBox();
            lblDetail = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).BeginInit();
            SuspendLayout();
            // 
            // TextNotes
            // 
            TextNotes.Location = new Point(181, 468);
            TextNotes.Multiline = true;
            TextNotes.Name = "TextNotes";
            TextNotes.Size = new Size(240, 140);
            TextNotes.TabIndex = 30;
            TextNotes.TextChanged += TextNotes_TextChanged;
            // 
            // TextLongitude
            // 
            TextLongitude.Location = new Point(181, 421);
            TextLongitude.Name = "TextLongitude";
            TextLongitude.Size = new Size(240, 31);
            TextLongitude.TabIndex = 29;
            TextLongitude.TextChanged += TextLongitude_TextChanged;
            // 
            // TextLatitude
            // 
            TextLatitude.Location = new Point(181, 375);
            TextLatitude.Name = "TextLatitude";
            TextLatitude.Size = new Size(240, 31);
            TextLatitude.TabIndex = 28;
            TextLatitude.TextChanged += TextLatitude_TextChanged;
            // 
            // PictureMap
            // 
            PictureMap.Location = new Point(471, 129);
            PictureMap.Name = "PictureMap";
            PictureMap.Size = new Size(503, 479);
            PictureMap.TabIndex = 27;
            PictureMap.TabStop = false;
            // 
            // PicturePhoto
            // 
            PicturePhoto.Location = new Point(181, 217);
            PicturePhoto.Name = "PicturePhoto";
            PicturePhoto.Size = new Size(240, 140);
            PicturePhoto.TabIndex = 26;
            PicturePhoto.TabStop = false;
            PicturePhoto.Click += PicturePhoto_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Location = new Point(824, 54);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 54);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back to List";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Location = new Point(181, 624);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 34);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnPhoto
            // 
            btnPhoto.BackColor = Color.White;
            btnPhoto.Location = new Point(181, 177);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(150, 34);
            btnPhoto.TabIndex = 23;
            btnPhoto.Text = "Choose photo";
            btnPhoto.UseVisualStyleBackColor = false;
            btnPhoto.Click += btnPhoto_Click_1;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(29, 471);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(63, 25);
            lblNotes.TabIndex = 22;
            lblNotes.Text = "Notes:";
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(28, 424);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(96, 25);
            lblLongitude.TabIndex = 21;
            lblLongitude.Text = "Longitude:";
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(29, 378);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(79, 25);
            lblLatitude.TabIndex = 20;
            lblLatitude.Text = "Latitude:";
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(28, 182);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(64, 25);
            lblPhoto.TabIndex = 19;
            lblPhoto.Text = "Photo:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(28, 132);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 25);
            lblCategory.TabIndex = 18;
            lblCategory.Text = "Category:";
            // 
            // DropdownCategory
            // 
            DropdownCategory.BackColor = Color.White;
            DropdownCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            DropdownCategory.FormattingEnabled = true;
            DropdownCategory.Location = new Point(181, 129);
            DropdownCategory.Name = "DropdownCategory";
            DropdownCategory.Size = new Size(182, 33);
            DropdownCategory.TabIndex = 17;
            DropdownCategory.SelectedIndexChanged += DropdownCategory_SelectedIndexChanged;
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetail.Location = new Point(28, 54);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(220, 45);
            lblDetail.TabIndex = 16;
            lblDetail.Text = "Report Detail";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Location = new Point(311, 624);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 34);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // ReportDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 712);
            Controls.Add(btnSave);
            Controls.Add(TextNotes);
            Controls.Add(TextLongitude);
            Controls.Add(TextLatitude);
            Controls.Add(PictureMap);
            Controls.Add(PicturePhoto);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnPhoto);
            Controls.Add(lblNotes);
            Controls.Add(lblLongitude);
            Controls.Add(lblLatitude);
            Controls.Add(lblPhoto);
            Controls.Add(lblCategory);
            Controls.Add(DropdownCategory);
            Controls.Add(lblDetail);
            Name = "ReportDetail";
            Text = "ReportDetail";
            ((System.ComponentModel.ISupportInitialize)PictureMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextNotes;
        private TextBox TextLongitude;
        private TextBox TextLatitude;
        private PictureBox PictureMap;
        private PictureBox PicturePhoto;
        private Button btnBack;
        private Button btnDelete;
        private Button btnPhoto;
        private Label lblNotes;
        private Label lblLongitude;
        private Label lblLatitude;
        private Label lblPhoto;
        private Label lblCategory;
        private ComboBox DropdownCategory;
        private Label lblDetail;
        private Button btnSave;
    }
}