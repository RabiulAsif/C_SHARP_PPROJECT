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
    public partial class CompanyRegister : Form
    {
        public CompanyRegister()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) ||
           string.IsNullOrEmpty(txtUsername.Text) ||
           string.IsNullOrEmpty(textBox2.Text) ||
           string.IsNullOrEmpty(textBox5.Text) ||
           string.IsNullOrEmpty(textBox1.Text) ||
           string.IsNullOrEmpty(txtPassword.Text) ||
           string.IsNullOrEmpty(txtComPassword.Text))
            {
                MessageBox.Show("One or more required fields are empty", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7LKR989;Initial Catalog=ITCAREGUARDIANS;Integrated Security=True;");

                connection.Open();

                string register = "INSERT INTO COMPANY (company_id, company_phone, company_address, company_email, company_password, company_balance, company_rating, typework_id, company_name) VALUES('" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox5.Text + "', '" + textBox1.Text + "', '" + txtPassword.Text + "', NULL, NULL, NULL, '" + txtUsername.Text + "')";

                SqlCommand cmd = new SqlCommand(register, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                textBox3.Text = "";
                txtUsername.Text = "";
                textBox2.Text = "";
                textBox5.Text = "";
                textBox1.Text = "";
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

        private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
