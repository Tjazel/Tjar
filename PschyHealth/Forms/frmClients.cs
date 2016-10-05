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
    public partial class frmClients : MetroForm

    {
        String correctSearch = "";
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        Methods cMethods = new Methods();

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);


        protected override void OnLoad(EventArgs e)
        {
          
           //Load the Form At Position of Main Form
            //int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
           // int HeightofMain = Application.OpenForms["frmMainPage"].Height;
            ////int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
           // int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            //this.Location = new Point(LocationMainX, locationMainy + 30);

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);
            this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);


            cMethods.fillDGV(dgvClients, "Clients", cmbClientCriteria);
        }
        public frmClients()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClients_Load(object sender, EventArgs e)
        {
           ucToolbar uc = new ucToolbar();
           uc.Dock = DockStyle.Top;
           this.Controls.Add(uc);
        }

        private void dgvClients_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvClients, "Client", false);
        }

        private void txtClientsSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtClientsSearch.Text == "")
                cMethods.fillDGV(dgvClients, "Clients");
            else if (cMethods.validString(txtClientsSearch.Text))
            {
                filter();
                correctSearch = txtClientsSearch.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                txtClientsSearch.Text = correctSearch;
                txtClientsSearch.Focus();
                txtClientsSearch.SelectionStart = txtClientsSearch.Text.Length;
            }
        }

        private void cmbClientCriteria_TextChanged(object sender, EventArgs e)
        {
            txtClientsSearch.Clear();
            cmbClientSymbol.SelectedIndex = -1;
            if (cmbClientCriteria.Text != "")
            {
                txtClientsSearch.Enabled = true;

            }
            else
            {
                txtClientsSearch.Enabled = false;
                txtClientsSearch.Text = "";
            }
            cMethods.fillDGV(dgvClients, "Clients");
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClientSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientSymbol.Text != "")
                txtClientsSearch.Enabled = true;
            
        }
        private void filter()
        {
            if (txtClientsSearch.Text != "")
                if (!cmbClientSymbol.Visible)
                {
                    cMethods.filterDGV(dgvClients, "Clients", " WHERE " + cmbClientCriteria.Text + " LIKE '%" + txtClientsSearch.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvClients, "Clients", " WHERE " + cmbClientCriteria.Text + " " + cmbClientSymbol.Text + " " + txtClientsSearch.Text);
                }
        }

        private void cmbClientSymbol_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbClientSymbol.SelectedIndex != -1)
                txtClientsSearch.Enabled = true;
            txtClientsSearch.Clear();
        }

        private void cmbClientSymbol_VisibleChanged(object sender, EventArgs e)
        {
            cmbClientSymbol.SelectedIndex = -1;
            if (cmbClientSymbol.Visible == true)
                txtClientsSearch.Enabled = false;
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvClients.SelectedRows[0].Index;

                int rowID = int.Parse(dgvClients[0, selectedIndex].Value.ToString());
                cMethods.delete("Clients", rowID);
            }
        }

        //private void btnAddAcount_Click(object sender, EventArgs e)
        //{
        //    if ((txtAccTransaction.Text != null) && (txtAccType.Text != null) && (txtAccDate.Text != null) && (txtAccAmount.Text != null) && (txtAccDescription.Text != null))
        //        cMethods.insert("Accounting", txtAccTransaction.Text + txtAccDescription.Text + txtAccType.Text + txtAccAmount.Text + txtAccDate.Text);
        //}

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
        //    if (dgvClients.SelectedRows.Count > 0)
        //    {
        //        int selectedIndex = dgvClients.SelectedRows[0].Index;

        //        int rowID = int.Parse(dgvClients[0, selectedIndex].Value.ToString());
        //        dgvClients.Rows.RemoveAt(selectedIndex);

        //        if (txtAccTransaction.Text != null)
        //        {
        //            cMethods.edit("Accounting", "Transaction_Number", txtAccTransaction.Text, rowID);
        //        }
        //        if (txtAccType.Text != null)
        //        {
        //            cMethods.edit("Accounting", "Type", txtAccType.Text, rowID);
        //        }
        //        if (txtAccDate.Text != null)
        //        {
        //            cMethods.edit("Accounting", "Date", txtAccDate.Text, rowID);
        //        }
        //        if (txtAccAmount.Text != null)
        //        {
        //            cMethods.edit("Accounting", "Amount", txtAccAmount.Text, rowID);
        //        }
        //        if (txtAccDescription.Text != null)
        //        {
        //            cMethods.edit("Accounting", "Description", txtAccDescription.Text, rowID);
        //        }
        //    }
        }
    }
}
