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
    public partial class BookingSystem : Form
    {
        public BookingSystem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;"))
            {
                connection.Open();

                // Retrieve values from text boxes
                string customerID = txtCustomerid.Text;
                string typeworkID = txtTypeworkid.Text;

                // Define the SQL query to insert data into the BOOKING table
                string query = "INSERT INTO BOOKING (customer_id, typework_id) VALUES (@CustomerID, @TypeworkID)";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@TypeworkID", typeworkID);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the data was inserted successfully
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thanks for CONFIRM Order!");
                        MessageBox.Show("Please pay the Order for further process!");

                        // Create an instance of the Payment form
                        new Payment().Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Failed to save data.");
                    }
                }
            }

            // Clear text boxes after saving data
            txtCustomerid.Text = "";
            txtTypeworkid.Text = "";
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            new ShowService().Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Hide();
        }
    }
}
