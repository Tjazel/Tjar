﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PschyHealth.Panels;

namespace PschyHealth
{
    public partial class pnlSettings : pnlSlider
    {
        
        public pnlSettings(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void pnlSettings_Load(object sender, EventArgs e)
        {
            
        }

      

        private void About_Click(object sender, EventArgs e)
        {
           

        }

        private void pnlSettings_Leave(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            /*this.swipe(false);
            pnlRecord pnlRecord = new pnlRecord(this);
            pnlRecord.swipe(true);*/
           
            
            

            

        }

        private void metroTilePanel1_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
