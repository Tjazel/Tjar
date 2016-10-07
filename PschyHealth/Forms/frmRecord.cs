using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PschyHealth.Forms
{
    public partial class frmRecord : MetroForm
    {
        int tempHour = 0;
        int tempMin = 0;
        int tempSec = 0;
        int tempMs = 0;

        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetorno, int MciRetornoLeng, int CallBack);
        string musica = "";

        int hour, min, sec, ms = 0;

        Methods cMethods = new Methods();
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        frmMainPage _frmMainpage = new frmMainPage();
        public frmRecord()
        {
            InitializeComponent();
            this.StyleManager = msmRecording;
        }

        protected override void OnLoad(EventArgs e)
        {

            cMethods.readTheme(msmRecording);
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
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            txtName.Visible = true;
        }

        private void rdPause_Click(object sender, EventArgs e)
        {
            pbRec.Visible = false;
            timer1.Stop();
            mciSendString("pause Som", null, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToString(hour + " : " + min + " : " + sec + " : " + ms);
            ms++;

            if(ms>10)
            {
                sec++;
                ms = 0;
            }else if(sec>60)
            {
                min++;
                sec = 0;
            }
            else if(min>60)
            {
                hour++;
                min = 0;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
            mciSendString("close " + musica, null, 0, 0);

        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rdPlay_Click(object sender, EventArgs e)
        {
            pbWave.Visible = true;
            lblPlayBack.Visible = true;
            lblTime.Visible = false;
            pbRec.Visible = false;
           
           
            
            if (musica == "")
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Wave|*.wav";
                if (open.ShowDialog() == DialogResult.OK) { musica = open.FileName; }
            } else
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Wave|*.wav";
                if (open.ShowDialog() == DialogResult.OK) { musica = open.FileName; }
                lblPlayName.Text = open.FileName;
            }
            txtName.Visible = false;
            lblPlayName.Visible = true;
             
            pbWave.Visible = true;
            lblPlayBack.Visible = true;
            mciSendString("play " + musica, null, 0, 0);
                





            // mciSendString("play " + musica, null, 0, 0);

        }

        private void rdRecord_Click(object sender, EventArgs e)
        {
            txtName.Visible = true;
            lblPlayBack.Visible = false;
            pbWave.Visible = false;
            pbRec.Visible = true;
            timer1.Start();

            mciSendString("open new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
        }

        private void rdSave_Click(object sender, EventArgs e)
        {
            

            pbRec.Visible = false;
            timer1.Stop();

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "wave|*.wav";


            if (save.ShowDialog() == DialogResult.OK)
            {

                mciSendString("save Som " + save.FileName, null, 0, 0);
                mciSendString("close Som", null, 0, 0);
            }
        }
    }
}
