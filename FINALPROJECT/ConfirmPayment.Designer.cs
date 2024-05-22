namespace FINALPROJECT
{
    partial class ConfirmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPayment));
            panel1 = new Panel();
            btn_logout = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            btn_back = new Button();
            btn_OK = new Button();
            txtTransactionId = new TextBox();
            label7 = new Label();
            txtMoney = new TextBox();
            label6 = new Label();
            label5 = new Label();
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
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 452);
            panel1.TabIndex = 2;
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
            panel2.Controls.Add(btn_OK);
            panel2.Controls.Add(txtTransactionId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtMoney);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(279, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 452);
            panel2.TabIndex = 3;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Yellow;
            btn_back.Location = new Point(390, 403);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(95, 29);
            btn_back.TabIndex = 22;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_OK
            // 
            btn_OK.BackColor = Color.Gold;
            btn_OK.Location = new Point(206, 401);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(83, 32);
            btn_OK.TabIndex = 21;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = false;
            btn_OK.Click += btn_OK_Click;
            // 
            // txtTransactionId
            // 
            txtTransactionId.Location = new Point(130, 350);
            txtTransactionId.Name = "txtTransactionId";
            txtTransactionId.Size = new Size(240, 27);
            txtTransactionId.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(148, 314);
            label7.Name = "label7";
            label7.Size = new Size(200, 23);
            label7.TabIndex = 19;
            label7.Text = "Provide Transaction ID :";
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(130, 272);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(240, 27);
            txtMoney.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(130, 231);
            label6.Name = "label6";
            label6.Size = new Size(240, 23);
            label6.TabIndex = 17;
            label6.Text = "Transaction Money Amount :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(206, 117);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 16;
            label5.Text = "Phone No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 156);
            label4.Name = "label4";
            label4.Size = new Size(199, 35);
            label4.TabIndex = 15;
            label4.Text = "017712334567";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(69, 80);
            label3.Name = "label3";
            label3.Size = new Size(361, 20);
            label3.TabIndex = 14;
            label3.Text = "*Pay In The Number That Has Provided For You....";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(148, 24);
            label1.Name = "label1";
            label1.Size = new Size(208, 23);
            label1.TabIndex = 13;
            label1.Text = "CONFIRM  PAYMENT";
            // 
            // ConfirmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ConfirmPayment";
            Text = "ConfirmPayment";
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
        private Button btn_review;
        private Button btn_about;
        private Button btn_contact;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox tb_transactionMoney;
        private TextBox txtTransactionId;
        private Label label7;
        private TextBox txtMoney;
        private Button btn_OK;
        private Button btn_back;
    }
}