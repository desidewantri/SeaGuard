namespace SeaGuard_Database.Forms
{
    partial class Login
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
            btnRegister = new Button();
            linkLabelForgotPassword = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
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
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(linkLabelForgotPassword);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-9, 161);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 610);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(52, 152, 219);
            btnRegister.Location = new Point(56, 460);
            btnRegister.Margin = new Padding(4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(855, 50);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Registrasi Akun Baru";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLabelForgotPassword
            // 
            linkLabelForgotPassword.AutoSize = true;
            linkLabelForgotPassword.Cursor = Cursors.Hand;
            linkLabelForgotPassword.Font = new Font("Segoe UI", 10F);
            linkLabelForgotPassword.LinkColor = Color.FromArgb(52, 152, 219);
            linkLabelForgotPassword.Location = new Point(412, 402);
            linkLabelForgotPassword.Margin = new Padding(4, 0, 4, 0);
            linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            linkLabelForgotPassword.Size = new Size(149, 28);
            linkLabelForgotPassword.TabIndex = 5;
            linkLabelForgotPassword.TabStop = true;
            linkLabelForgotPassword.Text = "Lupa Password?";
            linkLabelForgotPassword.LinkClicked += linkLabelForgotPassword_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(56, 321);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(855, 62);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(56, 241);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(854, 31);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(70, 70, 70);
            label4.Location = new Point(56, 184);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(56, 131);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(854, 31);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(70, 70, 70);
            label3.Location = new Point(56, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 0;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 178);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(316, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 25);
            label2.TabIndex = 0;
            label2.Text = "Aplikasi Edukasi dan Pelaporan Sampah Laut";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 54);
            label1.TabIndex = 0;
            label1.Text = "SeaGuard";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 764);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(70, 70, 70);
            Margin = new Padding(4);
            Name = "Login";
            Text = "login";
            Load += Login_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private Button btnLogin;
        private LinkLabel linkLabelForgotPassword;
        private Button btnRegister;
    }
}