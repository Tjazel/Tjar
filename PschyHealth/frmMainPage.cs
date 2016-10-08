using MetroFramework.Forms;
using PschyHealth.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using MetroFramework.Controls;



namespace PschyHealth
{
    public partial class frmMainPage : MetroForm
    {
        //Objects van forms
        MetroFramework.MetroColorStyle cl = new MetroFramework.MetroColorStyle();
        //Vir die kleur van die tiles op die frmMain
        DevComponents.DotNetBar.Metro.eMetroTileColor el;

        //Vir die voice recording
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        Methods cMethods = new Methods();

        public frmMainPage()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            timer1.Start();



        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlSettings pnlSettings = new pnlSettings(this);
            pnlSettings.swipe(true);
        }

      

        protected override void OnLoad(EventArgs e)
        {
           
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

            string path = Environment.GetFolderPath(
            Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment";
            cMethods.CheckFolder(path);
            cMethods.CheckFolder(path + @"\Archive");
            cMethods.CheckFolder(path + @"\Recordings");
            cMethods.CheckFolder(path + @"\Recordings\" + DateTime.Now.Month.ToString());
            cMethods.CheckFolder(path + @"\Styles");
            cMethods.CheckFolder(path + @"\Styles\TileColors");
            cMethods.CheckFile(path + @"\Styles\TileColors\tileColors");
            cMethods.CheckFolder(path + @"\Styles\Theme");
            cMethods.CheckFile(path + @"\Styles\Theme\theme");
            cMethods.CheckFolder(path + @"\Styles\style");
            cMethods.CheckFile(path + @"\Styles\style\style");
            cMethods.CheckFolder(path + @"\Log");
            cMethods.CheckFolder(path + @"\Statements");
            cMethods.CheckFolder(path + @"\Archive\LogArchive");
            cMethods.CheckFolder(path + @"\Archive\StatementsArchive");
            cMethods.CheckFolder(path + @"\Archive\ClientArchive");
            cMethods.CheckFolder(path + @"\Archive\StaffArchive");
            cMethods.CheckFolder(path + @"\Archive\PaymentsArchive");
            cMethods.CheckFolder(path + @"\Archive\AccountingArchive");
            cMethods.CheckFolder(path + @"\Archive\ConsultationsArchive");
            cMethods.CheckFile(path + @"\Log\" + DateTime.Now.Year.ToString() + @"-" + DateTime.Now.Month.ToString());
            cMethods.defTileColors();//default tile colors
            cMethods.defTheme();//Default theme
            cMethods.defStyle();

            //Gee elke tile sy unieke kleur
            cMethods.readFromStyleColor(btn_StaffNew);
            cMethods.readFromStyleColor(btnClients);
            cMethods.readFromStyleColor(btnAccounting);
            cMethods.readFromStyleColor(btnPayments);
            cMethods.readFromStyleColor(btnMedicalAid);
            cMethods.readFromStyleColor(btnConsultations);
            cMethods.readFromStyleColor(btnDiagnostic);
            cMethods.readFromStyleColor(btnReports);
            cMethods.readFromStyleColor(btnArchive);
            cMethods.readFromStyleColor(btnEmail);
            cMethods.readFromStyleColor(btnNotePad);
            cMethods.readFromStyleColor(btnCalender);
            cMethods.readFromStyleColor(btnAdressBook);
            cMethods.readFromStyleColor(btnStatements);
            cMethods.readFromStyleColor(btnStatistics);
            cMethods.readFromStyleColor(btnICD10);
            cMethods.readFromStyleColor(btnRecordings);
            cMethods.readFromStyleColor(btnInfo);
            cMethods.readFromStyleColor(btnDateAndTime);
            cMethods.readTheme(msmMain);
            cMethods.readStyle(msmMain);
            


            //Clone die themes na elke form toe
            // cMethods.cloneTheme(this, frmClients);
            //cMethods.cloneTheme(this, frmStaff);
            // cMethods.cloneTheme(this, frmAccounting);
            //  cMethods.cloneTheme(this, frmPayments);
            // cMethods.cloneTheme(this, frmMedicalAids);
            //cMethods.cloneTheme(this, frmConsultations);
            // cMethods.cloneTheme(this, frmArchive);
            // cMethods.cloneTheme(this, frmNotepad);
            // cMethods.cloneTheme(this, frmAddressBook);
            // cMethods.cloneTheme(this, frmStatements);
            // cMethods.cloneTheme(this, frmRecord);
            //cMethods.cloneTheme(this, frmSettings);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

            String path = Environment.GetFolderPath(
            Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment";
            cMethods.CheckFolder(path);
            cMethods.CheckFolder(path + @"\Archive");
            cMethods.CheckFolder(path + @"\Log");
            cMethods.CheckFolder(path + @"\Statements");
            cMethods.CheckFolder(path + @"\Archive\LogArchive");
            cMethods.CheckFolder(path + @"\Archive\StatementsArchive");
            cMethods.CheckFolder(path + @"\Archive\ClientArchive");
            cMethods.CheckFolder(path + @"\Archive\StaffArchive");
            cMethods.CheckFolder(path + @"\Archive\AccountingArchive");
            cMethods.CheckFolder(path + @"\Archive\ConsultationsArchive");
            cMethods.CheckFile(path + @"\Log\" + DateTime.Now.Year.ToString() + @"-" + DateTime.Now.Month.ToString());

        }


        private void btnStaff_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmStaff")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStaff frmStaff = new frmStaff();
                frmStaff.Show();
            }

        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmAccounting")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmAccounting frmAccounting = new frmAccounting();
                frmAccounting.Show();
            }


        }

        private void metroTileItem6_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmStatements")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStatements frmStatements = new frmStatements();
                frmStatements.Show();
            }
        }

        private void metroTileItem7_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmMedicalAids")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmMedicalAids frmMedicalAids = new frmMedicalAids();
                frmMedicalAids.Show();
            }
        }

        private void metroTileItem8_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmEDICodes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmICD10Codes frmEDICodes = new frmICD10Codes();
                frmEDICodes.Show();
            }
        }

        private void metroTileItem10_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmConsultations")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmConsultations frmConsultations = new frmConsultations();
                frmConsultations.Show();
            }
        }



        private void pbBack_Click(object sender, EventArgs e)
        {
            frmNotepad frmNotepad = new frmNotepad();
            frmNotepad.Show();
        }

        private void metroTilePanel1_ItemClick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.btnDateAndTime.TitleText = dateTime.ToString("hh:mm:ss");

        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLockScreen frmLockScreen = new frmLockScreen();
            frmLockScreen.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCrashReport cras = new frmCrashReport();
            cras.Show();
        }

        private void frmMainPage_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "PschyHealth has been minimized";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "PschyHealth has come back to Normal";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pbMic_Click(object sender, EventArgs e)
        {

        }

       /* private void sRecognize_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Result.Text == "Clients")
            {
                pnlClients pnlClients = new pnlClients(this);
                pnlClients.swipe(true);
            }
            else if (e.Result.Text == "Staff")
            {
                pnlStaff pnlStaff = new pnlStaff(this);
                pnlStaff.swipe(true);
            }
            else if (e.Result.Text == "Statements")
            {
                pnlStatements pnlStatements = new pnlStatements(this);
                pnlStatements.swipe(true);
            }
            else if (e.Result.Text == "Medical Aids")
            {
                pnlMedicalAids pnlMedicalAids = new pnlMedicalAids(this);
                pnlMedicalAids.swipe(true);
            }

            else if (e.Result.Text == "Settings")
            {
                pnlSettings pnlSettings = new pnlSettings(this);
                pnlSettings.swipe(true);
            }

        }*/

        private void pbMicOff_Click(object sender, EventArgs e)
        {

            sRecognize.RecognizeAsyncStop();
        }



        private void pbSettings_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmSettings")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmSettings frmSettings = new frmSettings();
                frmSettings.Show();
            }
        }









        private void frmMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MetroGrid dgv = new MetroGrid();
            dgv.Parent = this;
            cMethods.silentFillDGV(dgv, "Consultations", true);
            cMethods.Archive(dgv, "Consultations", 6);
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {

        }

        private void toolBtnStaff_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmStaff")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStaff frmStaff = new frmStaff();
                frmStaff.Show();
            }
        }



        private void btn_StaffNew_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmStaff")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStaff frmStaff = new frmStaff();
                frmStaff.Show();
            }
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmAccounting")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmAccounting frmAccounting = new frmAccounting();
                frmAccounting.Show();
            }

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmArchive")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmArchive frmArchive = new frmArchive();
                frmArchive.Show();
            }
        }

        private void btnDateAndTime_Click(object sender, EventArgs e)
        {

        }

        private void btnAdressBook_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmAddressBook")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmAddressBook frmAddressBook = new frmAddressBook();
                frmAddressBook.Show();
            }
        }

        private void pbPersonalize_Click(object sender, EventArgs e)
        {
            metroCtxPersonalize.Show(pbPersonalize, 0, pbPersonalize.Height);

        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmNotepad")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmNotepad frmNotepad = new frmNotepad();
                frmNotepad.Show();
            }
        }

        private void btnStatements_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmStatements")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStatements frmStatements = new frmStatements();
                frmStatements.Show();
            }
        }

        private void btnRecordings_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmRecord")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmRecord frmRecord = new frmRecord();
                frmRecord.Show();
            }
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmPayments")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmPayments frmPayments = new frmPayments();
                frmPayments.Show();
            }
        }

        private void frmMainPage_FormClosing_1(object sender, FormClosingEventArgs e)
        {

        }

        private void ctxPersonalize_Opening(object sender, CancelEventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cMethods.writeTheme(msmMain, MetroFramework.MetroThemeStyle.Dark);
            this.Refresh();
        }

        private void btn_StaffNew_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btn_StaffNew);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnClients_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnClients);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            pnlColorChange.Visible = false;
           
            string chosenColor = cmbMain.Text;
            switch(chosenColor)
            {
                case "Green":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
                    cMethods.kleur(el);
                    break;

                case "Orange":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
                    cMethods.kleur(el);
                    break;

                case "Magenta":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
                    cMethods.kleur(el);
                    break;

                case "Blue":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
                    cMethods.kleur(el);
                    break;

                case "Teal":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
                    cMethods.kleur(el);
                    break;

                case "Plum":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
                    cMethods.kleur(el);
                    break;

                case "Coffee":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
                    cMethods.kleur(el);
                    break;

                case "RedOrange":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
                    cMethods.kleur(el);
                    break;

                case "RedViolet":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
                    cMethods.kleur(el);
                    break;

                case "Olive":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
                    cMethods.kleur(el);
                    break;

                case "DarkOlive":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkOlive;
                    cMethods.kleur(el);
                    break;

                case "Rust":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Rust;
                    cMethods.kleur(el);
                    break;

                case "Maroon":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Maroon;
                    cMethods.kleur(el);
                    break;

                case "Yellowish":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish;
                    cMethods.kleur(el);
                    break;

                case "Blueish":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
                    cMethods.kleur(el);
                    break;

                case "DarkBlue":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue;
                    cMethods.kleur(el);
                    break;

                case "Yellow":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellow;
                    cMethods.kleur(el);
                    break;

                case "Gray":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
                    cMethods.kleur(el);
                    break;

                case "DarkGreen":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
                    cMethods.kleur(el);
                    break;

                case "MaroonWashed":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.MaroonWashed;
                    cMethods.kleur(el);
                    break;

                case "PlumWashed":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.PlumWashed;
                    cMethods.kleur(el);
                    break;

                case "Azure":
                    el = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
                    cMethods.kleur(el);
                    break;

            }
            cmbMain.Text = "";
        }

        private void btnAccounting_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnAccounting);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnPayments_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnPayments);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnDiagnostic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnDiagnostic);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnReports_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnReports);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnArchive_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnArchive);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnEmail);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnAdressBook_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnAdressBook);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnStatements_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnStatements);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnStatistics_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnStatistics);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnICD10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnICD10);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnDateAndTime_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnDateAndTime);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void itemContainer1_Click(object sender, EventArgs e)
        {
            pnlColorChange.Visible = false;
        }

        private void btnMedicalAid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnMedicalAid);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnConsultations_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnConsultations);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnNotePad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnNotePad);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnCalender_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnCalender);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnInfo);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void btnRecordings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMethods.dieKnoppie(btnRecordings);
                cMethods.pos(this, pnlColorChange);
            }
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cMethods.writeTheme(msmMain, MetroFramework.MetroThemeStyle.Default);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmClients")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmClients frmClients = new frmClients();
                frmClients.Show();
            }
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmToDoList")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmToDoList frmToDoList = new frmToDoList();
                frmToDoList.Show();
            }
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmDiagnosticCodes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmDiagnosticCodes frmDiagnosticCodes = new frmDiagnosticCodes();
                frmDiagnosticCodes.Show();
            }

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmEmail")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmEmail frmEmail = new frmEmail();
                frmEmail.Show();
            }

        }

      

        private void darkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cMethods.writeTheme(msmMain, MetroFramework.MetroThemeStyle.Dark);
            this.Refresh();
        }

        private void defaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cMethods.writeTheme(msmMain, MetroFramework.MetroThemeStyle.Default);
            this.Refresh();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)1;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)2;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)3;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)4;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)5;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)6;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void tealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)7;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)8;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)9;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)10;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)11;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)12;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)13;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cl = (MetroFramework.MetroColorStyle)14;
            cMethods.writeStyle(msmMain, cl);
            cMethods.readStyle(msmMain);
            this.Refresh();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frmStatistics")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmStatistics frmStatistics = new frmStatistics();
                frmStatistics.Show();
            }
        }
    }
}

