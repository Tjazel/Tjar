﻿using MetroFramework.Forms;
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

namespace PschyHealth
{
    public partial class frmStatements : MetroForm
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


        protected override void OnLoad(EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);
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

            cMethods.fillDGV(dgvStatements, "Clients");
            cMethods.fillCMBrow(cmbClient, dgvStatements);
        }
        public frmStatements()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStatements_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvStatements_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox3, dgvStatements, "Stat", false);
        }

        private void pbBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStatements_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void cmbStatCrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox17.Clear();
            metroComboBox1.Text = "";
            if (cmbStatCrit.Text != "")
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
            if (metroTextBox17.Text == "")
                cMethods.fillDGV(dgvStatements, "Clients");
            else if (metroTextBox17.Text == String.Concat(metroTextBox17.Text.Where(Char.IsLetterOrDigit)))
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

        private void cmbStatCrit_TextChanged(object sender, EventArgs e)
        {
            metroTextBox17.Clear();
            metroComboBox1.SelectedIndex = -1;
            if (cmbStatCrit.Text != "")
            {
                metroTextBox17.Enabled = true;

            }
            else
            {
                metroTextBox17.Enabled = false;
                metroTextBox17.Text = "";
            }
            cMethods.fillDGV(dgvStatements, "Clients");
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex != -1)
                metroTextBox17.Enabled = true;
            metroTextBox17.Clear();
        }

        private void filter()
        {
            if (metroTextBox17.Text != "")
                if (!metroComboBox1.Visible)
                {
                    cMethods.filterDGV(dgvStatements, "Clients", " WHERE " + cmbStatCrit.Text + " LIKE '%" + metroTextBox17.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvStatements, "Clients", " WHERE " + cmbStatCrit.Text + " " + metroComboBox1.Text + " " + metroTextBox17.Text);
                }
        }

        private void metroComboBox1_VisibleChanged(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            if (metroComboBox1.Visible == true)
                metroTextBox17.Enabled = false;
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line;
            lbStatements.Items.Clear();
            cMethods.fillDGV(dgvStatements, "Consultations");
            for (int i = 0; i < dgvStatements.RowCount-1; i++)
            {
                line = "";
                if((cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) == dgvStatements.Rows[i].Cells["Surname"].Value.ToString()) || (cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2,1) == dgvStatements.Rows[i].Cells["Initials"].Value.ToString()))
                {
                    for (int k = 0; k < dgvStatements.ColumnCount; k++)
                        line += dgvStatements.Rows[i].Cells[k].Value.ToString();
                    lbStatements.Items.Add(line);
                }
                
            }

            cMethods.fillDGV(dgvStatements, "Payments");
            for (int i = 0; i < dgvStatements.RowCount - 1; i++)
            {
                line = "";
                if ((cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) == dgvStatements.Rows[i].Cells["Client_Surname"].Value.ToString()) || (cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2) == dgvStatements.Rows[i].Cells["Client_Name"].Value.ToString()))
                {
                    for (int k = 0; k < dgvStatements.ColumnCount; k++)
                        line += dgvStatements.Rows[i].Cells[k].Value.ToString();
                    lbStatements.Items.Add(line);
                }

            }
            
        }
    }
}
