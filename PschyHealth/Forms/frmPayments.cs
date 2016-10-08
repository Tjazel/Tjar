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
using MetroFramework.Controls;

namespace PschyHealth.Forms
{
    public partial class frmPayments : MetroForm
    {
        Methods cMethods = new Methods();
        Boolean breaking = false;
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
            cMethods.fillCMBrow(cmbPaymentsClient_Name,cmbPaymentsClient_Surname, dgvPayments);
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
            breaking = true;
            cmbPaymentsClient_Name.Enabled = false;
            if (cmbPaymentsClient_Surname.Text == "")
            {
                cMethods.filterDGV(dgvPayments, "Clients", " WHERE First_Name = '" + cmbPaymentsClient_Name.Text + "'");
                cMethods.fillCMBrow(null, cmbPaymentsClient_Surname, dgvPayments);
                cMethods.filterDGV(dgvPayments, "Payments", " WHERE Client_Name = '" + cmbPaymentsClient_Name.Text+ "'");
                cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE Name = '" + cmbPaymentsClient_Name.Text + "'");


            }
            else
            {
                cMethods.filterDGV(dgvPayments, "Clients", " WHERE First_Name = '" + cmbPaymentsClient_Name.Text + "'AND  Surname = '" + cmbPaymentsClient_Surname.Text + "'");
                if(dgvPayments.RowCount <= 1)
                    cmbPaymentsClient_Surname.Text = "";
                else
                cMethods.filterDGV(dgvPayments, "Payments", " WHERE Client_Surname = '" + cmbPaymentsClient_Surname.Text + "'AND Client_Name = '" + cmbPaymentsClient_Name.Text + "'");
                cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE Surname = '" + cmbPaymentsClient_Surname.Text + "' AND Name = '" + cmbPaymentsClient_Name.Text + "'");
            }

        }

        private void dgvConsultations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String fields, values;
            cMethods.getFieldsAndValues(out fields, out values, groupBox1, "Payments");
            cMethods.add("Payments", fields, values);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvPayments, "Payments", false);
            btnAfbetaal.Enabled = false;
            //btnAfgeskryf.Enabled = false;
            //btnKortingAfbetaal.Enabled = false;
            button = "archive";
        }

        private void cmbPaymentsClient_Surname_SelectedIndexChanged(object sender, EventArgs e)
        {
            breaking = true;
            cmbPaymentsClient_Surname.Enabled = false;
            if (cmbPaymentsClient_Name.Text == "")
            {
                cMethods.filterDGV(dgvPayments, "Clients", " WHERE Surname = '" + cmbPaymentsClient_Surname.Text + "'");
                cMethods.fillCMBrow(cmbPaymentsClient_Name, null, dgvPayments);
                cMethods.filterDGV(dgvPayments, "Payments", " WHERE Client_Surname = '" + cmbPaymentsClient_Surname.Text + "'");
                cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE Surname = '" + cmbPaymentsClient_Surname.Text + "'");


            }
            else
            {
                cMethods.filterDGV(dgvPayments, "Clients", " WHERE First_Name = '" + cmbPaymentsClient_Name.Text + "'AND  Surname = '" + cmbPaymentsClient_Surname.Text + "'");
                if (dgvPayments.RowCount <= 1)
                    cmbPaymentsClient_Name.Text = "";
                cMethods.filterDGV(dgvPayments, "Payments", " WHERE Client_Surname = '" + cmbPaymentsClient_Surname.Text + "'AND Client_Name = '" + cmbPaymentsClient_Name.Text + "'");
                cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE Surname = '" + cmbPaymentsClient_Surname.Text + "' AND Name = '" + cmbPaymentsClient_Name.Text + "'");
            }
        }

        private void txtPaymentsConsultation_EnabledChanged(object sender, EventArgs e)
        {
            txtPaymentsConsultation.Enabled = false;
        }

        private void dgvConsultations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsultations.RowCount > 0)
            {
                if(breaking != true)
                    txtPaymentsConsultation.Text = dgvConsultations.Rows[dgvConsultations.SelectedRows[0].Index].Cells["Consultation"].Value.ToString();
            }
            breaking = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            breaking = true;
            cmbPaymentsClient_Name.Text = "";
            cmbPaymentsClient_Surname.Text = "";
            cmbPaymentsClient_Name.Enabled = true;
            cmbPaymentsClient_Surname.Enabled = true;
            cMethods.fillDGV(dgvPayments, "Clients");
            cMethods.fillCMBrow(cmbPaymentsClient_Name, cmbPaymentsClient_Surname, dgvPayments);
            cMethods.fillDGV(dgvPayments, "Payments");
            cMethods.fillDGV(dgvConsultations, "Consultations");
        }

        private void btnAfbetaal_Click(object sender, EventArgs e)
        {
            MetroGrid dgv = new MetroGrid();
            dgv.Parent = this;
            dgv.Hide();
            txtPaymentsAmount.Text = "" + cMethods.calculateAmount(txtPaymentsConsultation.Text, dgv);
        }
    }
}
