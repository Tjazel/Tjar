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
    public partial class frmDiagnosticCodes : MetroForm
    {
        String button;
        Methods cMethods = new Methods();
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public frmDiagnosticCodes()
        {
            InitializeComponent();
            this.StyleManager = msmDiagnostic;
        }

        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmDiagnostic);
            cMethods.readStyle(msmDiagnostic);
           
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
            cMethods.fillDGV(metroGrid1, "DiagnosticCodes");
            
        }

        private void frmDiagnosticCodes_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox2,metroGrid1,"ConsultationRates",false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox2, metroGrid1, "ConsultationRates", true, true);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
           // btnArchive.Enabled = false;
            metroGrid1.Enabled = false;
            button = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox2, metroGrid1, "ConsultationRates", true, false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
           // btnArchive.Enabled = false;
            metroGrid1.Enabled = false;
            button = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox2, metroGrid1, "ConsultationRates", false, false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
           // btnArchive.Enabled = false;
            metroGrid1.Enabled = false;
            button = "delete";
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox2, metroGrid1, "ConsultationRates", false, false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
           // btnArchive.Enabled = false;
            metroGrid1.Enabled = false;
            button = "archive";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //if (validFields)
            //{
                pnlDBLoadingMessege uc = new pnlDBLoadingMessege();
                uc.Hide();
                uc.Parent = frmMainPage.ActiveForm;
                uc.Left = 500;
                uc.Top = 300;
                uc.Show();
                uc.BringToFront();
                Application.DoEvents();
                String field;
                String value;
                if (metroGrid1.SelectedRows.Count > 0)
                {
                    int selectedIndex = metroGrid1.SelectedRows[0].Index;

                    String rowID = metroGrid1[2, selectedIndex].Value.ToString();
                    cMethods.getFieldsAndValues(out field, out value, groupBox2, "ConsultationRates");
                    if (button == "add")
                        cMethods.add("DiagnosticCodes", field, value);
                    else if (button == "edit")
                        cMethods.edit("DiagnosticCodes", field, value, " Code = '" + metroGrid1.Rows[selectedIndex].Cells["Code"].Value.ToString() + "'");
                    else if (button == "delete")
                        cMethods.delete("DiagnosticCodes", "Code = '" + rowID + "'");
                    else if (button == "archive")
                        cMethods.Archive(metroGrid1, "DiagnosticCodes", "Code", metroGrid1.Rows[selectedIndex].Cells["Code"].Value.ToString());

                }
                uc.Hide();
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                //btnArchive.Enabled = true;
                metroGrid1.Enabled = true;
                btnConfirm.Hide();
                btnCancel.Hide();
                filter();
           // }
           // else
            //{
            //    MessageBox.Show("Invalid field data, please go through your inputs.");
            //}
        }
        private void filter()
        {
            cMethods.fillDGV(metroGrid1, "DiagnosticCodes");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Hide();
            btnCancel.Hide();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            metroGrid1.Enabled = true;

            filter();
        }
    }
}
