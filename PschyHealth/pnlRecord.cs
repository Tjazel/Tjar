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
    public partial class pnlRecord : pnlSlider
    {
        private pnlSettings pnlSettings;

        public pnlRecord()
        {
        }

        public pnlRecord(pnlSettings pnlSettings)
        {
            this.pnlSettings = pnlSettings;
        }

        public pnlRecord(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void pnlRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
