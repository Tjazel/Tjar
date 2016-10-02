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
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);


        protected override void OnLoad(EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

            //Load the Form At Position of Main Form
           // int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
           // int HeightofMain = Application.OpenForms["frmMainPage"].Height;
           // int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
           // int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
          //  this.Location = new Point(LocationMainX, locationMainy + 30);

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);

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
            cMethods.filterDGV(dgvAccount, "Accounting", " WHERE " + cmbAccCriteria.Text + " LIKE '%" + txtAccSearch.Text + "%'");
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
            filter();
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
            if ((cmbAccCriteria.Text != "")&&(metroComboBox1.Visible == false))
            {
                txtAccSearch.Enabled = true;
                filter();
            }
            else
            {
                txtAccSearch.Enabled = false;
            }

        }

        private void metroComboBox1_VisibleChanged(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;

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
        }
    }
}

