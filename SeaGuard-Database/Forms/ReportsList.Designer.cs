namespace SeaGuard_Database.Forms
{
    partial class ReportsList
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
            lblList = new Label();
            btnBack = new Button();
            dgvReports = new DataGridView();
            btnDetail = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.Location = new Point(27, 32);
            lblList.Name = "lblList";
            lblList.Size = new Size(197, 45);
            lblList.TabIndex = 1;
            lblList.Text = "Reports List";
            lblList.Click += lblList_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Location = new Point(823, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 54);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(27, 110);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 62;
            dgvReports.Size = new Size(946, 510);
            dgvReports.TabIndex = 12;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.White;
            btnDetail.Location = new Point(27, 637);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(150, 34);
            btnDetail.TabIndex = 13;
            btnDetail.Text = "View Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Location = new Point(823, 637);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 34);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ReportsList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 712);
            Controls.Add(btnRefresh);
            Controls.Add(btnDetail);
            Controls.Add(dgvReports);
            Controls.Add(btnBack);
            Controls.Add(lblList);
            Name = "ReportsList";
            Text = "ReportsList";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblList;
        private Button btnBack;
        private DataGridView dgvReports;
        private Button btnDetail;
        private Button btnRefresh;
    }
}