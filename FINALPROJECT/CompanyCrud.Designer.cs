namespace FINALPROJECT
{
    partial class CompanyCrud
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
            btnUpload = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            txtId = new TextBox();
            txtWork1 = new TextBox();
            txtWork2 = new TextBox();
            txtWork3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnShow = new Button();
            txtPrice = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(616, 351);
            dataGridView1.TabIndex = 0;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(128, 128, 255);
            btnUpload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(509, 377);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(121, 46);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(681, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 46);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 128, 255);
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(843, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 45);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 128);
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(411, 535);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 45);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 40);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(192, 42);
            txtId.TabIndex = 5;
            // 
            // txtWork1
            // 
            txtWork1.Location = new Point(126, 130);
            txtWork1.Multiline = true;
            txtWork1.Name = "txtWork1";
            txtWork1.Size = new Size(192, 42);
            txtWork1.TabIndex = 6;
            // 
            // txtWork2
            // 
            txtWork2.Location = new Point(126, 224);
            txtWork2.Multiline = true;
            txtWork2.Name = "txtWork2";
            txtWork2.Size = new Size(192, 42);
            txtWork2.TabIndex = 7;
            // 
            // txtWork3
            // 
            txtWork3.Location = new Point(126, 321);
            txtWork3.Multiline = true;
            txtWork3.Name = "txtWork3";
            txtWork3.Size = new Size(192, 42);
            txtWork3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 54);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 10;
            label2.Text = "WORK1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 238);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 11;
            label3.Text = "WORK2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 335);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 12;
            label4.Text = "WORK3";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(128, 128, 255);
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(632, 450);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(216, 56);
            btnShow.TabIndex = 13;
            btnShow.Text = "SHOW DATA";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(126, 408);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(192, 42);
            txtPrice.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 422);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 15;
            label5.Text = "PRICE";
            // 
            // CompanyCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(973, 621);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(btnShow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWork3);
            Controls.Add(txtWork2);
            Controls.Add(txtWork1);
            Controls.Add(txtId);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnUpload);
            Controls.Add(dataGridView1);
            Name = "CompanyCrud";
            Text = "CompanyCrud";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUpload;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private TextBox txtId;
        private TextBox txtWork1;
        private TextBox txtWork2;
        private TextBox txtWork3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnShow;
        private TextBox txtPrice;
        private Label label5;
    }
}