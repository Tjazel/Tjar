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

namespace PschyHealth
{
    public partial class frmLogin : MetroForm

    {
        frmForgotPassword frmForgotPassword = new frmForgotPassword();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMainPage f1 = new frmMainPage();
            f1.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPassword.Show();
           
        }
    }
}
