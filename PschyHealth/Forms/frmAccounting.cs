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
using System.Data.SqlClient;

namespace PschyHealth
{
    public partial class frmAccounting : MetroForm
    {
        bool validFields = true;
        Methods cMethods = new Methods();
        String correctSearch = "";
        String button = "";
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);


        protected override void OnLoad(EventArgs e)
        {

            cMethods.readTheme(msmAcc);
            cMethods.readStyle(msmAcc);
            this.Refresh();
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
            String dt;


            cMethods.fillDGV(dgvAccount, "Accounting", cmbAccCriteria);
            int diff;
            for (int i = 0; i < dgvAccount.RowCount - 1; i++)
            {
                dt = dgvAccount.Rows[i].Cells["Date"].Value.ToString();
                dt = dt.Substring(0, dt.IndexOf(@"/"));
                diff = Convert.ToInt16(DateTime.Now.Month.ToString()) - Convert.ToInt16(dt);
                if (diff > 0)
                    cMethods.Archive(dgvAccount, "Accounting", "Transaction_Number", dgvAccount.Rows[i].Cells["Transaction_Number"].Value.ToString());
            }
            cMethods.fillDGV(dgvAccount, "Accounting", cmbAccCriteria);
        }
        public frmAccounting()
        {
            InitializeComponent();
            this.StyleManager = msmAcc;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void txtAccSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAccounting_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
            
        }

        private void dgvAccount_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", false);
        }

        private void txtAccSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtAccSearch.Text == "")
                cMethods.fillDGV(dgvAccount, "Accounting");
            else if(cMethods.validString(txtAccSearch.Text))
            {
                filter();
                correctSearch = txtAccSearch.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                txtAccSearch.Text = correctSearch;
                txtAccSearch.Focus();
                txtAccSearch.SelectionStart = txtAccSearch.Text.Length;
            }
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAccCriteria_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void cmbAccCriteria_TextChanged_1(object sender, EventArgs e)
        {
            txtAccSearch.Clear();
            metroComboBox1.SelectedIndex = -1;
            if (cmbAccCriteria.Text != "")
            {
                txtAccSearch.Enabled = true;
                if (cmbAccCriteria.Text == "Amount")
                    metroComboBox1.Show();
                else
                    metroComboBox1.Hide();
            }
            else
            {
                txtAccSearch.Enabled = false;
                txtAccSearch.Text = "";
            }
            cMethods.fillDGV(dgvAccount, "Accounting");
        }

        private void filter()
        {
            if (txtAccSearch.Text != "")
                if (!metroComboBox1.Visible)
                {
                    cMethods.filterDGV(dgvAccount, "Accounting", " WHERE " + cmbAccCriteria.Text + " LIKE '%" + txtAccSearch.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvAccount, "Accounting", " WHERE " + cmbAccCriteria.Text + " " + metroComboBox1.Text + " " + txtAccSearch.Text);
                }
            else
                cMethods.fillDGV(dgvAccount, "Accounting");

        }

        private void metroComboBox1_VisibleChanged_1(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            if (metroComboBox1.Visible == true)
                txtAccSearch.Enabled = false;
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex != -1)
                txtAccSearch.Enabled = true;
            txtAccSearch.Clear();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddAcount_Click_1(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", true, true);
            btnDeleteAccount.Enabled = false;
            btnUpdatAccount.Enabled = false;
            btnAddAcount.Enabled = false;
            btnArchive.Enabled = false;
            dgvAccount.Enabled = false;
            button = "add";
        }

        private void btnUpdatAccount_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", true);
            btnDeleteAccount.Enabled = false;
            btnUpdatAccount.Enabled = false;
            btnAddAcount.Enabled = false;
            btnArchive.Enabled = false;
            dgvAccount.Enabled = false;
            button = "edit";
        }

        private void btnDeleteAccount_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", false);
            btnDeleteAccount.Enabled = false;
            btnUpdatAccount.Enabled = false;
            btnAddAcount.Enabled = false;
            btnArchive.Enabled = false;
            dgvAccount.Enabled = false;
            button = "delete";
        }

        private void btnArchive_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", false);
            btnDeleteAccount.Enabled = false;
            btnUpdatAccount.Enabled = false;
            btnAddAcount.Enabled = false;
            btnArchive.Enabled = false;
            dgvAccount.Enabled = false;
            button = "archive";
        }

        private void btnConnfirm_Click(object sender, EventArgs e)
        {
            //bool accept = true;
            //foreach(Control obj in groupBox1.Controls)
            //{
            //    string name = "";
            //    if(obj is MetroTextBox)
            //    {
            //        name = obj.Name;
            //    }
            //}
            if (validFields)
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
                if (dgvAccount.SelectedRows.Count > 0)
                {
                    int selectedIndex = dgvAccount.SelectedRows[0].Index;

                    String rowID = dgvAccount[0, selectedIndex].Value.ToString();
                    cMethods.getFieldsAndValues(out field, out value, groupBox1, "Acc");
                    if (button == "add")
                        cMethods.add("Accounting", field, value);
                    else if (button == "edit")
                        cMethods.edit("Accounting", field, value, " Transaction_Number = '" + dgvAccount.Rows[selectedIndex].Cells["Transaction_Number"].Value.ToString() + "'");
                    else if (button == "delete")
                        cMethods.delete("Accounting", "Transaction_Number = '" + rowID + "'");
                    else if (button == "archive")
                        cMethods.Archive(dgvAccount, "Accounting", "Transaction_Number", dgvAccount.Rows[selectedIndex].Cells["Transaction_Number"].Value.ToString());

                }
                uc.Hide();
                btnDeleteAccount.Enabled = true;
                btnUpdatAccount.Enabled = true;
                btnAddAcount.Enabled = true;
                btnArchive.Enabled = true;
                dgvAccount.Enabled = true;
                btnConfirm.Hide();
                btnCancel.Hide();
                filter();
            }
            else
            {
                MessageBox.Show("Invalid field data, please go through your inputs.");
            }
        }

        private void btnCanccel_Click(object sender, EventArgs e)
        {
            btnConfirm.Hide();
            btnCancel.Hide();
            btnDeleteAccount.Enabled = true;
            btnUpdatAccount.Enabled = true;
            btnAddAcount.Enabled = true;
            btnArchive.Enabled = true;
            btnAddAcount.Enabled = true;
            dgvAccount.Enabled = true;
            filter();
        }

        private void txtAccTransaction_Number_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isNumber(txtAccTransaction_Number.Text))
            {
                txtAccTransaction_Number.Text = "";
                txtAccTransaction_Number.WaterMarkColor = Color.Red;
                txtAccTransaction_Number.WaterMark = "Incorrect Number";
                validFields = false;
            }
        }

        private void txtAccDescription_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isTextWithSpace(txtAccDescription.Text))
            {
                txtAccDescription.Text = "";
                txtAccDescription.WaterMarkColor = Color.Red;
                txtAccDescription.WaterMark = "No unusual characters";
                validFields = false;
            }
        }

        private void txtAccType_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isText(cmbAccType.Text))
            {
                cmbAccType.Text = "";
                //cmbAccType.WaterMarkColor = Color.Red;
                //cmbAccType.WaterMark = "Single phrase";
                validFields = false;
            }
        }

        private void txtAccAmount_Leave(object sender, EventArgs e)
        {
            if (!cMethods.isMoney(txtAccAmount.Text))
            {
                txtAccAmount.Text = "";
                txtAccAmount.WaterMarkColor = Color.Red;
                txtAccAmount.WaterMark = "Incorrect Format";
                validFields = false;
            }
        }

        private void cmbAccDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbAccCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnable_Click(object sender, EventArgs e)
        {

        }
    }
}

