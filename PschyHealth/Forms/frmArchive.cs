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
using System.Globalization;

namespace PschyHealth
{
    public partial class frmArchive : MetroForm
    {
        Methods cMethods = new Methods();

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
           

           /* //Load the Form At Position of Main Form
            int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
            int HeightOfMain = Application.OpenForms["frmMainPage"].Height;
            int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
            int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            this.Location = new Point(LocationMainX, locationMainy + 30);*/

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);
            this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

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
            string month;
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + cmbFolder.Text + @"\";
            DirectoryInfo d = new DirectoryInfo(filepath);
            cmbFile.Items.Clear();
            int pos1, pos2;
            try
            {
                foreach (var file in d.GetFiles())
                {
                    pos1 = file.Name.IndexOf("-") + 1;
                    pos2 = file.Name.IndexOf(".");
                    month = DateTimeFormatInfo.CurrentInfo.GetMonthName(Convert.ToInt16(file.Name.Substring(pos1,pos2-pos1)));
                    cmbFile.Items.Add(month + " " + file.Name.Substring(0,pos1-1));
                }
            }
            catch (FileNotFoundException el)
            {
                MessageBox.Show(el.Message);
            }
        }

        private void cmbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string monthName = DateTime.ParseExact(cmbFile.Text.Substring(0, cmbFile.Text.IndexOf(" ")), "MMMM", CultureInfo.CurrentCulture).Month.ToString();
            string year = cmbFile.Text.Substring(cmbFile.Text.IndexOf(" ") + 1, 4);
            string fileName = year + "-" + monthName + ".txt";
            lbArcList.Items.Clear();
            // Read the file and display it line by line.
            StreamReader file =
               new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + cmbFolder.Text + @"\" + fileName);
            while ((line = file.ReadLine()) != null)
            {
                lbArcList.Items.Add(line);
                counter++;
            }

            file.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string fields = "";
            string row = lbArcList.Items[lbArcList.SelectedIndex].ToString();
            string key = row.Substring(0, row.IndexOf(";"));
            string values = "";
            String table = cmbFolder.Text.Substring(0,cmbFolder.Text.Length-7);

            MetroGrid dgv = new MetroGrid();
            dgv.Parent = this;
            cMethods.fillDGV(dgv, table);

            for(int i = 0; i < dgv.ColumnCount; i++)
            {
                fields += dgv.Columns[i].Name + ",";
                if(dgv.Columns[i].Name=="Amount")
                    values += row.Substring(0, row.IndexOf(";")) + ",";
                else
                    values += "'" + row.Substring(0, row.IndexOf(";")) + "',";
                row = row.Remove(0, row.IndexOf(";") + 1);
            }
            fields = fields.Substring(0, fields.Length - 1);
            values = values.Substring(0, values.Length - 1);
            cMethods.add(table, fields, values);
            dgv.Hide();
            dgv = null;

            string monthName = DateTime.ParseExact(cmbFile.Text.Substring(0, cmbFile.Text.IndexOf(" ")), "MMMM", CultureInfo.CurrentCulture).Month.ToString();
            string year = cmbFile.Text.Substring(cmbFile.Text.IndexOf(" ") + 1, 4);
            string name = year + "-" + monthName + ".txt";
            String fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + cmbFolder.Text + @"\" + name;
            var tempFile = Path.GetTempFileName();

            var linesToKeep = File.ReadLines(fileName).Where(l => l != lbArcList.SelectedItem.ToString());

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(fileName);
            File.Move(tempFile, fileName);

            lbArcList.Items.RemoveAt(lbArcList.SelectedIndex);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
