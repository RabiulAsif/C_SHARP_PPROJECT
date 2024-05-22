using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FINALPROJECT
{
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminId.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("One or more required fields are empty", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtComPassword.Text)
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;");

                connection.Open();

                string register = "INSERT INTO ADMIN (admin_id, admin_phone, admin_password) VALUES('" + AdminId.Text + "', '" + Phone.Text + "', '" + txtPassword.Text + "')";


                SqlCommand cmd = new SqlCommand(register, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                AdminId.Text = "";
                Phone.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }
    }
}
