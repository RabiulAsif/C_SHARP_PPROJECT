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
    public partial class OfflinePay : Form
    {
        public OfflinePay()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_duePayment_Click(object sender, EventArgs e)
        {
            int typeworkId;
            if (!int.TryParse(txtId.Text, out typeworkId))
            {
                MessageBox.Show("Please enter a valid typework_id.");
                return;
            }

            // Create a connection string
            string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";

            // SQL query to select the price based on typework_id
            string sqlQuery = $"SELECT TOP (1) [price] FROM [ITCAREGUARDIANS].[dbo].[TYPEWORK] WHERE [typework_id] = {typeworkId}";

            // Variable to store the price
            string price;

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

                        // Execute the command and get the price
                        price = (string)command.ExecuteScalar();

                        // Show the price in a message box
                        MessageBox.Show($"The price for typework_id {typeworkId} is: {price}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Hide();
        }

        private void OfflinePay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Payment().Show();
            this.Hide();
        }
    }
}
