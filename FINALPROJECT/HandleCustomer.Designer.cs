namespace FINALPROJECT
{
    partial class HandleCustomer
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
            btnshow = new Button();
            btnRemove = new Button();
            txtId = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(541, 271);
            dataGridView1.TabIndex = 0;
            // 
            // btnshow
            // 
            btnshow.BackColor = Color.GreenYellow;
            btnshow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnshow.Location = new Point(160, 379);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(150, 39);
            btnshow.TabIndex = 1;
            btnshow.Text = "SHOW USER";
            btnshow.UseVisualStyleBackColor = false;
            btnshow.Click += btnshow_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 128);
            btnRemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(569, 306);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(169, 49);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "REMOVE USER";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(569, 213);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(154, 40);
            txtId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(569, 178);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 4;
            label1.Text = "REMOVE USER BY ID";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Yellow;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(725, 419);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(99, 37);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // HandleCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(836, 482);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnRemove);
            Controls.Add(btnshow);
            Controls.Add(dataGridView1);
            Name = "HandleCustomer";
            Text = "HandleCustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnshow;
        private Button btnRemove;
        private TextBox txtId;
        private Label label1;
        private Button btnBack;
    }
}