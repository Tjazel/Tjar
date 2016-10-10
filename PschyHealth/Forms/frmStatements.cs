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
using System.IO;
using System.Globalization;
using Microsoft.Office.Interop.Word;
using System.Threading;
using System.Diagnostics;

namespace PschyHealth
{
    public partial class frmStatements : MetroForm
    {
        string filename;
        

        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

        object fileName = @"C:\Templates\VerslagPschyHealth.docx";
        object confirmConversions = Type.Missing;
        object readOnly = Type.Missing;
        object addToRecentFiles = Type.Missing;
        object passwordDoc = Type.Missing;
        object passwordTemplate = Type.Missing;
        object revert = Type.Missing;
        object writepwdoc = Type.Missing;
        object writepwTemplate = Type.Missing;
        object format = Type.Missing;
        object encoding = Type.Missing;
        object visible = Type.Missing;
        object openRepair = Type.Missing;
        object docDirection = Type.Missing;
        object notEncoding = Type.Missing;
        object xmlTransform = Type.Missing;

        Methods cMethods = new Methods();
        String correctSearch = "";
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);


        protected override void OnLoad(EventArgs e)
        {
            cMethods.readTheme(msmStatements);
            cMethods.readStyle(msmStatements);
            /*

            //Load the Form At Position of Main Form
            int WidthOfMain = Application.OpenForms["frmMainPage"].Width;
            int HeightofMain = Application.OpenForms["frmMainPage"].Height;
            int LocationMainX = Application.OpenForms["frmMainPage"].Location.X;
            int locationMainy = Application.OpenForms["frmMainPage"].Location.Y;

            //Set the Location
            this.Location = new Point(LocationMainX, locationMainy + 30);
            */

            //Animate form
            AnimateWindow(this.Handle, 800, AW_SLIDE | AW_HOR_POSITIVE);
            this.WindowState = FormWindowState.Maximized;
            ucToolbar uc = new ucToolbar();
            this.Controls.Add(uc);

            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\StatementTemplates\";
            DirectoryInfo d = new DirectoryInfo(filepath);
            cmbFormat.Items.Clear();
            foreach (var file in d.GetFiles())
            {
                cmbFormat.Items.Add(file.Name);
            }


            cMethods.fillDGV(dgvStatements, "Clients");
            
            cMethods.fillCMBrow(cmbClient, dgvStatements);
        }
        public frmStatements()
        {
            InitializeComponent();
            this.StyleManager = msmStatements;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStatements_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvStatements_SelectionChanged_1(object sender, EventArgs e)
        {
            cMethods.fillTextbox(groupBox3, dgvStatements, "Stat", false);
        }

        private void pbBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStatements_Load(object sender, EventArgs e)
        {
            ucToolbar uc = new ucToolbar();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void cmbStatCrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox17.Clear();
            metroComboBox1.Text = "";
            if (cmbStatCrit.Text != "")
            {
                metroTextBox17.Enabled = true;
            }
            else
            {
                metroTextBox17.Enabled = false;
                metroTextBox17.Text = "";
            }
        }

        private void metroTextBox17_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox17.Text == "")
                cMethods.fillDGV(dgvStatements, "Clients");
            else if (metroTextBox17.Text == String.Concat(metroTextBox17.Text.Where(Char.IsLetterOrDigit)))
            {
                filter();
                correctSearch = metroTextBox17.Text;
            }
            else
            {
                MessageBox.Show("Only numeric and alphabetic caracters are allowed");
                metroTextBox17.Text = correctSearch;
                metroTextBox17.Focus();
                metroTextBox17.SelectionStart = metroTextBox17.Text.Length;
            }
        }

        private void cmbStatCrit_TextChanged(object sender, EventArgs e)
        {
            metroTextBox17.Clear();
            metroComboBox1.SelectedIndex = -1;
            if (cmbStatCrit.Text != "")
            {
                metroTextBox17.Enabled = true;

            }
            else
            {
                metroTextBox17.Enabled = false;
                metroTextBox17.Text = "";
            }
            cMethods.fillDGV(dgvStatements, "Clients");
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex != -1)
                metroTextBox17.Enabled = true;
            metroTextBox17.Clear();
        }

        private void filter()
        {
            if (metroTextBox17.Text != "")
                if (!metroComboBox1.Visible)
                {
                    cMethods.filterDGV(dgvStatements, "Clients", " WHERE " + cmbStatCrit.Text + " LIKE '%" + metroTextBox17.Text + "%'");
                }
                else
                {
                    cMethods.filterDGV(dgvStatements, "Clients", " WHERE " + cmbStatCrit.Text + " " + metroComboBox1.Text + " " + metroTextBox17.Text);
                }
        }

        private void metroComboBox1_VisibleChanged(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            if (metroComboBox1.Visible == true)
                metroTextBox17.Enabled = false;
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] con = {1,-1,8,7,2,10,6,11,-2,9};//Verander 2 10
            string line;
            lbStatements.Items.Clear();
            lbStatements.Items.Add("Date	Method	Code	Description	ICD 10 code	Patient	Birthday	Dependency code	Debit	Credit	Balance");
            cMethods.fillDGV(dgvStatements, "Consultations");
            for (int i = 0; i < dgvStatements.RowCount-1; i++)
            {
                line = "";
                if((cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) == dgvStatements.Rows[i].Cells["Surname"].Value.ToString()) || (cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2,1) == dgvStatements.Rows[i].Cells["Name"].Value.ToString()))
                {
                    for (int k = 0; k < con.Length; k++)
                        if (con[k] == -1)
                        {
                            line += ";\t";
                        }
                        else if (con[k] == -2)
                        {
                            line += "00.00\t";
                        }
                        else
                            line += dgvStatements.Rows[i].Cells[con[k]].Value.ToString() + ";\t";
                    lbStatements.Items.Add(line);
                }
                
            }
            int[] stat = {5,1,-1,2,-1,-1,-1,-1,-2,4};
            cMethods.fillDGV(dgvStatements, "Payments");
            for (int i = 0; i < dgvStatements.RowCount - 1; i++)
            {
                line = "";
                if ((cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) == dgvStatements.Rows[i].Cells["Client_Surname"].Value.ToString()) || (cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2) == dgvStatements.Rows[i].Cells["Client_Name"].Value.ToString()))
                {
                    for (int k = 0; k < stat.Length; k++)
                        if (stat[k] == -1)
                        {
                            line += ";\t";
                        }
                        else if (stat[k] == -2)
                        {
                            line += "00.00\t";
                        }
                        else
                            line += dgvStatements.Rows[i].Cells[stat[k]].Value.ToString()+";\t";
                    lbStatements.Items.Add(line);
                }

            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String txt="";
            String clientName = cmbClient.Text.Replace(" ", string.Empty);
            String name = clientName + "(" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ")" + ".docx";
            cMethods.CheckFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName);
            cMethods.copyTemplate(cmbFormat.Text, clientName);

            cMethods.filterDGV(dgvStatements, "Clients", " WHERE First_Name = '" + clientName.Substring(clientName.IndexOf(",")+1) + "' AND Surname = '" + clientName.Substring(0,clientName.IndexOf(",")) + "'");

            String title;
            File.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + cmbFormat.Text, Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + name);
            object fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + name;

            Document doc = wordApp.Documents.Open(ref fileName, ref confirmConversions, ref readOnly, ref addToRecentFiles,
            ref passwordDoc, ref passwordTemplate, ref revert, ref writepwdoc, ref writepwTemplate, ref format, ref encoding, ref visible, ref openRepair,
            ref docDirection, ref notEncoding, ref xmlTransform);
            if (dgvStatements.Rows[0].Cells["Gender"].Value.ToString() == "Male")
                title = "MR";
            else
                title = "MS";
            for (int i = 1; i < lbStatements.Items.Count; i++)
                txt += lbStatements.Items[i].ToString();
            cMethods.ReplaceBookmarkText(doc, "Title", title);
            cMethods.ReplaceBookmarkText(doc, "Initials", dgvStatements.Rows[0].Cells["First_Name"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Surname", dgvStatements.Rows[0].Cells["Surname"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Address", dgvStatements.Rows[0].Cells["Address"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "City", dgvStatements.Rows[0].Cells["City"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Code", dgvStatements.Rows[0].Cells["City_Code"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Date", DateTime.Now.ToShortDateString());
            cMethods.ReplaceBookmarkText(doc, "AccountNo", dgvStatements.Rows[0].Cells["Account_Number"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Medical", dgvStatements.Rows[0].Cells["Medical_Aid"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Refferal", dgvStatements.Rows[0].Cells["Referral"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "RefPrak", dgvStatements.Rows[0].Cells["Referral_Practice"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "ICD10", "Dit Werk");
            cMethods.ReplaceBookmarkText(doc, "Info", txt);


            doc.Close();
        }

        private void cmbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbClient_Click(object sender, EventArgs e)
        {
           // if(cmbClient.Items.Count == 0)
              //  cMethods.fillCMBrow(cmbClient, dgvStatements);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(
            Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements";
            DialogResult dr = openFileDialog1.ShowDialog();
            string[] s = openFileDialog1.FileName.Split('.');
            if (dr.ToString() == "OK")
            {
                if (s.Length > 1)
                    if (s[1] == "doc" || s[1] == "docx" || s[1] == "jpg")
                        filename = openFileDialog1.FileName;
                    else
                        MessageBox.Show("Please select doc,docx,jpeg file !!");
            }

            if (string.IsNullOrEmpty(filename.Trim()))
            {

                MessageBox.Show("Please Select file.");
                return;
            }

            ProcessStartInfo info = new ProcessStartInfo(filename.Trim());
            info.Verb = "Print";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(info);
        }
    }
}
