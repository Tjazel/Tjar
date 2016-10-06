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
    public partial class frmStaff : MetroForm
    {
        Methods cMethods = new Methods();
        String correctSearch = "";
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        frmMainPage _frmMainpage = new frmMainPage();



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

            cMethods.fillDGV(dgvStaff, "Staff", cmbStaffCrit);
        }
        public frmStaff()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvStaff, "Staff", false);
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStaff_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvStaff, "Staff", false);
        }

        private void pbBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void cmbStaffCrit_TextChanged(object sender, EventArgs e)
        {
            metroTextBox17.Clear();
            metroComboBox1.Text = "";
            if (cmbStaffCrit.Text != "")
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
                cMethods.filterDGV(dgvStaff, "Staff", " WHERE " + cmbStaffCrit.Text + " LIKE '%" + metroTextBox17.Text + "%'");
            }
            else
            {
                cMethods.filterDGV(dgvStaff, "Staff", " WHERE " + cmbStaffCrit.Text + " " + metroComboBox1.Text + " " + metroTextBox17.Text);
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
                    cMethods.filterDGV(dgvStaff, "Staff", " WHERE " + cmbStaffCrit.Text + " LIKE '%" + metroTextBox17.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvStaff, "MedicalAid", " WHERE " + cmbStaffCrit.Text + " " + metroComboBox1.Text + " " + metroTextBox17.Text);
                }
        }

        private void cmbStaffCrit_TextChanged_1(object sender, EventArgs e)
        {
            if (cmbStaffCrit.Text != "")
            {
                metroTextBox17.Enabled = true;
            }
            else
            {
                metroTextBox17.Enabled = false;
                metroTextBox17.Text = "";
            }
            cMethods.fillDGV(dgvStaff, "Staff");
        }

        private void metroTextBox17_TextChanged_1(object sender, EventArgs e)
        {
            if (metroTextBox17.Text == "")
                cMethods.fillDGV(dgvStaff, "Staff");
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

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (metroComboBox1.Text != "")
                metroTextBox17.Enabled = true;
        }

        private void metroTextButton5_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
               // int selectedIndex = dgvStaff.SelectedRows[0].Index;

               // int rowID = int.Parse(dgvStaff[0, selectedIndex].Value.ToString());
              //  cMethods.delete("Staff", rowID);
            }

        }
    }
}
