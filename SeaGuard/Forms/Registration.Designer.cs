namespace SeaGuard_Database.Forms
{
    partial class Registration
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
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            btnRegister = new Button();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 0, 20);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(txtConfirmPassword);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-12, 158);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 682);
            panel2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(52, 152, 219);
            linkLabel1.Location = new Point(376, 511);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(251, 30);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sudah punya akun? Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(54, 334);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(915, 31);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.FromArgb(70, 70, 70);
            label6.Location = new Point(54, 281);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 25);
            label6.TabIndex = 7;
            label6.Text = "Konfirmasi Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 229);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(915, 31);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(70, 70, 70);
            label5.Location = new Point(54, 186);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(54, 419);
            btnRegister.Margin = new Padding(4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(916, 74);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 135);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(915, 31);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(70, 70, 70);
            label4.Location = new Point(54, 95);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(54, 58);
            txtFullName.Margin = new Padding(4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(915, 31);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(70, 70, 70);
            label3.Location = new Point(54, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 0;
            label3.Text = "Nama Lengkap";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -6);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 241);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(394, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(268, 25);
            label2.TabIndex = 0;
            label2.Text = "Bergabunglah dengan SeaGuard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 54);
            label1.TabIndex = 0;
            label1.Text = "Registrasi Akun";
            label1.Click += label1_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 824);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Registration";
            Text = "Registration";
            Load += Registrasiakun_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnRegister;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}