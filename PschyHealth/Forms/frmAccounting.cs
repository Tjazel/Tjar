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


            cMethods.fillDGV(dgvAccount, "Accounting", cmbAccCriteria);
        }
        public frmAccounting()
        {
            InitializeComponent();
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
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", false);
            btnDeleteAccount.Enabled = false;
            btnUpdateAccount.Enabled = false;
            btnAddAcount.Enabled = false;
            button = "delete";

        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", true);
            btnDeleteAccount.Enabled = false;
            btnUpdateAccount.Enabled = false;
            btnAddAcount.Enabled = false;
            button = "edit";
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvAccount, "Acc", true,true);
            btnDeleteAccount.Enabled = false;
            btnUpdateAccount.Enabled = false;
            btnAddAcount.Enabled = false;
            button = "add";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String field;
            String value;
            if (dgvAccount.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvAccount.SelectedRows[0].Index;

                String rowID = dgvAccount[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "Acc");
                if(button == "add")
                    cMethods.add("Accounting", field, value);
                else if(button == "edit")
                    cMethods.edit("Accounting", field, value, " Transaction_Number = '" + dgvAccount.Rows[selectedIndex].Cells["Transaction_Number"].Value.ToString() + "'");
                else if(button == "delete")
                    cMethods.delete("Accounting", "Transaction_Number = '" + rowID + "'");

            }
            btnDeleteAccount.Enabled = true;
            btnUpdateAccount.Enabled = true;
            btnAddAcount.Enabled = true;
            btnConfirm.Hide();
            filter();
        }
    }
}

