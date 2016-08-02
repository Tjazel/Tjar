using MetroFramework.Forms;
using PschyHealth.Forms;
using PschyHealth.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PschyHealth
{
    public partial class frmMainPage : MetroForm
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
          //  pnlMyWorkPlace myWorkplace = new pnlMyWorkPlace();
          //  myWorkplace.Dock = DockStyle.Fill;
           // this.Controls.Add(myWorkplace);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlSettings pnlSettings = new pnlSettings(this);
            pnlSettings.swipe(true);
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ctxMenu.Show(pictureBox2, 0, pictureBox1.Height);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            pnlAccounting pnlAccounting = new pnlAccounting(this);
            pnlAccounting.swipe(true);
        }

        private void btnMedicalAids_Click(object sender, EventArgs e)
        {
            pnlMedicalAids pnlMedicalAids = new pnlMedicalAids(this);
            pnlMedicalAids.swipe(true);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnlStaff pnlStaff = new pnlStaff(this);
            pnlStaff.swipe(true);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlClients pnlClients = new pnlClients(this);
            pnlClients.swipe(true);
        }

        private void btnStatements_Click(object sender, EventArgs e)
        {
            pnlStatements pnlStatements = new pnlStatements(this);
            pnlStatements.swipe(true);
        }

        private void btnConsultations_Click(object sender, EventArgs e)
        {
            pnlConsultation pnlConsultation = new pnlConsultation(this);
            pnlConsultation.swipe(true);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmMainPage main = new frmMainPage();
            main.Show();
        }

        private void btnEDIfunctions_Click(object sender, EventArgs e)
        {
            pnlEDICodes pnlEDICodes = new pnlEDICodes(this);
            pnlEDICodes.swipe(true);
        }
    }
}
