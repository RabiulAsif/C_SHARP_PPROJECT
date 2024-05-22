using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECT
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminRegister().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CompanyRegister().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerRegister().Show();
            this.Hide();
        }
    }
}
