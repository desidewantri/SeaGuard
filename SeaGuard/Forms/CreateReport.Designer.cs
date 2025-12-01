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
            lblCreate.Location = new Point(22, 26);
            lblCreate.Margin = new Padding(2, 0, 2, 0);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(197, 37);
            lblCreate.TabIndex = 0;
            lblCreate.Text = "Create Report";
            lblCreate.Click += lblCreate_Click;
            // 
            // DropdownCategory
            // 
            DropdownCategory.BackColor = Color.White;
            DropdownCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            DropdownCategory.FormattingEnabled = true;
            DropdownCategory.Location = new Point(144, 86);
            DropdownCategory.Margin = new Padding(2, 2, 2, 2);
            DropdownCategory.Name = "DropdownCategory";
            DropdownCategory.Size = new Size(146, 28);
            DropdownCategory.TabIndex = 1;
            DropdownCategory.SelectedIndexChanged += DropdownCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(22, 88);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(22, 128);
            lblPhoto.Margin = new Padding(2, 0, 2, 0);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(51, 20);
            lblPhoto.TabIndex = 3;
            lblPhoto.Text = "Photo:";
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(22, 285);
            lblLatitude.Margin = new Padding(2, 0, 2, 0);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(66, 20);
            lblLatitude.TabIndex = 4;
            lblLatitude.Text = "Latitude:";
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(22, 322);
            lblLongitude.Margin = new Padding(2, 0, 2, 0);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(79, 20);
            lblLongitude.TabIndex = 5;
            lblLongitude.Text = "Longitude:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(22, 359);
            lblNotes.Margin = new Padding(2, 0, 2, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(51, 20);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes:";
            // 
            // btnPhoto
            // 
            btnPhoto.BackColor = Color.White;
            btnPhoto.Location = new Point(144, 124);
            btnPhoto.Margin = new Padding(2, 2, 2, 2);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(120, 27);
            btnPhoto.TabIndex = 7;
            btnPhoto.Text = "Choose photo";
            btnPhoto.UseVisualStyleBackColor = false;
            btnPhoto.Click += btnPhoto_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSteelBlue;
            btnBack.Location = new Point(658, 26);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 43);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // PicturePhoto
            // 
            PicturePhoto.Location = new Point(144, 156);
            PicturePhoto.Margin = new Padding(2, 2, 2, 2);
            PicturePhoto.Name = "PicturePhoto";
            PicturePhoto.Size = new Size(192, 112);
            PicturePhoto.TabIndex = 11;
            PicturePhoto.TabStop = false;
            PicturePhoto.Click += PicturePhoto_Click;
            // 
            // TextLatitude
            // 
            TextLatitude.Location = new Point(144, 282);
            TextLatitude.Margin = new Padding(2, 2, 2, 2);
            TextLatitude.Name = "TextLatitude";
            TextLatitude.Size = new Size(193, 27);
            TextLatitude.TabIndex = 13;
            TextLatitude.TextChanged += TextLatitude_TextChanged;
            // 
            // TextLongitude
            // 
            TextLongitude.Location = new Point(144, 319);
            TextLongitude.Margin = new Padding(2, 2, 2, 2);
            TextLongitude.Name = "TextLongitude";
            TextLongitude.Size = new Size(193, 27);
            TextLongitude.TabIndex = 14;
            TextLongitude.TextChanged += TextLongitude_TextChanged;
            // 
            // TextNotes
            // 
            TextNotes.Location = new Point(144, 357);
            TextNotes.Margin = new Padding(2, 2, 2, 2);
            TextNotes.Multiline = true;
            TextNotes.Name = "TextNotes";
            TextNotes.Size = new Size(193, 113);
            TextNotes.TabIndex = 15;
            TextNotes.TextChanged += TextNotes_TextChanged;
            // 
            // PictureMap
            // 
            PictureMap.Location = new Point(376, 86);
            PictureMap.Margin = new Padding(2, 2, 2, 2);
            PictureMap.Name = "PictureMap";
            PictureMap.Size = new Size(402, 383);
            PictureMap.TabIndex = 12;
            PictureMap.TabStop = false;
            PictureMap.Click += PictureMap_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.White;
            btnSubmit.Location = new Point(144, 482);
            btnSubmit.Margin = new Padding(2, 2, 2, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(192, 27);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // CreateReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(802, 570);
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
            Margin = new Padding(2, 2, 2, 2);
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