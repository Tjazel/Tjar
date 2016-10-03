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
        
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        Methods cMethods = new Methods();

        public frmMainPage()
        {
            InitializeComponent();
            timer1.Start();
            
            
        }


       
       

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlSettings pnlSettings = new pnlSettings(this);
            pnlSettings.swipe(true);
        }

        private void btnClients_Click_1(object sender, EventArgs e)
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

        protected override void OnLoad(EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);
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
            cMethods.CheckFile(path + @"\Log\" + DateTime.Now.Year.ToString() + @"-" + DateTime.Now.Month.ToString()); ;
            
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
                frmEDICodes frmEDICodes = new frmEDICodes();
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

        private void sRecognize_speechRecognized(object sender, SpeechRecognizedEventArgs e)
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

        }

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
            cMethods.silentFillDGV(dgv, "Consultations",true);
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
            ctxPersonalize.Show(pbPersonalize, 0, pbPersonalize.Height);
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
    }

       
}

