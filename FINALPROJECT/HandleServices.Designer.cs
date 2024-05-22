namespace FINALPROJECT
{
    partial class HandleServices
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
            dataGridView1 = new DataGridView();
            btnShow = new Button();
            txtId = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(548, 298);
            dataGridView1.TabIndex = 1;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.LightGoldenrodYellow;
            btnShow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(172, 373);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(191, 42);
            btnShow.TabIndex = 2;
            btnShow.Text = "SHOW SERVICE";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(634, 226);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 39);
            txtId.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(598, 184);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 8;
            label1.Text = "REMOVE SERVICES BY ID";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Yellow;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(735, 439);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 38);
            btnBack.TabIndex = 7;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 128);
            btnRemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(598, 304);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(208, 44);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "REMOVE SERVICE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // HandleServices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(874, 511);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRemove);
            Controls.Add(btnShow);
            Controls.Add(dataGridView1);
            Name = "HandleServices";
            Text = "HandleServices";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnShow;
        private TextBox txtId;
        private Label label1;
        private Button btnBack;
        private Button btnRemove;
    }
}