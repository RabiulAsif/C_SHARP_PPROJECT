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
    public partial class CompanyCrud : Form
    {
        public CompanyCrud()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";

            // Get the values from text boxes
            int typework_id = int.Parse(txtId.Text); // Assuming txtId contains the typework_id value
            string work1 = txtWork1.Text;
            string work2 = txtWork2.Text;
            string work3 = txtWork3.Text;
            string price = txtPrice.Text; // Assuming txtPrice contains the price value

            // SQL query to insert data
            string sqlQuery = $"INSERT INTO [ITCAREGUARDIANS].[dbo].[TYPEWORK] ([typework_id], [work1], [work2], [work3], [price]) " +
                              $"VALUES ({typework_id}, '{work1}', '{work2}', '{work3}', '{price}');";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlCommand using the SQL query and SqlConnection
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the SQL query
                    cmd.ExecuteNonQuery();

                    // Display a message box indicating that the information has been saved
                    MessageBox.Show("Information Uploaded!");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";

            // Get the values from text boxes
            int typework_id = int.Parse(txtId.Text); // Assuming txtId contains the typework_id value
            string work1 = txtWork1.Text;
            string work2 = txtWork2.Text;
            string work3 = txtWork3.Text;
            string price = txtPrice.Text; // Assuming txtPrice contains the price value

            // SQL query to update data
            string sqlQuery = $"UPDATE [ITCAREGUARDIANS].[dbo].[TYPEWORK] " +
                              $"SET [work1] = '{work1}', [work2] = '{work2}', [work3] = '{work3}', [price] = '{price}' " +
                              $"WHERE [typework_id] = {typework_id};";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlCommand using the SQL query and SqlConnection
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the SQL query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        // Display a message box indicating that the information has been updated
                        MessageBox.Show("Information Updated!");
                    }
                    else
                    {
                        // Display a message box indicating that no rows were updated
                        MessageBox.Show("No information updated.");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";

            // Get the typework_id of the row to delete (assuming typework_id is stored in txtId)
            int typework_id = int.Parse(txtId.Text);

            // SQL query to delete data
            string sqlQuery = $"DELETE FROM [ITCAREGUARDIANS].[dbo].[TYPEWORK] WHERE [typework_id] = {typework_id};";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlCommand using the SQL query and SqlConnection
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the SQL query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        // Display a message box indicating that the information has been deleted
                        MessageBox.Show("Information Deleted!");
                    }
                    else
                    {
                        // Display a message box indicating that no rows were deleted
                        MessageBox.Show("No information deleted.");
                    }
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";

            // SQL query to select data
            string sqlQuery = "SELECT * FROM [ITCAREGUARDIANS].[dbo].[TYPEWORK]";

            // Create a new DataTable to store the data
            DataTable dataTable = new DataTable();

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SqlDataAdapter using the SQL query and SqlConnection
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                {
                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);
                }
            }

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new CompanyDashboard().Show();
            this.Hide();
        }
    }
}
