namespace SeaGuard_Database.Forms
{
    partial class Home
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
            lblHome = new Label();
            btnCreate = new Button();
            btnList = new Button();
            btnHeatmap = new Button();
            btnEducation = new Button();
            btnProfile = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(27, 32);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(356, 54);
            lblHome.TabIndex = 0;
            lblHome.Text = "SeaGuard - Home";
            lblHome.Click += lblHome_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.White;
            btnCreate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(27, 125);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(300, 70);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create Report";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.White;
            btnList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnList.Location = new Point(27, 242);
            btnList.Name = "btnList";
            btnList.Size = new Size(300, 70);
            btnList.TabIndex = 2;
            btnList.Text = "Reports List";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnHeatmap
            // 
            btnHeatmap.BackColor = Color.White;
            btnHeatmap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeatmap.Location = new Point(27, 359);
            btnHeatmap.Name = "btnHeatmap";
            btnHeatmap.Size = new Size(300, 70);
            btnHeatmap.TabIndex = 3;
            btnHeatmap.Text = "Heatmap";
            btnHeatmap.UseVisualStyleBackColor = false;
            btnHeatmap.Click += btnHeatmap_Click;
            // 
            // btnEducation
            // 
            btnEducation.BackColor = Color.White;
            btnEducation.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEducation.Location = new Point(27, 476);
            btnEducation.Name = "btnEducation";
            btnEducation.Size = new Size(300, 70);
            btnEducation.TabIndex = 4;
            btnEducation.Text = "Education";
            btnEducation.UseVisualStyleBackColor = false;
            btnEducation.Click += btnEducation_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.White;
            btnProfile.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(27, 593);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(300, 70);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Location = new Point(823, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 54);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1002, 712);
            Controls.Add(btnLogout);
            Controls.Add(btnProfile);
            Controls.Add(btnEducation);
            Controls.Add(btnHeatmap);
            Controls.Add(btnList);
            Controls.Add(btnCreate);
            Controls.Add(lblHome);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHome;
        private Button btnCreate;
        private Button btnList;
        private Button btnHeatmap;
        private Button btnEducation;
        private Button btnProfile;
        private Button btnLogout;
    }
}