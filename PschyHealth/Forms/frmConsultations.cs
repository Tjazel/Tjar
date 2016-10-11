using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PschyHealth
{
    public partial class frmConsultations : MetroForm

    {
        String[] descrip = new String[50];
        MetroGrid dgv = new MetroGrid();
        String[] depCode = new String[10];
        Boolean addClick = false;
        String correctSearch = "";
        String button = "";
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

            cMethods.readTheme(msmConsult);
            cMethods.readStyle(msmConsult);
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

            cMethods.fillDGV(dgvConsultations, "DiagnosticCodes");
            for(int i = 0; i<dgvConsultations.RowCount-1;i++)
            {
                cmbConsultationsDiagnostic_code.Items.Add(dgvConsultations.Rows[i].Cells[2].Value.ToString());
                descrip[i] = dgvConsultations.Rows[i].Cells[4].Value.ToString();
            }
            cMethods.fillDGV(dgvConsultations, "ICD10Codes");
            for (int i = 0; i < dgvConsultations.RowCount - 1; i++)
            {
                cmbConsultationsICD10.Items.Add(dgvConsultations.Rows[i].Cells[0].Value.ToString());
            }
            cMethods.fillDGV(dgvConsultations, "Clients");
            cMethods.fillCMBrow(cmbConsultationsName, cmbConsultationsSurname, dgvConsultations);

            //cMethods.fillDGV(dgvConsultations, "Consultations");


        }
        public frmConsultations()
        {
            InitializeComponent();
            this.StyleManager = msmConsult;
        }

        private void Consultations_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
            //classStyle _classStyle = new classStyle();
            //_classStyle.changeTheme(this);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvConsultations_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultations_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Consultations", false);
        }

        private void txtConsultationsSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtConsultationsSearch.Text == "")
                cMethods.fillDGV(dgvConsultations, "Consultations");
            else if (cMethods.validString(txtConsultationsSearch.Text))
            {
                filter();
                correctSearch = txtConsultationsSearch.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                txtConsultationsSearch.Text = correctSearch;
                txtConsultationsSearch.Focus();
                txtConsultationsSearch.SelectionStart = txtConsultationsSearch.Text.Length;
            }
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbConsultCrit_TextChanged(object sender, EventArgs e)
        {
            txtConsultationsSearch.Clear();
            metroComboBox1.Text = "";
            if (cmbConsultCrit.Text != "")
            {
                txtConsultationsSearch.Enabled = true;
                metroComboBox1.Hide();
            }
            else
            {
                txtConsultationsSearch.Enabled = false;
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbConsultCrit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConsultationsSearch_Click(object sender, EventArgs e)
        {

        }
        private void filter()
        {
            if (txtConsultationsSearch.Text != "")
                if (!metroComboBox1.Visible)
                {
                    cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE " + cmbConsultCrit.Text + " LIKE '%" + txtConsultationsSearch.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE " + cmbConsultCrit.Text + " " + metroComboBox1.Text + " " + txtConsultationsSearch.Text);
                }
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex != -1)
                txtConsultationsSearch.Enabled = true;
            txtConsultationsSearch.Clear();
        }

        private void cmbConsultCrit_TextChanged_1(object sender, EventArgs e)
        {
            txtConsultationsSearch.Clear();
            metroComboBox1.SelectedIndex = -1;
            if (cmbConsultCrit.Text != "")
            {
                txtConsultationsSearch.Enabled = true;
            }
            else
            {
                txtConsultationsSearch.Enabled = false;
                txtConsultationsSearch.Text = "";
            }
            cMethods.fillDGV(dgvConsultations, "Accounting");
        }

        private void metroComboBox1_VisibleChanged(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            if (metroComboBox1.Visible == true)
                txtConsultationsSearch.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Cons", true, true);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            button = "add";
            addClick = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Cons", true);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            button = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Cons", false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            button = "delete";
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
           
        }

        private void txtConsultationRatesAssesment_type_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
        }

        private void btnArchive_Click_1(object sender, EventArgs e)
        {
            btnConfirm.Show();
            btnCancel.Show();
            cMethods.fillTextbox(groupBox1, dgvConsultations, "Cons", false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            button = "archive";
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            String field;
            String value;
            Boolean b = true;
            if (dgvConsultations.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvConsultations.SelectedRows[0].Index;

                String rowID = dgvConsultations[0, selectedIndex].Value.ToString();
                cMethods.getFieldsAndValues(out field, out value, groupBox1, "Consultations");
                if (button == "add")
                {
                    String name = cmbConsultationsName.Text;
                    String surname = cmbConsultationsSurname.Text;
                    cMethods.add("Consultations", field, value);
                    cMethods.filterDGV(dgvConsultations, "Consultations", " WHERE Name = '" + name + "' AND Surname = '" + surname + "'");
                    for (int i = 0; i < dgvConsultations.RowCount - 1; i++)
                        if (dgvConsultations.Rows[i].Cells["Date_Finished"].Value.ToString() != "")
                            b = false;
                    if (!b)
                    {
                        cMethods.edit("Clients", "Date_Finished", "''", " Surname = '" + surname + "' AND First_Name = '" + name + "'");
                        cMethods.edit("Consultations", "Date_Finished", "''", " Surname = '" + surname + "' AND Name = '" + name + "'");
                        cMethods.edit("Payments", "Date_Finished", "''", " Client_Surname = '" + surname + "' AND Client_Name = '" + name + "'");
                    }
                }
                else if (button == "edit")
                    cMethods.edit("Consultations", field, value, " Consultation = '" + dgvConsultations.Rows[selectedIndex].Cells["Consultation"].Value.ToString() + "'");
                else if (button == "delete")
                    cMethods.delete("Consultations", "Consultation = '" + rowID + "'");

            }
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnConfirm.Hide();
            btnCancel.Hide();
            filter();
            addClick = false;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancel.Hide();
            btnConfirm.Hide();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            addClick = false;
        }

        private void cmbConsultationsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbConsultationsSurname.SelectedIndex = cmbConsultationsName.SelectedIndex;
        }

        private void cmbConsultationsSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbConsultationsDependant_Name.Items.Clear();
            cmbConsultationsName.SelectedIndex = cmbConsultationsSurname.SelectedIndex;
            dgv.Parent = this;
            dgv.Hide();
            if (cmbConsultationsDependant_Name.Text != "")
                cMethods.filterDGV(dgvConsultations, "Clients", " WHERE  Surname = '" + cmbConsultationsSurname.Text + "' AND First_Name = '" + cmbConsultationsName.Text + "'");
            else
                cMethods.fillDGV(dgvConsultations, "Clients");
            txtConsultationsMember_Number.Text = dgvConsultations.Rows[0].Cells[2].Value.ToString();
            cmbConsultationsDate_Of_Birth.Text = dgvConsultations.Rows[0].Cells[5].Value.ToString();
            for(int i = 0; i < dgvConsultations.RowCount-1;i++)
            {
                cmbConsultationsDependant_Name.Items.Add(dgvConsultations.Rows[i].Cells["Dependant_Full_Name"].Value.ToString());
                depCode[i] = dgvConsultations.Rows[i].Cells["Dependant_Code"].Value.ToString();
            }
        }

        private void cmbConsultationsDependant_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(addClick)
            {
                txtConsultationsDependancy_Code.Text = depCode[cmbConsultationsDependant_Name.SelectedIndex];
            }
            if (cmbConsultationsDependant_Name.Text == "")
                txtConsultationsDependancy_Code.Text = "";
            else
            {
                if(cmbConsultationsDependant_Name.Text != "")
                cMethods.filterDGV(dgvConsultations, "Clients", " WHERE  Surname = '" + cmbConsultationsSurname.Text + "' AND First_Name = '" + cmbConsultationsName.Text + "' AND Dependant_Full_Name = '" + cmbConsultationsDependant_Name.Text + "'");
                txtConsultationsMember_Number.Text = dgvConsultations.Rows[0].Cells[2].Value.ToString();
                cmbConsultationsDate_Of_Birth.Text = dgvConsultations.Rows[0].Cells[5].Value.ToString();
            }
        }

        private void txtConsultationsDependancy_Code_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConsultationsDependancy_Code_EnabledChanged(object sender, EventArgs e)
        {
            txtConsultationsDependancy_Code.Enabled = false;
        }

        private void txtConsultationsDescription_EnabledChanged(object sender, EventArgs e)
        {
            txtConsultationsDescription.Enabled = false;
        }

        private void cmbConsultationsDiagnostic_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsultationsDescription.Text = descrip[cmbConsultationsDiagnostic_code.SelectedIndex];
        }

        private void txtConsultationsMember_Number_EnabledChanged(object sender, EventArgs e)
        {
            txtConsultationsMember_Number.Enabled = false;
        }

        private void cmbConsultationsDate_Of_Birth_EnabledChanged(object sender, EventArgs e)
        {
            cmbConsultationsDate_Of_Birth.Enabled = false;
        }
    }
}
