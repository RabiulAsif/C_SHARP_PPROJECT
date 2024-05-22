namespace FINALPROJECT
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            panel1 = new Panel();
            btn_logout = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            btn_back = new Button();
            btn_offline = new Button();
            btn_nagad = new Button();
            btn_bkash = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 452);
            panel1.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.OrangeRed;
            btn_logout.Location = new Point(73, 396);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(103, 43);
            btn_logout.TabIndex = 12;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 128);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(25, 24);
            label2.Name = "label2";
            label2.Size = new Size(213, 23);
            label2.TabIndex = 7;
            label2.Text = "IT-CARE GUARDIANS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(btn_back);
            panel2.Controls.Add(btn_offline);
            panel2.Controls.Add(btn_nagad);
            panel2.Controls.Add(btn_bkash);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(267, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 452);
            panel2.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Yellow;
            btn_back.Location = new Point(402, 396);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(103, 36);
            btn_back.TabIndex = 21;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_offline
            // 
            btn_offline.BackColor = Color.Silver;
            btn_offline.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_offline.Location = new Point(245, 271);
            btn_offline.Name = "btn_offline";
            btn_offline.Size = new Size(143, 66);
            btn_offline.TabIndex = 16;
            btn_offline.Text = "OFFLINE";
            btn_offline.UseVisualStyleBackColor = false;
            btn_offline.Click += btn_offline_Click;
            // 
            // btn_nagad
            // 
            btn_nagad.BackColor = Color.DarkOrange;
            btn_nagad.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nagad.Location = new Point(245, 173);
            btn_nagad.Name = "btn_nagad";
            btn_nagad.Size = new Size(143, 66);
            btn_nagad.TabIndex = 14;
            btn_nagad.Text = "NAGAD";
            btn_nagad.UseVisualStyleBackColor = false;
            btn_nagad.Click += btn_nagad_Click;
            // 
            // btn_bkash
            // 
            btn_bkash.BackColor = Color.Magenta;
            btn_bkash.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bkash.Location = new Point(245, 80);
            btn_bkash.Name = "btn_bkash";
            btn_bkash.Size = new Size(143, 66);
            btn_bkash.TabIndex = 13;
            btn_bkash.Text = "B-KASH";
            btn_bkash.UseVisualStyleBackColor = false;
            btn_bkash.Click += btn_bkash_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 308);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 12;
            label6.Text = "3. Pay In Cash";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 197);
            label4.Name = "label4";
            label4.Size = new Size(141, 19);
            label4.TabIndex = 10;
            label4.Text = "2. Pay with Nagad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 104);
            label3.Name = "label3";
            label3.Size = new Size(140, 19);
            label3.TabIndex = 9;
            label3.Text = "1. Pay with Bkash";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(208, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 8;
            label1.Text = "PAYMENT";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Payment";
            Text = "Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_logout;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button btn_bkash;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button btn_nagad;
        private Button btn_offline;
        private Button btn_back;
    }
}