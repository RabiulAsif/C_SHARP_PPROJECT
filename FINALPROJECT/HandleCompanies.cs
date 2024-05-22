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
    public partial class HandleCompanies : Form
    {
        public HandleCompanies()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";
            string query = "SELECT TOP (1000) [company_id], [company_phone], [company_address], [company_email], [company_password], [company_balance], [company_rating], [typework_id], [company_name] FROM [ITCAREGUARDIANS].[dbo].[COMPANY]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to hold the company data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                // Attempt to parse txtId text to an integer
                if (int.TryParse(txtId.Text, out int companyId))
                {
                    // Query to delete the company with the specified company_id
                    string connectionString = "Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;";
                    string query = "DELETE FROM COMPANY WHERE company_id = @CompanyId";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CompanyId", companyId);

                            // Execute the DELETE query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Company deleted successfully", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView to reflect the changes
                                btnShow_Click(sender, e); // Call the btnShow_Click function to refresh the data
                            }
                            else
                            {
                                MessageBox.Show("No company found with the provided ID", "Company Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid company ID", "Invalid Company ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a company ID", "Missing Company ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
