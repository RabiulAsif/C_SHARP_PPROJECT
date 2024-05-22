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
    public partial class ShowService : Form
    {
        public ShowService()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            new BookingSystem().Show();
            this.Hide();
        }
    }
}
