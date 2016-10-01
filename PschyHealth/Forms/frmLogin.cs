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
using MetroFramework.Controls;

namespace PschyHealth
{
    public partial class frmLogin : MetroForm
    {
        Methods cMethods = new Methods();
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
            this.Hide();
            /* MetroGrid dgv = new MetroGrid();
             dgv.Parent = this;
             cMethods.fillDGV(dgv,"Staff");
             for (int i = 0; i < dgv.RowCount; i++)
             {
                 if ((dgv.Rows[i].Cells["Username"].Value.ToString()==mtxb_Username.Text)&&(dgv.Rows[i].Cells["Password"].Value.ToString() == mtxb_Password.Text))
                 {*/

            /*  }
          }*/
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPassword.Show();
           
        }
    }
}
