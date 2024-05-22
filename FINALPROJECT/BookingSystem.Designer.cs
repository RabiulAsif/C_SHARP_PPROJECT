namespace FINALPROJECT
{
    partial class BookingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingSystem));
            panel1 = new Panel();
            btn_logout = new Button();
            btn_review = new Button();
            btn_about = new Button();
            btn_contact = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            btnService = new Button();
            label4 = new Label();
            btnback = new Button();
            btnconfirm = new Button();
            txtTypeworkid = new TextBox();
            label6 = new Label();
            txtCustomerid = new TextBox();
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
            panel1.Controls.Add(btn_review);
            panel1.Controls.Add(btn_about);
            panel1.Controls.Add(btn_contact);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 452);
            panel1.TabIndex = 0;
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
            // 
            // btn_review
            // 
            btn_review.Location = new Point(51, 308);
            btn_review.Name = "btn_review";
            btn_review.Size = new Size(154, 29);
            btn_review.TabIndex = 11;
            btn_review.Text = "Reviews";
            btn_review.UseVisualStyleBackColor = true;
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.White;
            btn_about.Location = new Point(51, 260);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(154, 29);
            btn_about.TabIndex = 10;
            btn_about.Text = "About Us";
            btn_about.UseVisualStyleBackColor = false;
            // 
            // btn_contact
            // 
            btn_contact.BackColor = Color.RoyalBlue;
            btn_contact.Location = new Point(51, 210);
            btn_contact.Name = "btn_contact";
            btn_contact.Size = new Size(154, 29);
            btn_contact.TabIndex = 9;
            btn_contact.Text = "Contact Us";
            btn_contact.UseVisualStyleBackColor = false;
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
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(btnService);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnback);
            panel2.Controls.Add(btnconfirm);
            panel2.Controls.Add(txtTypeworkid);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCustomerid);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(264, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 452);
            panel2.TabIndex = 1;
            // 
            // btnService
            // 
            btnService.BackColor = Color.FromArgb(128, 255, 255);
            btnService.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnService.Location = new Point(235, 96);
            btnService.Name = "btnService";
            btnService.Size = new Size(113, 38);
            btnService.TabIndex = 22;
            btnService.Text = "SERVICES";
            btnService.UseVisualStyleBackColor = false;
            btnService.Click += btnService_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 111);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 21;
            label4.Text = "See Available Services";
            // 
            // btnback
            // 
            btnback.BackColor = Color.Yellow;
            btnback.Location = new Point(399, 396);
            btnback.Name = "btnback";
            btnback.Size = new Size(97, 43);
            btnback.TabIndex = 20;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnconfirm
            // 
            btnconfirm.BackColor = Color.Chartreuse;
            btnconfirm.Location = new Point(220, 396);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(103, 43);
            btnconfirm.TabIndex = 19;
            btnconfirm.Text = "CONFIRM";
            btnconfirm.UseVisualStyleBackColor = false;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // txtTypeworkid
            // 
            txtTypeworkid.Location = new Point(235, 285);
            txtTypeworkid.Multiline = true;
            txtTypeworkid.Name = "txtTypeworkid";
            txtTypeworkid.Size = new Size(173, 37);
            txtTypeworkid.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(103, 302);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 15;
            label6.Text = "Typework ID";
            // 
            // txtCustomerid
            // 
            txtCustomerid.Location = new Point(235, 217);
            txtCustomerid.Multiline = true;
            txtCustomerid.Name = "txtCustomerid";
            txtCustomerid.Size = new Size(173, 37);
            txtCustomerid.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 234);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 9;
            label3.Text = "Enter Your ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(206, 24);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 8;
            label1.Text = "BOOKINGS";
            // 
            // BookingSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BookingSystem";
            Text = "BookingSystem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_logout;
        private Button btn_review;
        private Button btn_about;
        private Button btn_contact;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtCustomerid;
        private Label label6;
        private Button btnconfirm;
        private TextBox txtTypeworkid;
        private Button btnback;
        private Label label4;
        private Button btnService;
    }
}