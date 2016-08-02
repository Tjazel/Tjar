using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PschyHealth
{
    public partial class pnlMyWorkPlace : UserControl
    {
        public pnlMyWorkPlace()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients clients = new frmClients();
            clients.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            staff.Show();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            frmAccounting Accounting = new frmAccounting();
            Accounting.Show();
        }

        private void pnlMyWorkPlace_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            btnDate.Text = Convert.ToString(today);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {

        }
    }
}
