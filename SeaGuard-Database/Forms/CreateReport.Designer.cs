namespace SeaGuard_Database.Forms
{
    partial class CreateReport
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
            lblCreate = new Label();
            DropdownCategory = new ComboBox();
            lblCategory = new Label();
            lblPhoto = new Label();
            lblLatitude = new Label();
            lblLongitude = new Label();
            lblNotes = new Label();
            btnPhoto = new Button();
            btnBack = new Button();
            PicturePhoto = new PictureBox();
            TextLatitude = new TextBox();
            TextLongitude = new TextBox();
            TextNotes = new TextBox();
            PictureMap = new PictureBox();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureMap).BeginInit();
            SuspendLayout();
            // 
            // lblCreate
            // 
            lblCreate.AutoSize = true;
            lblCreate.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.Location = new Point(27, 32);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(228, 45);
            lblCreate.TabIndex = 0;
            lblCreate.Text = "Create Report";
            lblCreate.Click += lblCreate_Click;
            // 
            // DropdownCategory
            // 
            DropdownCategory.BackColor = Color.White;
            DropdownCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            DropdownCategory.FormattingEnabled = true;
            DropdownCategory.Location = new Point(180, 107);
            DropdownCategory.Name = "DropdownCategory";
            DropdownCategory.Size = new Size(182, 33);
            DropdownCategory.TabIndex = 1;
            DropdownCategory.SelectedIndexChanged += DropdownCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(27, 110);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 25);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(27, 160);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(64, 25);
            lblPhoto.TabIndex = 3;
            lblPhoto.Text = "Photo:";
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(28, 356);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(79, 25);
            lblLatitude.TabIndex = 4;
            lblLatitude.Text = "Latitude:";
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(27, 402);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(96, 25);
            lblLongitude.TabIndex = 5;
            lblLongitude.Text = "Longitude:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(28, 449);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(63, 25);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes:";
            // 
            // btnPhoto
            // 
            btnPhoto.BackColor = Color.White;
            btnPhoto.Location = new Point(180, 155);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(150, 34);
            btnPhoto.TabIndex = 7;
            btnPhoto.Text = "Choose photo";
            btnPhoto.UseVisualStyleBackColor = false;
            btnPhoto.Click += btnPhoto_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Location = new Point(823, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 54);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PicturePhoto
            // 
            PicturePhoto.Location = new Point(180, 195);
            PicturePhoto.Name = "PicturePhoto";
            PicturePhoto.Size = new Size(240, 140);
            PicturePhoto.TabIndex = 11;
            PicturePhoto.TabStop = false;
            PicturePhoto.Click += PicturePhoto_Click;
            // 
            // TextLatitude
            // 
            TextLatitude.Location = new Point(180, 353);
            TextLatitude.Name = "TextLatitude";
            TextLatitude.Size = new Size(240, 31);
            TextLatitude.TabIndex = 13;
            TextLatitude.TextChanged += TextLatitude_TextChanged;
            // 
            // TextLongitude
            // 
            TextLongitude.Location = new Point(180, 399);
            TextLongitude.Name = "TextLongitude";
            TextLongitude.Size = new Size(240, 31);
            TextLongitude.TabIndex = 14;
            TextLongitude.TextChanged += TextLongitude_TextChanged;
            // 
            // TextNotes
            // 
            TextNotes.Location = new Point(180, 446);
            TextNotes.Multiline = true;
            TextNotes.Name = "TextNotes";
            TextNotes.Size = new Size(240, 140);
            TextNotes.TabIndex = 15;
            TextNotes.TextChanged += TextNotes_TextChanged;
            // 
            // PictureMap
            // 
            PictureMap.Location = new Point(470, 107);
            PictureMap.Name = "PictureMap";
            PictureMap.Size = new Size(503, 479);
            PictureMap.TabIndex = 12;
            PictureMap.TabStop = false;
            PictureMap.Click += PictureMap_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.White;
            btnSubmit.Location = new Point(180, 602);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(240, 34);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // CreateReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 712);
            Controls.Add(TextNotes);
            Controls.Add(TextLongitude);
            Controls.Add(TextLatitude);
            Controls.Add(PictureMap);
            Controls.Add(PicturePhoto);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(btnPhoto);
            Controls.Add(lblNotes);
            Controls.Add(lblLongitude);
            Controls.Add(lblLatitude);
            Controls.Add(lblPhoto);
            Controls.Add(lblCategory);
            Controls.Add(DropdownCategory);
            Controls.Add(lblCreate);
            Name = "CreateReport";
            Text = "CreateReport";
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreate;
        private ComboBox DropdownCategory;
        private Label lblCategory;
        private Label lblPhoto;
        private Label lblLatitude;
        private Label lblLongitude;
        private Label lblNotes;
        private Button btnPhoto;
        private Button btnBack;
        private PictureBox PicturePhoto;
        private TextBox TextLatitude;
        private TextBox TextLongitude;
        private TextBox TextNotes;
        private PictureBox PictureMap;
        private Button btnSubmit;
    }
}