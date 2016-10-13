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
    public partial class frmLockScreen : Form
    {
        Methods cMethods = new Methods();
        public frmLockScreen()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ctxLock.Show(pictureBox3, 0, pictureBox3.Height);
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwitchUser frmSwitchUser = new frmSwitchUser();
            frmSwitchUser.Show();
        }

        private void frmLockScreen_Load(object sender, EventArgs e)
        {
            pnlScreenSaver pnlScreenSaver = new pnlScreenSaver(this);
            pnlScreenSaver.swipe(true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Uncomment om die kode te gebruik ir login..... Ctrl + K, Ctrl + U

            Boolean loginCorrect = false;
            loginCorrect = cMethods.checkLogin(mtxb_Username.Text, mtxb_Password.Text);
            if (loginCorrect)
            {
            frmMainPage f1 = new frmMainPage();
            f1.Show();
            this.Hide();
            }
            else
            {
               MessageBox.Show("Input data incorrect, please try again.");
            }
        }
    }
}
