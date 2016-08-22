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

namespace PschyHealth
{
    public partial class frmMainPage : MetroForm
    {
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
       

        public frmMainPage()
        {
            InitializeComponent();
            timer1.Start();
            pbMicOff.Hide();
        }
       
        private void metroTilePanel2_ItemClick(object sender, EventArgs e)
        {

        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ctxUser.Show(pictureBox2, 0, pbSettings.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlSettings pnlSettings = new pnlSettings(this);
            pnlSettings.swipe(true);
        }

        private void btnClients_Click_1(object sender, EventArgs e)
        {
            pnlClients pnlClients = new pnlClients(this);
            pnlClients.swipe(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbMicOff.Hide();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            pnlStaff pnlStaff = new pnlStaff(this);
            pnlStaff.swipe(true);
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            pnlAccounting pnlAccounting = new pnlAccounting(this);
            pnlAccounting.swipe(true);
        }

        private void metroTileItem6_Click(object sender, EventArgs e)
        {
            pnlStatements pnlStatements = new pnlStatements(this);
            pnlStatements.swipe(true);
        }

        private void metroTileItem7_Click(object sender, EventArgs e)
        {
            pnlMedicalAids pnlMedicalAids = new pnlMedicalAids(this);
            pnlMedicalAids.swipe(true);
        }

        private void metroTileItem8_Click(object sender, EventArgs e)
        {
            pnlEDICodes pnlEDICodes = new pnlEDICodes(this);
            pnlEDICodes.swipe(true);
        }

        private void metroTileItem10_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTileItem11_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTileItem13_Click(object sender, EventArgs e)
        {
            
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            pnlSlider _pnlSlider = new pnlSlider();
            _pnlSlider.swipe(false);
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
            pbMicOff.Show();

            SpeechSynthesizer sSynth = new SpeechSynthesizer();
            PromptBuilder pBuilder = new PromptBuilder();


            Choices sList = new Choices();
            sList.Add(new String[] { "Clients", "Staff", "Statements", "Medical Aids", "Consultation", "Settings" });
            Grammar gr = new Grammar(new GrammarBuilder(sList));



            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr);
                sRecognize.SpeechRecognized += sRecognize_speechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                sRecognize.Recognize();
            }
            catch
            {
                return;
            }

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
            pbMicOff.Hide();
            sRecognize.RecognizeAsyncStop();
        }

        private void metroTileItem12_Click(object sender, EventArgs e)
        {

        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {

        }

        private void pbSettings_Click_1(object sender, EventArgs e)
        {
            pnlSettings pnlSettings = new pnlSettings(this);
            pnlSettings.swipe(true);
        }

        private void metroToolbar1_ItemClick(object sender, EventArgs e)
        {

        }
    }

       
    }

