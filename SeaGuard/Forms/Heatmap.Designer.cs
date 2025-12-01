namespace SeaGuard_Database.Forms
{
    partial class Heatmap
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button7 = new Button();
            label5 = new Label();
            label6 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 101);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 25);
            label2.TabIndex = 2;
            label2.Text = "Peta Persebaran Sampah Laut";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(405, 38);
            label1.TabIndex = 1;
            label1.Text = "Peta Persebaran Sampah Laut";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 32);
            label3.TabIndex = 3;
            label3.Text = "Filter Kategori";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(14, 159);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(921, 54);
            button1.TabIndex = 4;
            button1.Text = "Plastik";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(15, 220);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(920, 46);
            button2.TabIndex = 5;
            button2.Text = "Logam";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Location = new Point(14, 285);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(921, 50);
            button3.TabIndex = 6;
            button3.Text = "Kaca";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Chartreuse;
            button4.Location = new Point(15, 360);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(920, 45);
            button4.TabIndex = 7;
            button4.Text = "Organik";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Plum;
            button5.Location = new Point(14, 428);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(921, 45);
            button5.TabIndex = 8;
            button5.Text = "Jarik";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Orange;
            button6.Location = new Point(14, 496);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(921, 49);
            button6.TabIndex = 9;
            button6.Text = "Lainnya";
            button6.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 549);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 30);
            label4.TabIndex = 10;
            label4.Text = "Filter Tanggal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 584);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(920, 31);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 631);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 101);
            panel2.TabIndex = 12;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.InactiveCaption;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(791, 41);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(176, 36);
            button7.TabIndex = 3;
            button7.Text = "Lihat Detail";
            button7.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(399, 52);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 2;
            label5.Text = "Laporan Ditampilkan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(462, 12);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 38);
            label6.TabIndex = 1;
            label6.Text = "15";
            label6.Click += label6_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Location = new Point(823, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 54);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // Heatmap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1000, 732);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Heatmap";
            Text = "Heatmap";
            Load += heatmap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label4;
        private TextBox textBox1;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Button button7;
        private Button btnBack;
    }
}