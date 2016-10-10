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

namespace PschyHealth
{
    public partial class frmAddressBook : MetroForm
    {
        Methods cMethods = new Methods();
        String button = "";
        String correctSearch = "";
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public frmAddressBook()
        {
            InitializeComponent();
            this.StyleManager = msmAdBook;
        }

        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmAdBook);
            cMethods.readStyle(msmAdBook);
            

            //Load the Form At Position of Main Form
            // int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
            // int HeightofMain = Application.OpenForms["frmMainPage"].Height;
            // int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
            // int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            //  this.Location = new Point(LocationMainX, locationMainy + 30);

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);
           // this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

            cMethods.fillDGV(dgvAddressBook, "AddressBook", cmbAddressBookCriteria);
        }

        private void frmAddressBook_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvAddressBook, "AddressBook", false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "delete";
        }

        private void txtAddressBookSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtAddressBookSearch.Text == "")
                cMethods.fillDGV(dgvAddressBook, "AddressBook");
            else if (cMethods.validString(txtAddressBookSearch.Text))
            {
                filter();
                correctSearch = txtAddressBookSearch.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                txtAddressBookSearch.Text = correctSearch;
                txtAddressBookSearch.Focus();
                txtAddressBookSearch.SelectionStart = txtAddressBookSearch.Text.Length;
            }
        }

        private void dgvAddressBook_SelectionChanged(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvAddressBook, "AddressBook", false);
        }

        private void cmbAddressBookCriteria_TextChanged(object sender, EventArgs e)
        {
            txtAddressBookSearch.Clear();
            cmbAddressBookCriteria.SelectedIndex = -1;
            if (cmbAddressBookCriteria.Text != "")
            {
                txtAddressBookSearch.Enabled = true;

            }
            else
            {
                txtAddressBookSearch.Enabled = false;
                txtAddressBookSearch.Text = "";
            }
            cMethods.fillDGV(dgvAddressBook, "AddressBook");
        }

        private void filter()
        {
            if (txtAddressBookSearch.Text != "")
                if (!cmbAddressBookCriteria.Visible)
                {
                    cMethods.filterDGV(dgvAddressBook, "AddressBook", " WHERE " + cmbAddressBookCriteria.Text + " LIKE '%" + txtAddressBookSearch.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvAddressBook, "AddressBook", " WHERE " + cmbAddressBookCriteria.Text + " " + txtAddressBookSearch.Text);
                }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String field;
            String value;
            if (dgvAddressBook.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvAddressBook.SelectedRows[0].Index;

                String rowID = dgvAddressBook[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "Med");
                if (button == "add")
                    cMethods.add("MedicalAid", field, value);
                else if (button == "edit")
                    cMethods.edit("MedicalAid", field, value, " Medical_Aid = '" + dgvAddressBook.Rows[selectedIndex].Cells["Medical_Aid"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("MedicalAid", "Medical_Aid = '" + rowID + "'");

            }
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnConfirm.Hide();
            btnCancel.Hide();
            filter();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Hide();
            btnConfirm.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvAddressBook, "AddressBook", true, true);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "add";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAddressBook, "AddressBook", true);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "edit";
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvAddressBook, "AddressBook", false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "archive";
        }
    }
}
