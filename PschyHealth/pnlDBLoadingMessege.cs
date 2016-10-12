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
    public partial class pnlDBLoadingMessege : UserControl
    {
        public pnlDBLoadingMessege()
        {
            InitializeComponent();
        }

        private void pnlDBLoadingMessege_Load(object sender, EventArgs e)
        {
            /*
            timer1.Start();
            int count = 0;
            while (this.Visible = true)
               
            {
                count++;
                circularProgress1.Value = count; ;
            }
            */
        }

        private void circularProgress1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            int count = 0;
           

              count++;
              circularProgress1.Value = count; ;
            */
        }
    }
}
