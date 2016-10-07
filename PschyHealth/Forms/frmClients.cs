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
        String button = "";
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
            cMethods.readTheme(msmClients);
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
            this.StyleManager = msmClients;
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
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Clients", false);
            btnDeleteClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnAddNewClient.Enabled = false;
            btnAddExistingClient.Enabled = false;
            button = "delete";
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Clients", true);
            btnDeleteClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnAddNewClient.Enabled = false;
            btnAddExistingClient.Enabled = false;
            button = "edit";
        }

        private void btnAddExistingClient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Clients", true, true);
            btnDeleteClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnAddNewClient.Enabled = false;
            btnAddExistingClient.Enabled = false;
            button = "add";
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Clients", true, true);
            btnDeleteClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnAddNewClient.Enabled = false;
            btnAddExistingClient.Enabled = false;
            button = "add";
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            String field;
            String value;
            if (dgvClients.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvClients.SelectedRows[0].Index;

                String rowID = dgvClients[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "Clients");
                if (button == "add")
                    cMethods.add("Clients", field, value);
                else if (button == "edit")
                    cMethods.edit("Clients", field, value, " ID = '" + dgvClients.Rows[selectedIndex].Cells["ID"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("Clients", "ID = '" + rowID + "'");

            }
            btnDeleteClient.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnAddNewClient.Enabled = true;
            btnAddExistingClient.Enabled = true;
            btnConfirm.Hide();
            filter();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }

        private void btnArchive_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            cMethods.fillTextbox(groupBox1, dgvClients, "Clients", false);
            btnAddExistingClient.Enabled = false;
            btnAddNewClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            button = "archive";
        }
    }
}
