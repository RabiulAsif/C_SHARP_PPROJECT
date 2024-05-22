namespace FINALPROJECT
{
    partial class OfflinePay
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
            label1 = new Label();
            label3 = new Label();
            btn_duePayment = new Button();
            btn_exit = new Button();
            txtId = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(324, 60);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 9;
            label1.Text = "PAYMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(200, 142);
            label3.Name = "label3";
            label3.Size = new Size(414, 20);
            label3.TabIndex = 15;
            label3.Text = "*Your Payment Is Due As You Have Chosen To Pay Later..";
            // 
            // btn_duePayment
            // 
            btn_duePayment.BackColor = Color.Orange;
            btn_duePayment.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_duePayment.Location = new Point(264, 263);
            btn_duePayment.Name = "btn_duePayment";
            btn_duePayment.Size = new Size(281, 40);
            btn_duePayment.TabIndex = 16;
            btn_duePayment.Text = "See Due Payment";
            btn_duePayment.UseVisualStyleBackColor = false;
            btn_duePayment.Click += btn_duePayment_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Red;
            btn_exit.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(324, 334);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(140, 45);
            btn_exit.TabIndex = 17;
            btn_exit.Text = "EXIT";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(361, 207);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 207);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 19;
            label2.Text = "Provide ID";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(665, 393);
            button1.Name = "button1";
            button1.Size = new Size(99, 33);
            button1.TabIndex = 20;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OfflinePay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btn_exit);
            Controls.Add(btn_duePayment);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "OfflinePay";
            Text = "OfflinePay";
            Load += OfflinePay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btn_duePayment;
        private Button btn_exit;
        private TextBox txtId;
        private Label label2;
        private Button button1;
    }
}