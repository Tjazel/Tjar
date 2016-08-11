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
    public partial class pnlScreenSaver : pnlScreenSaverSettings
    {
        public pnlScreenSaver(Form owner) : base(owner)
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pnlScreenSaver_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = dateTime.ToString("hhhh:mmmm");
            this.label2.Text = dateTime.ToString("dddd, MMMMM, dd");
        }
    }
}
