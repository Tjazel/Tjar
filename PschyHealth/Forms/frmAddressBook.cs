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
    public partial class frmAddressBook : MetroForm
    {
        Methods cMethods = new Methods();
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public frmAddressBook()
        {
            InitializeComponent();
            this.StyleManager = msmAdBook;
        }

        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmAdBook);

            //Load the Form At Position of Main Form
            // int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
            // int HeightofMain = Application.OpenForms["frmMainPage"].Height;
            // int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
            // int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            //  this.Location = new Point(LocationMainX, locationMainy + 30);

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);
            this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

           

            
        }

        private void frmAddressBook_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
