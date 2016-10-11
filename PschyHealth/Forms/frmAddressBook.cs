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

namespace PschyHealth
{
    public partial class frmAddressBook : MetroForm
    {
        bool validFields = true;
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
            validFields = true;
            foreach (Control obj in groupBox1.Controls)
            {
                if (obj is MetroTextBox)
                {
                    MetroTextBox txt = new MetroTextBox();
                    txt = obj as MetroTextBox;
                    if ((txt.WaterMarkColor == Color.Red) && (txt.Text == ""))
                    {
                        validFields = false;
                    }
                }
            }
            if (validFields)
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
                btnArchive.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnConfirm.Hide();
                btnCancel.Hide();
                filter();
            }
            else
            {
                MessageBox.Show("Please make sure that all fields are correct.");
            }
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
            btnArchive.Enabled = false;
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
            btnArchive.Enabled = false;
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
            btnArchive.Enabled = false;
            button = "archive";
        }

        private void txtAddressBookNumber_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isNumber(txtAddressBookNumber.Text))
            {
                txtAddressBookNumber.Text = "";
                txtAddressBookNumber.WaterMarkColor = Color.Red;
                txtAddressBookNumber.WaterMark = "Invalid number";
                validFields = cMethods.isNumber(txtAddressBookNumber.Text);
            }
            else if (txtAddressBookNumber.Text == "")
            {
                txtAddressBookNumber.WaterMarkColor = Color.Red;
                txtAddressBookNumber.WaterMark = "Please Input a Number";
            }
        }

        private void txtAddressBookName_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTextWithSpace(txtAddressBookName.Text))
            {
                txtAddressBookName.Text = "";
                txtAddressBookName.WaterMarkColor = Color.Red;
                txtAddressBookName.WaterMark = "Invalid Name";
                validFields = cMethods.isTextWithSpace(txtAddressBookName.Text);
            }
            else if(txtAddressBookName.Text == "")
            {
                txtAddressBookName.WaterMarkColor = Color.Red;
                txtAddressBookName.WaterMark = "Please Input a Name";
            }

        }

        private void txtAddressBookSurname_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTextWithSpace(txtAddressBookSurname.Text))
            {
                txtAddressBookSurname.Text = "";
                txtAddressBookSurname.WaterMarkColor = Color.Red;
                txtAddressBookSurname.WaterMark = "Invalid Surname";
                validFields = cMethods.isTextWithSpace(txtAddressBookSurname.Text);
            }
            else if (txtAddressBookSurname.Text == "")
            {
                txtAddressBookName.WaterMarkColor = Color.Red;
                txtAddressBookName.WaterMark = "Please Input a Surname";
            }
        }

        private void txtAddressBookTelephone_Number_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTelephone(txtAddressBookTelephone_Number.Text))
            {
                txtAddressBookTelephone_Number.Text = "";
                txtAddressBookTelephone_Number.WaterMarkColor = Color.Red;
                txtAddressBookTelephone_Number.WaterMark = "Invalid Telephone";
                validFields = cMethods.isTelephone(txtAddressBookTelephone_Number.Text);
            }
        }

        private void txtAddressBookFax_Number_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTelephone(txtAddressBookFax_Number.Text))
            {
                txtAddressBookFax_Number.Text = "";
                txtAddressBookFax_Number.WaterMarkColor = Color.Red;
                txtAddressBookFax_Number.WaterMark = "Invalid Fax";
                validFields = cMethods.isTelephone(txtAddressBookFax_Number.Text);
            }
        }

        private void txtAddressBookCellphone_Number_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTelephone(txtAddressBookCellphone_Number.Text))
            {
                txtAddressBookCellphone_Number.Text = "";
                txtAddressBookCellphone_Number.WaterMarkColor = Color.Red;
                txtAddressBookCellphone_Number.WaterMark = "Invalid Cellphone";
                validFields = cMethods.isTelephone(txtAddressBookCellphone_Number.Text);
            }
        }

        private void txtAddressBookEmail_Number_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isEmail(txtAddressBookEmail_Address.Text))
            {
                txtAddressBookEmail_Address.Text = "";
                txtAddressBookEmail_Address.WaterMarkColor = Color.Red;
                txtAddressBookEmail_Address.WaterMark = "Invalid Email";
                validFields = cMethods.isEmail(txtAddressBookEmail_Address.Text);
            }
        }

        private void txtAddressBookWebsite_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isURL(txtAddressBookWebsite.Text))
            {
                txtAddressBookWebsite.Text = "";
                txtAddressBookWebsite.WaterMarkColor = Color.Red;
                txtAddressBookWebsite.WaterMark = "Invalid Website";
                validFields = cMethods.isURL(txtAddressBookWebsite.Text);
            }
        }

        private void txtAddressBookAddress1_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTextWithSpace(txtAddressBookAddress1.Text))
            {
                txtAddressBookAddress1.Text = "";
                txtAddressBookAddress1.WaterMarkColor = Color.Red;
                txtAddressBookAddress1.WaterMark = "Invalid Address";
                validFields = cMethods.isTextWithSpace(txtAddressBookAddress1.Text);
            }
        }

        private void txtAddressBookAddress2_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTextWithSpace(txtAddressBookAddress2.Text))
            {
                txtAddressBookAddress2.Text = "";
                txtAddressBookAddress2.WaterMarkColor = Color.Red;
                txtAddressBookAddress2.WaterMark = "Invalid Address";
                validFields = cMethods.isTextWithSpace(txtAddressBookAddress2.Text);
            }
        }

        private void txtAddressBookAddress3_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTextWithSpace(txtAddressBookAddress3.Text))
            {
                txtAddressBookAddress3.Text = "";
                txtAddressBookAddress3.WaterMarkColor = Color.Red;
                txtAddressBookAddress3.WaterMark = "Invalid Address";
                validFields = cMethods.isTextWithSpace(txtAddressBookAddress3.Text);
            }
        }

        private void txtAddressBookZip_Code_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isNumber(txtAddressBookZip_Code.Text))
            {
                txtAddressBookZip_Code.Text = "";
                txtAddressBookZip_Code.WaterMarkColor = Color.Red;
                txtAddressBookZip_Code.WaterMark = "Invalid Zip";
                validFields = cMethods.isNumber(txtAddressBookZip_Code.Text);
            }
        }
    }
}
