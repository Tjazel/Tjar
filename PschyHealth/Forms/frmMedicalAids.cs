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
using MetroFramework.Controls;

namespace PschyHealth
{
    public partial class frmMedicalAids : MetroForm
    {
        Methods cMethods = new Methods();
        String button = "";
        String correctSearch = "";
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);


        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmMedical);
            cMethods.readStyle(msmMedical);

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

            cMethods.fillDGV(dgvMedicalAid, "MedicalAid", cmbMedCrit);
        }
        public frmMedicalAids()
        {
            InitializeComponent();
            this.StyleManager = msmMedical;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMedicalAid_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMedicalAids_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void dgvMedicalAid_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvMedicalAid, "Med", false);
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//***************************************************************************************************************
        private void cmbMedCrit_TextChanged(object sender, EventArgs e)
        {
            metroTextBox17.Clear();
            metroComboBox1.Text = "";
            if (cmbMedCrit.Text != "")
            {
                metroTextBox17.Enabled = true;
            }
            else
            {
                metroTextBox17.Enabled = false;
                metroTextBox17.Text = "";
            }
        }

        private void metroTextBox17_TextChanged(object sender, EventArgs e)
        {
            if (!metroComboBox1.Visible)
            {
                cMethods.filterDGV(dgvMedicalAid, "MedicalAid", " WHERE " + cmbMedCrit.Text + " LIKE '%" + metroTextBox17.Text + "%'");
            }
            else
            {
                cMethods.filterDGV(dgvMedicalAid, "MedicalAid", " WHERE "+ cmbMedCrit.Text + " " + metroComboBox1.Text + " " + metroTextBox17.Text);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.Text != "")
                metroTextBox17.Enabled = true;
        }

        private void metroTextBox17_Click(object sender, EventArgs e)
        {

        }

        private void filter()
        {
            if (metroTextBox17.Text != "")
                if (!metroComboBox1.Visible)
                {
                    cMethods.filterDGV(dgvMedicalAid, "MedicalAid", " WHERE " + cmbMedCrit.Text + " LIKE '%" + metroTextBox17.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvMedicalAid, "MedicalAid", " WHERE " + cmbMedCrit.Text + " " + metroComboBox1.Text + " " + metroTextBox17.Text);
                }
        }

        private void cmbMedCrit_TextChanged_1(object sender, EventArgs e)
        {
            metroTextBox17.Clear();
            metroComboBox1.SelectedIndex = -1;
            if (cmbMedCrit.Text != "")
            {
                metroTextBox17.Enabled = true;
            }
            else
            {
                metroTextBox17.Enabled = false;
                metroTextBox17.Text = "";
            }
            cMethods.fillDGV(dgvMedicalAid, "MedicalAid");
        }

        private void metroTextBox17_TextChanged_1(object sender, EventArgs e)
        {
            if (metroTextBox17.Text == "")
                cMethods.fillDGV(dgvMedicalAid, "MedicalAid");
            else if (cMethods.validString(metroTextBox17.Text))
            {
                filter();
                correctSearch = metroTextBox17.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                metroTextBox17.Text = correctSearch;
                metroTextBox17.Focus();
                metroTextBox17.SelectionStart = metroTextBox17.Text.Length;
            }
        }

        private void metroComboBox1_VisibleChanged(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            if (metroComboBox1.Visible == true)
                metroTextBox17.Enabled = false;
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex != -1)
                metroTextBox17.Enabled = true;
            metroTextBox17.Clear();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            String field;
            String value;
            if (dgvMedicalAid.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvMedicalAid.SelectedRows[0].Index;

                String rowID = dgvMedicalAid[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "Med");
                if (button == "add")
                    cMethods.add("MedicalAid", field, value);
                else if (button == "edit")
                    cMethods.edit("MedicalAid", field, value, " Medical_Aid = '" + dgvMedicalAid.Rows[selectedIndex].Cells["Medical_Aid"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("MedicalAid", "Medical_Aid = '" + rowID + "'");

            }
            btnMedAdd.Enabled = true;
            btnMedDelete.Enabled = true;
            btnMedUpdate.Enabled = true;
            btnConfirm.Hide();
            btnCancel.Hide();
            filter();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancel.Hide();
            btnConfirm.Hide();
        }

        private void btnMedAdd_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvMedicalAid, "Med", true, true);
            btnMedAdd.Enabled = false;
            btnMedDelete.Enabled = false;
            btnMedUpdate.Enabled = false;
            button = "add";
        }

        private void btnMedUpdate_Click_1(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvMedicalAid, "Med", true);
            btnMedAdd.Enabled = false;
            btnMedDelete.Enabled = false;
            btnMedUpdate.Enabled = false;
            button = "edit";
        }

        private void btnMedDelete_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvMedicalAid, "Med", false);
            btnMedAdd.Enabled = false;
            btnMedDelete.Enabled = false;
            btnMedUpdate.Enabled = false;
            button = "delete";
        }

        private void btnMedArchive_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvMedicalAid, "Med", false);
            btnMedAdd.Enabled = false;
            btnMedDelete.Enabled = false;
            btnMedUpdate.Enabled = false;
            button = "archive";
        }
    }
}
