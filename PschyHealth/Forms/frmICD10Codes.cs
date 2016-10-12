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
using System.Runtime.InteropServices;

namespace PschyHealth
{
    public partial class frmICD10Codes : MetroForm
    {
        String button;
        Methods cMethods = new Methods();
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);


        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmICD10);
            cMethods.readStyle(msmICD10);
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

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

            cMethods.fillDGV(dgvEDICodes, "ICD10");
        }
        public frmICD10Codes()
        {
            InitializeComponent();
            this.StyleManager = msmICD10;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEDIcodes_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEDICodes_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvEDICodes, "ICD10Codes", false);
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEDICodes_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvEDICodes, "ICD10Codes", true, true);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            // btnArchive.Enabled = false;
            dgvEDICodes.Enabled = false;
            button = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvEDICodes, "ICD10Codes", true, false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            // btnArchive.Enabled = false;
            dgvEDICodes.Enabled = false;
            button = "add";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvEDICodes, "ICD10Codes", false, false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            // btnArchive.Enabled = false;
            dgvEDICodes.Enabled = false;
            button = "add";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
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
            if (dgvEDICodes.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvEDICodes.SelectedRows[0].Index;

                String rowID = dgvEDICodes[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "ICD10Codes");
                if (button == "add")
                    cMethods.add("ICD10Codes", field, value);
                else if (button == "edit")
                    cMethods.edit("ICD10Codes", field, value, " Code = '" + dgvEDICodes.Rows[selectedIndex].Cells["Code"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("ICD10Codes", "Code = '" + rowID + "'");
                

            }
            uc.Hide();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            //btnArchive.Enabled = true;
            dgvEDICodes.Enabled = true;
            btnConfirm.Hide();
            btnCancel.Hide();
            filter();
        }
        private void filter()
        {
            cMethods.fillDGV(dgvEDICodes, "DiagnosticCodes");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Hide();
            btnCancel.Hide();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            dgvEDICodes.Enabled = true;

            filter();
        }
    }
}
