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

namespace PschyHealth
{
    public partial class frmStatistics : MetroForm
    {

        //Constants
        Methods cMethods = new Methods();
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public frmStatistics()
        {
            InitializeComponent();
        }

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

            int year = Convert.ToInt16(DateTime.Now.Year.ToString());
            for (int i = 2016; i <= year; i++)
                cmbYear.Items.Add(i);
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {

        }

        private void btnMaandelikseGeld_Click(object sender, EventArgs e)
        {
            txtStatistics.Text = "Month\tIncome\t\tExpeces\r\n";
            
            txtStatistics.AppendText(cMethods.Analysis("Payments", "Accounting", "Tax", cmbYear));
        }

        private void btnGeldvloei_Click(object sender, EventArgs e)
        {
            txtStatistics.Text = "Month\tConsultations\tPayments\r\n";

            txtStatistics.AppendText(cMethods.Analysis("Consultations", "Payments", "Tax", cmbYear));
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
