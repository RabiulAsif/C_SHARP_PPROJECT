using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECT
{
    public partial class ConfirmPayment : Form
    {
        public ConfirmPayment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string transactionId = txtTransactionId.Text;
            int amount;

            // Parse the amount value
            if (!int.TryParse(txtTransactionId.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            // Create a connection string
            string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";

            // SQL query to insert data into the TRANSACTION2 table
            string sqlQuery = $"INSERT INTO TRANSACTION2 (transaction_id, amount) VALUES ('{transactionId}', {amount})";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlCommand using the SQL query and SqlConnection
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Thank you for your patience!");
                        new Confirm().Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new BookingSystem().Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
