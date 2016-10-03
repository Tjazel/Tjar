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
using System.Runtime.InteropServices;
using MetroFramework.Controls;
using System.Data.SqlClient;
using System.IO;

namespace PschyHealth
{
    public partial class frmArchive : MetroForm
    {
       

       // Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public frmArchive()
        {
            InitializeComponent();
        }

        private void frmArchive_Load(object sender, EventArgs e)
        {
            
            
        }

        protected override void OnLoad(EventArgs e)
        {
           ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

           /* //Load the Form At Position of Main Form
            int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
            int HeightOfMain = Application.OpenForms["frmMainPage"].Height;
            int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
            int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            this.Location = new Point(LocationMainX, locationMainy + 30);*/

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);

            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\";
            DirectoryInfo d = new DirectoryInfo(filepath);
            cmbFolder.Items.Clear();
            try
            {
                foreach (var file in d.GetDirectories())
                {
                    cmbFolder.Items.Add(file.Name);
                }
            }
            catch
            {

            }
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmArchive_Shown(object sender, EventArgs e)
        {
            
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArcList.Items.Clear();
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + cmbFolder.Text + @"\";
            DirectoryInfo d = new DirectoryInfo(filepath);
            cmbFile.Items.Clear();
            try
            {
                foreach (var file in d.GetFiles())
                {
                    cmbFile.Items.Add(file.Name);
                }
            }
            catch
            {

            }
        }

        private void cmbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            lbArcList.Items.Clear();
            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + cmbFolder.Text + @"\" + cmbFile.Text);
            while ((line = file.ReadLine()) != null)
            {
                lbArcList.Items.Add(line);
                counter++;
            }

            file.Close();
        }
    }
}
