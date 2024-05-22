namespace FINALPROJECT
{
    partial class AdminRegister
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
            label6 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            txtComPassword = new TextBox();
            txtPassword = new TextBox();
            Phone = new TextBox();
            AdminId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(413, 500);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 59;
            label6.Text = "Back to Login";
            label6.Click += label6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(500, 387);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 27);
            checkBox1.TabIndex = 58;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Fuchsia;
            button1.Location = new Point(392, 434);
            button1.Name = "button1";
            button1.Size = new Size(174, 43);
            button1.TabIndex = 57;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtComPassword
            // 
            txtComPassword.Location = new Point(348, 335);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.Size = new Size(261, 35);
            txtComPassword.TabIndex = 56;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(348, 271);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 35);
            txtPassword.TabIndex = 55;
            // 
            // Phone
            // 
            Phone.Location = new Point(348, 206);
            Phone.Multiline = true;
            Phone.Name = "Phone";
            Phone.Size = new Size(261, 35);
            Phone.TabIndex = 54;
            // 
            // AdminId
            // 
            AdminId.Location = new Point(348, 137);
            AdminId.Multiline = true;
            AdminId.Name = "AdminId";
            AdminId.Size = new Size(261, 39);
            AdminId.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(131, 334);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 52;
            label5.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 271);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 51;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 205);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 50;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 151);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 49;
            label2.Text = "Admin ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 0, 192);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(368, 58);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 48;
            label1.Text = "Sign Up as ADMIN";
            // 
            // AdminRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(949, 646);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(txtComPassword);
            Controls.Add(txtPassword);
            Controls.Add(Phone);
            Controls.Add(AdminId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminRegister";
            Text = "AdminRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox txtComPassword;
        private TextBox txtPassword;
        private TextBox Phone;
        private TextBox AdminId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}