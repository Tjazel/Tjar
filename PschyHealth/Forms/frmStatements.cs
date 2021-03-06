﻿using MetroFramework.Forms;
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
using MetroFramework.Controls;

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
            
        }

        private void metroTextBox17_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbStatCrit_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void filter()
        {
            
        }

        private void metroComboBox1_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            double balance = 0;
            int j = 0;
            String[] listA = new String[15];
            for (int i = 0; i < listA.Length; i++)
                listA[i] = "";
            int[] listNumA = new int[15];

            int[] con = {1,-1,8,-3,2,10,6,11,9,-2};//Verander 2 10
            string line;
            lbStatements.Items.Clear();
            lbStatements.Items.Add("Date	\tMethod	Code	Description	ICD 10 code	Patient	Birthday	Dependency code	Debit	Credit	Balance");
            cMethods.fillDGV(dgvStatements, "Consultations");
            for (int i = 0; i < dgvStatements.RowCount-1; i++)
            {
                line = "";
                if((cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) == dgvStatements.Rows[i].Cells["Surname"].Value.ToString()) || (cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2,1) == dgvStatements.Rows[i].Cells["Name"].Value.ToString()))
                {
                    for (int k = 0; k < con.Length; k++)
                        if (con[k] == -1)
                        {
                            line += "\t";
                        }
                        else if (con[k] == -2)
                        {
                            line += "0.00\t";
                        }
                        else if(con[k] == -3)
                        {
                            MetroGrid dgv = new MetroGrid();
                            dgv.Parent = this;
                            dgv.Hide();
                            cMethods.filterDGV(dgv,"DiagnosticCodes", " WHERE Code = '" + dgvStatements.Rows[i].Cells["Diagnostic_Code"].Value.ToString() + "'");
                            string t;
                            if (dgv.Rows[0].Cells["Assesment_type"].Value.ToString() == "Individual")
                                t = "Psych.ind";
                            else
                                t = "Psych.group";
                            line += t + "(" + dgv.Rows[0].Cells["Minutes"].Value.ToString() + "min)" + "\t";
                        }
                        else
                        {
                            if (k == 0 || k == 6)
                            {
                                string kort = dgvStatements.Rows[i].Cells[con[k]].Value.ToString();
                                line += kort.Substring(0, kort.IndexOf(" ")) + "\t";
                            }
                            else
                                line += dgvStatements.Rows[i].Cells[con[k]].Value.ToString() + "\t";
                        }
                    listA[j] = line;
                    listNumA[j] = Convert.ToInt16(dgvStatements.Rows[i].Cells["Consultation"].Value.ToString());
                    j++;
                    //lbStatements.Items.Add(line);
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
                            line += "\t";
                        }
                        else if (stat[k] == -2)
                        {
                            line += "0.00\t";
                        }
                        else
                        {
                            if(k==0 || k ==6)
                            {
                                string kort = dgvStatements.Rows[i].Cells[stat[k]].Value.ToString();
                                line += kort.Substring(0,kort.IndexOf(" ")) + "\t";
                            }    
                            else
                            line += dgvStatements.Rows[i].Cells[stat[k]].Value.ToString() + "\t";
                        }
                    listA[j] = line;
                    listNumA[j] = Convert.ToInt16(dgvStatements.Rows[i].Cells["Consultation"].Value.ToString());
                    j++;
                    //lbStatements.Items.Add(line);
                }

            }
            String tempS;
            int tempI;
            int length = listNumA.Length;
            for (int i = 0; i > length; i++)
            {
                for (int k = i + 1; k < length; k++)
                {
                    if (listNumA[i] > listNumA[k])
                    {
                        tempI = listNumA[i];
                        listNumA[i] = listNumA[k];
                        listNumA[k] = tempI;

                        tempS = listA[i];
                        listA[i] = listA[k];
                        listA[k] = tempS;
                    }
                }
            }
            double val=0;
            string temp;
            for(int i = 0; i < listA.Length;i++)
            {
                temp = listA[i];
                if (listA[i] != "")
                {
                    for(int k=0;k<8;k++)
                        temp = temp.Remove(0, temp.IndexOf("\t")+1);
                    val = Convert.ToDouble(temp.Substring(0, temp.IndexOf("\t")));
                    temp = temp.Remove(0, temp.IndexOf("\t") + 1);
                    val -= Convert.ToDouble(temp.Substring(0, temp.IndexOf("\t")))+balance;
                    lbStatements.Items.Add(listA[i] + val);
                }
                balance += val;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String txt="";
            String clientName = cmbClient.Text.Replace(" ", string.Empty);
            String name = clientName + "(" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ")" + ".docx";
            cMethods.CheckFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName);
            cMethods.copyTemplate(cmbFormat.Text, clientName);
            String n = cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2);
            String s = cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(","));
            cMethods.filterDGV(dgvStatements, "Clients", " WHERE First_Name = '" + n + "' AND Surname = '" + s + "'");

            String title;
            try
            {
                File.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + cmbFormat.Text, Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + name);
            }
            catch (IOException)
            {
                name = name.Substring(0, name.Length - 5) + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ".docx";
                File.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + cmbFormat.Text, Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + name);
            }
                object fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + clientName + @"\" + name;

            Document doc = wordApp.Documents.Open(ref fileName, ref confirmConversions, ref readOnly, ref addToRecentFiles,
            ref passwordDoc, ref passwordTemplate, ref revert, ref writepwdoc, ref writepwTemplate, ref format, ref encoding, ref visible, ref openRepair,
            ref docDirection, ref notEncoding, ref xmlTransform);
            if (dgvStatements.Rows[0].Cells["Gender"].Value.ToString() == "Male")
                title = "MR";
            else
                title = "MS";
            for (int i = 1; i < lbStatements.Items.Count; i++)
                txt += lbStatements.Items[i].ToString() + "\r\n";
            String name1 = dgvStatements.Rows[0].Cells["First_Name"].Value.ToString();
            String surname = dgvStatements.Rows[0].Cells["Surname"].Value.ToString();
            cMethods.ReplaceBookmarkText(doc, "Title", title);
            cMethods.ReplaceBookmarkText(doc, "Initials", name1);
            cMethods.ReplaceBookmarkText(doc, "Surname", surname);
            cMethods.ReplaceBookmarkText(doc, "Address", dgvStatements.Rows[0].Cells["Address"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "City", dgvStatements.Rows[0].Cells["City"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Code", dgvStatements.Rows[0].Cells["City_Code"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Date", DateTime.Now.ToShortDateString());
            cMethods.ReplaceBookmarkText(doc, "AccountNo", dgvStatements.Rows[0].Cells["Account_Number"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Medical", dgvStatements.Rows[0].Cells["Medical_Aid"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Refferal", dgvStatements.Rows[0].Cells["Referral"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "RefPrak", dgvStatements.Rows[0].Cells["Referral_Practice"].Value.ToString());

            cMethods.filterDGV(dgvStatements, "Consultations", " WHERE Name = '" + cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2) + "' AND Surname = '" + cmbClient.Text.Substring(0, cmbClient.Text.IndexOf(",")) + "'");

            cMethods.ReplaceBookmarkText(doc, "ICD10", dgvStatements.Rows[0].Cells["ICD10"].Value.ToString());
            cMethods.ReplaceBookmarkText(doc, "Info", txt);
            //String n = cmbClient.Text.Substring(cmbClient.Text.IndexOf(",") + 2);
            cMethods.ReplaceBookmarkText(doc, "D1", Convert.ToString(cMethods.calculateAmount(n, surname, dgvStatements, 120, 99999)));
            cMethods.ReplaceBookmarkText(doc, "D2", Convert.ToString(cMethods.calculateAmount(n, surname, dgvStatements, 90, 120)));
            cMethods.ReplaceBookmarkText(doc, "D3", Convert.ToString(cMethods.calculateAmount(n, surname, dgvStatements, 60, 90)));
            cMethods.ReplaceBookmarkText(doc, "D4", Convert.ToString(cMethods.calculateAmount(n, surname, dgvStatements, 30, 60)));
            cMethods.ReplaceBookmarkText(doc, "D5", Convert.ToString(cMethods.calculateAmount(n, surname, dgvStatements, 0, 30)));
            cMethods.ReplaceBookmarkText(doc, "AmountDue", Convert.ToString(cMethods.calculateAmount(n, surname, dgvStatements, 0, 99999)));


            doc.Close();
            MessageBox.Show("Statement created");
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

        private void dgvStatements_VisibleChanged(object sender, EventArgs e)
        {
            dgvStatements.Visible = false;
        }
    }
}
