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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Hide();
        }
    }
}
