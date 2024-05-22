namespace FINALPROJECT
{
    partial class CompanyDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyDashboard));
            label1 = new Label();
            btn_manage_service = new Button();
            btn_logOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(548, 36);
            label1.Name = "label1";
            label1.Size = new Size(250, 35);
            label1.TabIndex = 0;
            label1.Text = "X-Y-Z COMPANY";
            // 
            // btn_manage_service
            // 
            btn_manage_service.BackColor = Color.Orange;
            btn_manage_service.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_manage_service.Location = new Point(355, 163);
            btn_manage_service.Name = "btn_manage_service";
            btn_manage_service.Size = new Size(368, 54);
            btn_manage_service.TabIndex = 1;
            btn_manage_service.Text = "Manage Services";
            btn_manage_service.UseVisualStyleBackColor = false;
            btn_manage_service.Click += btn_manage_service_Click;
            // 
            // btn_logOut
            // 
            btn_logOut.BackColor = Color.Red;
            btn_logOut.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logOut.Location = new Point(461, 279);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(123, 54);
            btn_logOut.TabIndex = 2;
            btn_logOut.Text = "Log Out";
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // CompanyDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(854, 482);
            Controls.Add(btn_logOut);
            Controls.Add(btn_manage_service);
            Controls.Add(label1);
            Name = "CompanyDashboard";
            Text = "CompanyDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_manage_service;
        private Button btn_logOut;
    }
}