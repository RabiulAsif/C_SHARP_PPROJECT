using System.Data.SqlClient;

namespace FINALPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if both username and password fields are filled
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username/email and password", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user is an admin
            if (IsValidAdmin(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Admin login successful!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed with admin functionality
                new AdminDashboard().Show();
                this.Hide();
            }
            // Check if the user is a customer
            else if (IsValidCustomer(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Customer login successful!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed with customer functionality
                new CustomerDashboard().Show();
                this.Hide();
            }
            // Check if the user is a company
            else if (IsValidCompany(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Company login successful!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed with company functionality
                new CompanyDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username/email or password", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to validate admin login
        private bool IsValidAdmin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM ADMIN WHERE admin_id = @Username AND admin_password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Function to validate customer login
        private bool IsValidCustomer(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CUSTOMER WHERE customer_phone = @Username AND customer_password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Function to validate company login
        private bool IsValidCompany(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM COMPANY WHERE company_id = @Username AND company_password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
               
            }
            else
            {
                txtPassword.PasswordChar = '•';
             
            }
        }
    }
}
