namespace FINALPROJECT
{
    partial class CustomerRegister
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
            label9 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            txtComPassword = new TextBox();
            txtPassword = new TextBox();
            textBox2 = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(172, 101);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 101;
            label9.Text = "Customer ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 144);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 39);
            textBox1.TabIndex = 100;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(209, 261);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 99;
            label8.Text = "Address";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(320, 312);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(261, 35);
            textBox6.TabIndex = 98;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(231, 322);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 97;
            label7.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(320, 251);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 35);
            textBox5.TabIndex = 96;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 128, 128);
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(382, 565);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 95;
            label6.Text = "Back to Login";
            label6.Click += label6_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(458, 462);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 27);
            checkBox1.TabIndex = 94;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(360, 506);
            button1.Name = "button1";
            button1.Size = new Size(174, 43);
            button1.TabIndex = 93;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtComPassword
            // 
            txtComPassword.Location = new Point(320, 421);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.Size = new Size(261, 35);
            txtComPassword.TabIndex = 92;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(320, 366);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 35);
            txtPassword.TabIndex = 91;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 199);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 35);
            textBox2.TabIndex = 90;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(320, 87);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(261, 39);
            txtUsername.TabIndex = 89;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 431);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 88;
            label5.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(197, 376);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 87;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 209);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 86;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 158);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 85;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 30);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 84;
            label1.Text = "Sign Up as CUSTOMER";
            // 
            // CustomerRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(921, 630);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(txtComPassword);
            Controls.Add(txtPassword);
            Controls.Add(textBox2);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerRegister";
            Text = "CustomerRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox txtComPassword;
        private TextBox txtPassword;
        private TextBox textBox2;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}