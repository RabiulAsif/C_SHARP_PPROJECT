namespace FINALPROJECT
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            panel1 = new Panel();
            btn_logout = new Button();
            btn_review = new Button();
            btn_about = new Button();
            btn_contact = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_services = new Button();
            btn_list_Company = new Button();
            btn_booking = new Button();
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
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 445);
            panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.OrangeRed;
            btn_logout.Location = new Point(72, 380);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(103, 43);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_review
            // 
            btn_review.Location = new Point(49, 303);
            btn_review.Name = "btn_review";
            btn_review.Size = new Size(154, 29);
            btn_review.TabIndex = 5;
            btn_review.Text = "Reviews";
            btn_review.UseVisualStyleBackColor = true;
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.White;
            btn_about.Location = new Point(49, 255);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(154, 29);
            btn_about.TabIndex = 4;
            btn_about.Text = "About Us";
            btn_about.UseVisualStyleBackColor = false;
            btn_about.Click += btn_about_Click;
            // 
            // btn_contact
            // 
            btn_contact.BackColor = Color.RoyalBlue;
            btn_contact.Location = new Point(49, 205);
            btn_contact.Name = "btn_contact";
            btn_contact.Size = new Size(154, 29);
            btn_contact.TabIndex = 3;
            btn_contact.Text = "Contact Us";
            btn_contact.UseVisualStyleBackColor = false;
            btn_contact.Click += btn_contact_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 128);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(23, 19);
            label2.Name = "label2";
            label2.Size = new Size(213, 23);
            label2.TabIndex = 1;
            label2.Text = "IT-CARE GUARDIANS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_services);
            panel2.Controls.Add(btn_list_Company);
            panel2.Controls.Add(btn_booking);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(268, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 445);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 330);
            label5.Name = "label5";
            label5.Size = new Size(239, 19);
            label5.TabIndex = 6;
            label5.Text = "3. OUR PROVIDED SERVICES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 210);
            label4.Name = "label4";
            label4.Size = new Size(253, 19);
            label4.TabIndex = 5;
            label4.Text = "2. LIST OF SERVICE COMPANY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 107);
            label3.Name = "label3";
            label3.Size = new Size(236, 19);
            label3.TabIndex = 4;
            label3.Text = "1. BOOK FOR SERVICE NOW";
            // 
            // btn_services
            // 
            btn_services.BackColor = Color.BlueViolet;
            btn_services.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_services.Location = new Point(267, 303);
            btn_services.Name = "btn_services";
            btn_services.Size = new Size(155, 72);
            btn_services.TabIndex = 3;
            btn_services.Text = "SERVICES";
            btn_services.UseVisualStyleBackColor = false;
            btn_services.Click += btn_services_Click;
            // 
            // btn_list_Company
            // 
            btn_list_Company.BackColor = Color.YellowGreen;
            btn_list_Company.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_list_Company.Location = new Point(267, 183);
            btn_list_Company.Name = "btn_list_Company";
            btn_list_Company.Size = new Size(155, 72);
            btn_list_Company.TabIndex = 2;
            btn_list_Company.Text = "COMPANIES";
            btn_list_Company.UseVisualStyleBackColor = false;
            btn_list_Company.Click += btn_list_Company_Click;
            // 
            // btn_booking
            // 
            btn_booking.BackColor = Color.Orange;
            btn_booking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_booking.Location = new Point(267, 80);
            btn_booking.Name = "btn_booking";
            btn_booking.Size = new Size(155, 72);
            btn_booking.TabIndex = 1;
            btn_booking.Text = "BOOKING";
            btn_booking.UseVisualStyleBackColor = false;
            btn_booking.Click += btn_booking_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 0;
            label1.Text = "HOME PAGE";
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button btn_review;
        private Button btn_about;
        private Button btn_contact;
        private Button btn_services;
        private Button btn_list_Company;
        private Button btn_booking;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}