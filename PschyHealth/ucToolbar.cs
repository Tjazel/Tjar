using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using PschyHealth.Properties;

namespace PschyHealth
{
   
    public partial class ucToolbar : UserControl
    {
        int count = 0;
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

        frmMainPage _frmMain = new frmMainPage();
        public ucToolbar()
        {
            InitializeComponent();
        }

        private void ucToolbar_Load(object sender, EventArgs e)
        {
            
            Choices command = new Choices();
            command.Add(new String[] { "Clients", "Staff" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(command);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            switch (e.Result.Text)
            {
                case "Clients":
                    metroClients_Click( sender,  e);

                    break;

                case "Staff":
                    metroStaff_Click(sender,e);

                    break;

              
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCrashReport cras = new frmCrashReport();
            cras.Show();
        }

        private void pbSettings_Click(object sender, EventArgs e)
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

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tbMain.Visible = true;
        }

        private void metroClients_Click(object sender, EventArgs e)
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
                frmClients.ShowDialog();
            }
        }

        private void metroStaff_Click(object sender, EventArgs e)
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

        private void metroAcc_Click(object sender, EventArgs e)
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

        private void metroStatements_Click(object sender, EventArgs e)
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

        private void metroMedicalAids_Click(object sender, EventArgs e)
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

        private void metroConsultations_Click(object sender, EventArgs e)
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

        private void contexUser_Opening(object sender, CancelEventArgs e)
        {
            contexUser.Show(pictureBox2, 0, pictureBox3.Height);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contexUser.Show(pictureBox2, 0, pictureBox3.Height);
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLockScreen frmLockScreen = new frmLockScreen();
            frmLockScreen.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            _frmMain.WindowState =FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       

        private void pbMic_Click(object sender, EventArgs e)
        {
            pbMicOff.Visible = true;
            pbMic.Visible = false;
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
           

           
        }

        private void pbMicOff_Click(object sender, EventArgs e)
        {
            pbMicOff.Visible = false;
            pbMic.Visible = true;
            recEngine.RecognizeAsyncStop();
        }
    }
}

   
 


