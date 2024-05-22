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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_bkash_Click(object sender, EventArgs e)
        {
            new ConfirmPayment().Show();
            this.Hide();
        }

        private void btn_nagad_Click(object sender, EventArgs e)
        {
            new ConfirmPayment().Show();
            this.Hide();
        }

        private void btn_offline_Click(object sender, EventArgs e)
        {
            new OfflinePay().Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new CustomerDashboard().Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
