using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PschyHealth.Forms
{
    public partial class frmPayments : MetroForm
    {
        Methods cMethods = new Methods();
        String correctSearch = "";
        String button = "";
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        frmMainPage _frmMainpage = new frmMainPage();

        public frmPayments()
        {
            InitializeComponent();
            this.StyleManager = msmPayments;
        }

        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmPayments);

            /*
            //Load the Form At Position of Main Form
            int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
            int HeightofMain = Application.OpenForms["frmMainPage"].Height;
            int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
            int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            this.Location = new Point(LocationMainX, locationMainy + 30);
             */

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);
            this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

            cMethods.fillDGV(dgvPayments, "Clients");
            cMethods.fillCMBrow(cmbClient,dgvPayments);
            cMethods.fillDGV(dgvPayments, "Payments");
            cMethods.fillDGV(dgvConsultations, "Consultations");

        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPayments_Method_Of_Payments_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            cMethods.filterDGV(dgvPayments, "Payments", " WHERE Client_Surname = '" + cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) + "' AND Client_Name = '" + cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2) + "'");
            cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE Surname = '" + cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) + "' AND Name = '" + cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2) + "'");
        }

        private void dgvConsultations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
       //     txtConsultation.Text = dgvConsultations.Rows[dgvConsultations.SelectedRows[0].Index].Cells["Consultation"].Value.ToString();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvPayments, "Payments", false);
            btnAfbetaal.Enabled = false;
            btnAfgeskryf.Enabled = false;
            btnKortingAfbetaal.Enabled = false;
            button = "archive";
        }
    }
}
