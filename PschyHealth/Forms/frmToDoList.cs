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

namespace PschyHealth
{
    public partial class frmToDoList : MetroForm
    {
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public frmToDoList()
        {
            InitializeComponent();
            this.StyleManager = msmToDo;
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
