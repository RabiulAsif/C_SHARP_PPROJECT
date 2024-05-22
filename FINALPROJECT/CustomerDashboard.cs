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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
            this.Hide();
        }

        private void btn_list_Company_Click(object sender, EventArgs e)
        {
            new CompanyList().Show();
            this.Hide();
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            new Services().Show();
            this.Hide();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            new ContactUs().Show();
            this.Hide();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            new BookingSystem().Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
