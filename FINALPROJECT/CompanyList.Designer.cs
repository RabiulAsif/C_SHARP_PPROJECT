﻿namespace FINALPROJECT
{
    partial class CompanyList
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 31);
            label1.Name = "label1";
            label1.Size = new Size(257, 23);
            label1.TabIndex = 0;
            label1.Text = "LIST OF OUR COMPANIES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 106);
            label2.Name = "label2";
            label2.Size = new Size(359, 28);
            label2.TabIndex = 1;
            label2.Text = "1. DataSoft Systems Bangladesh LTD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(207, 154);
            label3.Name = "label3";
            label3.Size = new Size(183, 28);
            label3.TabIndex = 2;
            label3.Text = "2. South-Tech LTD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(207, 205);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 3;
            label4.Text = "3. BD Tasks LTD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(207, 253);
            label5.Name = "label5";
            label5.Size = new Size(266, 28);
            label5.TabIndex = 4;
            label5.Text = "4. Tiger-IT Bangladesh LTD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(207, 303);
            label6.Name = "label6";
            label6.Size = new Size(279, 28);
            label6.TabIndex = 5;
            label6.Text = "5. Dream71 Bangladesh LTD";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(338, 378);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CompanyList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CompanyList";
            Text = "CompanyList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}