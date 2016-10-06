using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PschyHealth
{
    public partial class frmConsultations : MetroForm

    {
        String correctSearch = "";
        String button = "";
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

            cMethods.fillDGV(dgvConsultations, "Consultations", cmbConsultCrit);
        }
        public frmConsultations()
        {
            InitializeComponent();
        }

        private void Consultations_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
            //classStyle _classStyle = new classStyle();
            //_classStyle.changeTheme(this);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvConsultations_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultations_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Con", false);
        }

        private void txtConsultationsSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtConsultationsSearch.Text == "")
                cMethods.fillDGV(dgvConsultations, "Consultations");
            else if (cMethods.validString(txtConsultationsSearch.Text))
            {
                filter();
                correctSearch = txtConsultationsSearch.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                txtConsultationsSearch.Text = correctSearch;
                txtConsultationsSearch.Focus();
                txtConsultationsSearch.SelectionStart = txtConsultationsSearch.Text.Length;
            }
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbConsultCrit_TextChanged(object sender, EventArgs e)
        {
            txtConsultationsSearch.Clear();
            metroComboBox1.Text = "";
            if (cmbConsultCrit.Text != "")
            {
                txtConsultationsSearch.Enabled = true;
                metroComboBox1.Hide();
            }
            else
            {
                txtConsultationsSearch.Enabled = false;
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbConsultCrit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultationsSearch_Click(object sender, EventArgs e)
        {

        }
        private void filter()
        {
            if (txtConsultationsSearch.Text != "")
                if (!metroComboBox1.Visible)
                {
                    cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE " + cmbConsultCrit.Text + " LIKE '%" + txtConsultationsSearch.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE " + cmbConsultCrit.Text + " " + metroComboBox1.Text + " " + txtConsultationsSearch.Text);
                }
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex != -1)
                txtConsultationsSearch.Enabled = true;
            txtConsultationsSearch.Clear();
        }

        private void cmbConsultCrit_TextChanged_1(object sender, EventArgs e)
        {
            txtConsultationsSearch.Clear();
            metroComboBox1.SelectedIndex = -1;
            if (cmbConsultCrit.Text != "")
            {
                txtConsultationsSearch.Enabled = true;
            }
            else
            {
                txtConsultationsSearch.Enabled = false;
                txtConsultationsSearch.Text = "";
            }
            cMethods.fillDGV(dgvConsultations, "Accounting");
        }

        private void metroComboBox1_VisibleChanged(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            if (metroComboBox1.Visible == true)
                txtConsultationsSearch.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Cons", true, true);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            button = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Cons", true);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            button = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Cons", false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            button = "delete";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String field;
            String value;
            if (dgvConsultations.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvConsultations.SelectedRows[0].Index;

                String rowID = dgvConsultations[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "Cons");
                if (button == "add")
                    cMethods.add("Consultations", field, value);
                else if (button == "edit")
                    cMethods.edit("Consultations", field, value, " Consultation = '" + dgvConsultations.Rows[selectedIndex].Cells["Consultation"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("Consultations", "Consultation = '" + rowID + "'");

            }
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnConfirm.Hide();
            filter();
        }
    }
}
