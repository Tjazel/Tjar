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
        String button = "";
        Methods cMethods = new Methods();
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
            this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);




        }

        private void frmAddressBook_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
            btnCancel.Show();
            btnConfirm.Show();
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

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAcount_Click_1(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox3, dgvAddressBook, "Acc", true, true);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "add";
        }

        private void btnUpdatAccount_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox3, dgvAddressBook, "Acc", true);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "edit";
        }

        private void btnDeleteAccount_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox3, dgvAddressBook, "Acc", false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "delete";
        }

        private void btnArchive_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox3, dgvAddressBook, "Acc", false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button = "archive";
        }

        private void btnConnfirm_Click(object sender, EventArgs e)
        {
            String field;
            String value;
            if (dgvAddressBook.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvAddressBook.SelectedRows[0].Index;

                String rowID = dgvAddressBook[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox3, "Acc");
                if (button == "add")
                    cMethods.add("Accounting", field, value);
                else if (button == "edit")
                    cMethods.edit("Accounting", field, value, " Transaction_Number = '" + dgvAddressBook.Rows[selectedIndex].Cells["Transaction_Number"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("Accounting", "Transaction_Number = '" + rowID + "'");
                else if (button == "archive")
                    cMethods.Archive(dgvAddressBook, "Accounting", "Transaction_Number", dgvAddressBook.Rows[selectedIndex].Cells["Transaction_Number"].Value.ToString());

            }
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnConfirm.Hide();
            btnCancel.Hide();
            //filter();
        }

        private void btnCanccel_Click(object sender, EventArgs e)
        {
            btnConfirm.Hide();
            btnCancel.Hide();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        //private void filter()
        //{
        //    if (txtAddressBookSearch.Text != "")
        //        if (!metroComboBox1.Visible)
        //        {
        //            cMethods.filterDGV(dgvAddressBook, "Accounting", " WHERE " + cmbAddressBookCriteria.Text + " LIKE '%" + txtAddressBookSearch.Text + "%'");
        //        }
        //        else
        //        {
        //            cMethods.filterDGV(dgvAddressBook, "Accounting", " WHERE " + cmbAddressBookCriteria.Text + " " + metroComboBox1.Text + " " + txtAddressBookSearch.Text);
        //        }
        //    else
        //        cMethods.fillDGV(dgvAddressBook, "Accounting");
        //}
    }
}
