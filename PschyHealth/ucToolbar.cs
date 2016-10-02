using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PschyHealth
{
    public partial class ucToolbar : UserControl
    {
        public ucToolbar()
        {
            InitializeComponent();
        }

        private void ucToolbar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCrashReport cras = new frmCrashReport();
            cras.Show();
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            pnlSettings2 pnlSettings2 = new pnlSettings2(this);
            pnlSettings2.swipe(true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ctxUser.Show(pictureBox2, 0, pbSettings.Height);
        }
    }
}
