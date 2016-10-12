using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Drawing;
using MetroFramework.Controls;
using System.Data.SqlClient;
using Microsoft.Office.Interop;
using System.Threading;
using System.Configuration;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Text.RegularExpressions;



namespace PschyHealth
{
    //The Methods class saves a sertain methods and procedures that will be used in the program more than once.
    //The main reason for this class is to reuse code, thus not making the program too large, and also making it more efficient.
    class Methods
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment";

        String connectionString =
                "Data Source = jarvisdevelopment.database.windows.net; Initial Catalog =JarvisDev; User ID =ProjectJarvis; Password =JarvisProject2016;";

        SqlConnection conn = new SqlConnection("Data Source=jarvisdevelopment.database.windows.net;Initial Catalog=JarvisDev;User ID =ProjectJarvis; Password =JarvisProject2016;");
        //The fillDGV method is used to fill a datagridview with the information gathered from the database
        //The first fillDGV method is used to simply fill the metro grid with no extra operations.
        public void fillDGV(MetroGrid dgv, String sTable)
        {
            filterDGV(dgv, sTable, "");                                                       //The method calls the filterDGV, but with empty paramaters to only fill the metro grid
        }

        //The second fillDGV method does not only fill the metrogrid, but also reads the coulumn names directly into a metroComboBox that is used when filtered.
        public void fillDGV(MetroGrid dgv, String sTable, MetroComboBox cmb)
        {
            filterDGV(dgv, sTable, "");                                                       //The addition of a metroComboBox will ensure that the combobox is filled to be used in filters
            fillCMB(cmb, dgv);
        }

        //The filterDGV method is used to fill the metro grid and also to filter it
        //If a string is specified, the metro grid will be filled and filtered

        public void silentFillDGV(MetroGrid dgv, String sTable, Boolean silent)
        {
            silentFillDGV(dgv, sTable, "", true);
        }



        public void silentFillDGV(MetroGrid dgv, String sTable, String filter, Boolean silent)
        {
            pnlDBLoadingMessege uc = new pnlDBLoadingMessege();
            //This panel is created and made visable so that the user can see that the database is busy connecting
            //The silent fill is used when the program is endeing and the system musn't show error messages when timed out
            if (!silent)
            {
                uc.Hide();
                uc.Parent = frmMainPage.ActiveForm;
                uc.Left = 500;
                uc.Top = 300;
                uc.Show();
                uc.BringToFront();

                
            }
            //This code allows the programs GUI to load completely without a delay
            Application.DoEvents();
            //await Task.Delay(50);
            Thread.Sleep(1000);
            try//Try to catch all exeptions and retry
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                BindingSource bindingSource1 = new BindingSource();



                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter("SELECT * FROM " + sTable + filter, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dgv.DataSource = table;
                dgv.BringToFront();
                //dgv.AutoResizeColumns(
                //DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                if (!silent)
                {
                    uc.Hide();

                    uc.SendToBack();
                    uc.Visible = false;
                    uc = null;
                }
            }
            catch (SqlException e)
            {
                
                String mes = e.Message.Substring(0, 17);
                //MessageBox.Show(e.Message);
                if (!silent)
                {
                    if (mes == "A network-related")//This error means that the connection is delayed and will have to reconnect
                    {
                        DialogResult result = MessageBox.Show("Connection timed out. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //Reconnectiong immediately creates an error, and therefore the program must be paused for 5 seconds before reconnecting
                            Thread.Sleep(5000);
                            uc.Visible = false;
                            recallFilter(dgv, sTable, filter);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Connection error. Reconnect? If this error persists, contact us.", "Reconnect", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            uc.Visible = false;
                            recallFilter(dgv, sTable, filter);
                        }
                    }

                }
                else
                {
                    Thread.Sleep(5000);
                    uc.Visible = false;
                    recallFilter(dgv, sTable, filter);
                }


            }
            catch (Exception e)
            {
                uc.Visible = false;
                //MessageBox.Show(e.Message);
                DialogResult result = MessageBox.Show("Connection error. Reconnect? If this error persists, contact us.", "Reconnect", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    uc.Visible = false;
                    recallFilter(dgv, sTable, filter);
                }
            }
        }

        /*public string fillText(string buttonText)
        {
            if (buttonText == "Maandeliks")
            {
                string good = "";
                for (int i = 0; i <= 12; i++)
                {
                    good += "Total income for the ";
                    double goodSum = 0, badSum = 0;
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;
                    cmd.CommandText = "SELECT * FROM Accounting WHERE Date LIKE @P1 AND Type = Income";
                    cmd.Parameters.AddWithValue("@P1", "*-*" + Convert.ToString(i) + "*");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        goodSum += Convert.ToDouble(reader["Amount"].ToString());
                    }
                    reader.Close();
                    good += Convert.ToString(i) + "th month :R" + Convert.ToString(goodSum) + "/r/n";
                }
                string bad = "";
                for (int i = 0; i <= 12; i++)
                {
                    bad += "Total expense for the ";
                    double badSum = 0;
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;
                    cmd.CommandText = "SELECT * FROM Accounting WHERE Date LIKE @P1 AND Type <> Income";
                    cmd.Parameters.AddWithValue("@P1", "*-*" + Convert.ToString(i) + "*");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        badSum += Convert.ToDouble(reader["Amount"].ToString());
                    }
                    reader.Close();
                    bad += Convert.ToString(i) + "th month :R" + Convert.ToString(badSum) + "/r/n";
                }
                buttonText = good + bad;
            }
            if (buttonText == "Geldvloei")
            {

            }
            conn.Close();
            return buttonText;
        }*/
        //Method used to encrypt the passwords when sent to the database
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        //Method used to decrypt encrypted passwords
        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        //Hierdie is die kode vir die Login
        public bool checkLogin(String username, String password)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader, searcher;
            string values = "";
            cmd.CommandText = "SELECT * FROM Staff WHERE Username = @P1 AND Password = @P2";
            cmd.Parameters.AddWithValue("@P1", username);
            cmd.Parameters.AddWithValue("@P2", Encrypt(password));
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();


            searcher = cmd.ExecuteReader();
            while (searcher.Read())
            {
                values = searcher["Admin"].ToString();
            }
            searcher.Close();
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            // Data is accessible through the DataReader object here.
            if (dt.Rows.Count == 1)
            {
                checkLogin(username, password, true, values);
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }


        }



        public bool checkLogin(String username, String password, Boolean correct, String admin)
        {
            if (admin == "False")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //This method is used to filter a metrogrid
        //This code reuses the silent fill, to reduce the size of the program
        public void filterDGV(MetroGrid dgv, String sTable, String filter)
        {
            silentFillDGV(dgv, sTable, filter, false);
        }
        //This method is an alternative to recursive calling.
        //Because a method has to be static to be called recursively, it cannot connect to the database
        //This method recalls the method so that it can be reused when an error occur.
        private void recallFilter(MetroGrid dgv, String sTable, String filter)
        {
            filterDGV(dgv, sTable, filter);
        }


        //This method fills the search combobox when the metrogrid is filled, so that a field can be chosen without errors when filtering
        public void fillCMB(MetroComboBox cmb, MetroGrid dgv)
        {
            cmb.Items.Clear();
            for (int i = 0; i < dgv.ColumnCount; i++)
                cmb.Items.Add(dgv.Columns[i].Name);
        }
        //This method fills 2 comboboxes by using a metrogrids rows
        //This is also used to reduce incorrect inputs
        public void fillCMBrow(MetroComboBox cmb1, MetroComboBox cmb2, MetroGrid dgv,String s1, String s2)
        {
            if (cmb1 != null)
                cmb1.Items.Clear();
            if (cmb2 != null)
                cmb2.Items.Clear();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (cmb1 != null)
                    cmb1.Items.Add(dgv.Rows[i].Cells[s1].Value.ToString());
                if (cmb2 != null)
                    cmb2.Items.Add(dgv.Rows[i].Cells[s2].Value.ToString());
            }
        }
        //This method calls the method above and does the same thing but for the set columns First_Name and Surname
        public void fillCMBrow(MetroComboBox cmb1, MetroComboBox cmb2, MetroGrid dgv)
        {
            fillCMBrow(cmb1, cmb2, dgv, "First_Name", "Surname");
        }
        //This method combines the clients name and surname divided by a "," to easily pick the user in a combobx
        public void fillCMBrow(MetroComboBox cmb, MetroGrid dgv)
        {
            cmb.Items.Clear();
            string entry;
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                entry = dgv.Rows[i].Cells["Surname"].Value.ToString() + ", " + dgv.Rows[i].Cells["First_Name"].Value.ToString();
                if (!cmb.Items.Contains(entry))
                    cmb.Items.Add(entry);
            }
        }
        //This method is used to input all the data of the chosen row of a certain metrogrid into textboxes an comboboxes, or to empty an enable it
        //The method recieves a groupbox and compares its controls names and tipes with the database table to fill the controls
        public void fillTextbox(GroupBox gb, MetroGrid dgv, String extra, Boolean enabled, Boolean empty)
        {
            try
            {
                foreach (Control obj in gb.Controls)
                {
                    if (obj is MetroTextBox) 
                        extra = "txt" + extra;
                    else if ((obj is MetroComboBox)|| (obj is MetroDateTime))
                        extra = "cmb" + extra;
                    else
                        goto out1;
                    obj.Enabled = enabled;
                    if (empty)
                        obj.Text = "";
                    else
                    {
                        Boolean fin = false;
                        int i = 0;
                        while ((i < dgv.ColumnCount) && (!fin))
                        {
                            if (extra + dgv.Columns[i].Name == obj.Name)
                            {
                                obj.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[i].Value.ToString();
                                fin = true;
                            }
                            else
                                i++;
                        }
                        extra = extra.Substring(3, extra.Length - 3);
                    }
                out1:;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }


        }
        //This method calls the method above with a fixed empty setting to false(default)
        public void fillTextbox(GroupBox gb, MetroGrid dgv, String extra, Boolean enabled)
        {
            fillTextbox(gb, dgv, extra, enabled, false);
        }
        //This method checks for a path and if it does not exist, this method creates it
        public void CheckFolder(String path)
        {
            if (!File.Exists(path))
                Directory.CreateDirectory(path);
        }
        //This method appends string to a textfile after checking if it exists
        public void WriteFile(String path, String txt)
        {
            CheckFile(path);
            File.AppendAllText(path + ".txt", txt);
        }
        //Tests if a file exists and if not, it is created
        public void CheckFile(String path)
        {
            if (!File.Exists(path + ".txt"))
            {
                StreamWriter outStream;
                outStream = File.CreateText(path + ".txt");
                outStream.Write("");
                outStream.Close();
            }
        }
        //Manually archives certain rows in a table
        public void Archive(MetroGrid dgv, String table, String field, String crit)
        {
            Archive(dgv, table, field, crit, 0);
        }
        //Manually archives certain rows in certain tables, determined by the date that it was last used
        public void Archive(MetroGrid dgv, String table, String field, String crit, int month)
        {
            String arch = "";
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells[field].Value.ToString() == crit)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        arch += dgv.Rows[i].Cells[j].Value.ToString() + ";";
                    }
                    arch += "\r\n";
                    WriteFile(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + table + @"Archive\" + DateTime.Now.Year.ToString() + @"-" + (Convert.ToInt16(DateTime.Now.Month.ToString()) - month), arch);
                    delete(table, field + "='" + crit + "'");
                }

            }

        }
        //Automatically archives data based on when it was used last
        public void Archive(MetroGrid dgv, String table, double months)
        {
            String arch = "";
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                String date = dgv.Rows[i].Cells["Date"].Value.ToString();
                int index1 = date.IndexOf(@"/");
                int index2 = date.LastIndexOf(@"/");
                int year = Convert.ToInt16(date.Substring(index2 + 1, 4));
                int mon = Convert.ToInt16(date.Substring(0, index1));
                int day = Convert.ToInt16(date.Substring(index1 + 1, index2 - index1 - 1));
                double diff = (Convert.ToInt16(DateTime.Now.Year) - year) * 12 + (Convert.ToInt16(DateTime.Now.Month) - mon) + (Convert.ToInt16(DateTime.Now.Day) - day) / 30;
                if (diff > months && months < 600)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        arch += dgv.Rows[i].Cells[j].Value.ToString() + ";";
                    }
                    arch += "\r\n";
                    delete(table, dgv.Columns[0].ToString() + "='" + dgv.Rows[i].Cells[0].Value.ToString() + "'");
                }
            }
            WriteFile(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + table + @"Archive\" + DateTime.Now.Year.ToString() + @"-" + DateTime.Now.Month.ToString(), arch);
        }
        //Testing the validity of a number and sending back a boolean
        public Boolean validNumber(String txt)
        {
            string[] valids = { "." };
            if (txt == String.Concat(txt.Where(Char.IsDigit)))
            {
                return true;
            }
            else
            {
                txt = String.Concat(txt.Where(Char.IsPunctuation));
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(valids.Contains(Convert.ToString(txt[i]))))
                    {
                        return false;
                    }
                    else
                    {
                        valids[0] = "";
                    }
                }
                return true;
            }
        }
        //Testing the validity of a String and sending back a boolean
        public Boolean validString(String txt)
        {
            char[] valids = { ' ', '.', '-' };
            if (txt == String.Concat(txt.Where(Char.IsLetterOrDigit)))
            {
                return true;
            }
            else
            {
                txt = String.Concat(txt.Where(Char.IsPunctuation));
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(valids.Contains(txt[i])))
                    {
                        return false;
                    }
                }
                return true;
            }

        }
        //Testing the validity of a date and sending back a boolean
        public Boolean validDate(String txt)
        {
            int k = 0;
            char[] valids = { '/' };
            String dtxt = String.Concat(txt.Where(Char.IsLetterOrDigit));
            String ptxt = String.Concat(txt.Where(Char.IsPunctuation));
            for (int i = 0; i < ptxt.Length; i++)
            {
                if (!(valids.Contains(txt[i])))
                {
                    return false;
                }
                else
                    k++;
                if (k > 2)
                    return false;
            }
            if (dtxt != String.Concat(txt.Where(Char.IsDigit)) || (dtxt.Length > 8) || (dtxt.Length < 6))
            {
                return false;
            }
            return true;
        }


        //Main page se tile kleure vind hier plaas

        DevComponents.DotNetBar.Metro.MetroTileItem Knoppie = new DevComponents.DotNetBar.Metro.MetroTileItem();
        public void defStyle()
        {
            string filename = path + @"\Styles\style\style.txt";
            MetroFramework.MetroColorStyle cl = new MetroFramework.MetroColorStyle();
            cl = (MetroFramework.MetroColorStyle)4;
            StreamWriter write = File.AppendText(filename);

            if (new FileInfo(filename).Length == 0)
            {
                write.WriteLine("" + cl + "");
                write.Close();
            }
            else
            {
                write.Close();
            }
        }

        public void writeStyle(MetroFramework.Components.MetroStyleManager manager, MetroFramework.MetroColorStyle cl)
        {
            string filename = path + @"\Styles\style\style.txt";
            string line;
            StreamReader lees = File.OpenText(filename);
            line = lees.ReadLine();
            if (line != null)
            {
                line = line.Replace(line, "" + cl + "");
                lees.Close();
                // MessageBox.Show(line);
                File_DeleteLine(1, filename);
            }

            StreamWriter write = File.AppendText(filename);
            write.WriteLine(line);
            write.Close();

        }

        public void readStyle(MetroFramework.Components.MetroStyleManager manager)
        {
            string filename = path + @"\Styles\style\style.txt";
            MetroFramework.MetroColorStyle chosenStyle = new MetroFramework.MetroColorStyle();
            StreamReader lees = File.OpenText(filename);
            string line = lees.ReadLine();




            switch (line)
            {
                case "Black":
                    chosenStyle = (MetroFramework.MetroColorStyle)1;
                    changeStyle(manager, chosenStyle);
                    break;

                case "White":
                    chosenStyle = (MetroFramework.MetroColorStyle)2;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Silver":
                    chosenStyle = (MetroFramework.MetroColorStyle)3;
                    changeStyle(manager, chosenStyle);
                    break;

                case "Blue":
                    chosenStyle = (MetroFramework.MetroColorStyle)4;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Green":
                    chosenStyle = (MetroFramework.MetroColorStyle)5;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Lime":
                    chosenStyle = (MetroFramework.MetroColorStyle)6;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Teal":
                    chosenStyle = (MetroFramework.MetroColorStyle)7;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Orange":
                    chosenStyle = (MetroFramework.MetroColorStyle)8;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Brown":
                    chosenStyle = (MetroFramework.MetroColorStyle)9;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Pink":
                    chosenStyle = (MetroFramework.MetroColorStyle)10;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Magenta":
                    chosenStyle = (MetroFramework.MetroColorStyle)11;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Purple":
                    chosenStyle = (MetroFramework.MetroColorStyle)12;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Red":
                    chosenStyle = (MetroFramework.MetroColorStyle)13;
                    changeStyle(manager, chosenStyle);
                    break;
                case "Yellow":
                    chosenStyle = (MetroFramework.MetroColorStyle)14;
                    changeStyle(manager, chosenStyle);
                    break;

            }

            lees.Close();
            changeStyle(manager, chosenStyle);
        }

        public void changeStyle(MetroFramework.Components.MetroStyleManager manager, MetroFramework.MetroColorStyle cl)
        {
            manager.Style = cl;
        }
        public void defTileColors()
        {
            string filename = path + @"\Styles\TileColors\tileColors.txt";
            StreamWriter write = File.AppendText(filename);


            if (new FileInfo(filename).Length == 0)
            {

                write.WriteLine("btn_StaffNew/ Teal " + "\r\n" +
                               "btnClients/ Teal " + "\r\n" +
                               "btnAccounting/ Teal " + "\r\n" +
                               "btnPayments/ Teal " + "\r\n" +
                               "btnMedicalAid/ Teal " + "\r\n" +
                               "btnConsultations/ Teal " + "\r\n" +
                               "btnDiagnostic/ Teal " + "\r\n" +
                               "btnReports/ Teal " + "\r\n" +
                               "btnArchive/ Teal " + "\r\n" +
                               "btnEmail/ Teal " + "\r\n" +
                               "btnNotePad/ Teal " + "\r\n" +
                               "btnCalender/ Teal " + "\r\n" +
                               "btnAdressBook/ Teal " + "\r\n" +
                               "btnStatements/ Teal " + "\r\n" +
                               "btnStatistics/ Teal " + "\r\n" +
                               "btnICD10/ Teal " + "\r\n" +
                               "btnRecordings/ Teal " + "\r\n" +
                               "btnDateAndTime/ Teal " + "\r\n" +
                               "btnInfo/ Teal " + "\r\n");
                write.Close();
            }
            else
            {

                write.Close();
            }



        }
        public void dieKnoppie(DevComponents.DotNetBar.Metro.MetroTileItem keuse)
        {
            Knoppie = keuse;
        }

        public void fnTileColor(DevComponents.DotNetBar.Metro.MetroTileItem keuse, DevComponents.DotNetBar.Metro.eMetroTileColor kl)
        {
            keuse.TileColor = kl;
        }

        public void kleur(DevComponents.DotNetBar.Metro.eMetroTileColor kl)

        {
            Knoppie.TileColor = kl;
            writeToStylesTileColor(Knoppie, kl);

        }

        public void pos(Form frm, Panel pnl)
        {
            frm.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            pnl.Location = new Point(posX, posY);
            pnl.Show();
        }

        public void readFromStyleColor(DevComponents.DotNetBar.Metro.MetroTileItem keuse)
        {

            DevComponents.DotNetBar.Metro.eMetroTileColor el = new DevComponents.DotNetBar.Metro.eMetroTileColor();
            string line;
            string[] words = new string[2];
            char[] sep = { '/' };
            bool found = false;
            StreamReader lees;
            string filename = path + @"\Styles\TileColors\tileColors.txt";


            //lees die knoppie en kleur wat verander moet word
            lees = File.OpenText(filename);
            line = lees.ReadLine();

            while (found == false)
            {
                // line = lees.ReadLine();

                words = line.Split(sep);
                if (words[0] == keuse.Name)
                {
                    // MessageBox.Show(words[1]);
                    switch (words[1].Trim())
                    {
                        case "Green":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
                            fnTileColor(keuse, el);

                            found = true;
                            //  inputStream.Close();
                            break;

                        case "Orange":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
                            fnTileColor(keuse, el);
                            found = true;
                            //  inputStream.Close();
                            break;

                        case "Magenta":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
                            fnTileColor(keuse, el);
                            found = true;
                            //  inputStream.Close();
                            break;

                        case "Blue":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
                            fnTileColor(keuse, el);
                            found = true;
                            //  inputStream.Close();
                            break;

                        case "Teal":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Plum":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Coffee":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "RedOrange":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "RedViolet":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Olive":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
                            fnTileColor(keuse, el);
                            found = true;
                            //  inputStream.Close();
                            break;

                        case "DarkOlive":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkOlive;
                            fnTileColor(keuse, el);
                            found = true;
                            //  inputStream.Close();
                            break;

                        case "Rust":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Rust;
                            fnTileColor(keuse, el);
                            found = true;
                            //  inputStream.Close();
                            break;

                        case "Maroon":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Maroon;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Yellowish":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Blueish":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "DarkBlue":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Yellow":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellow;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Gray":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
                            fnTileColor(keuse, el);
                            found = true;
                            //  inputStream.Close();
                            break;

                        case "DarkGreen":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "MaroonWashed":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.MaroonWashed;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "PlumWashed":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.PlumWashed;
                            fnTileColor(keuse, el);
                            found = true;
                            // inputStream.Close();
                            break;

                        case "Azure":
                            el = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
                            fnTileColor(keuse, el);
                            found = true;
                            lees.Close();
                            break;

                    }

                }
                else
                {
                    line = lees.ReadLine();
                }


            }
            lees.Close();


        }

        void File_DeleteLine(int Line, string Path)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(Path))
            {
                int Countup = 0;
                while (!sr.EndOfStream)
                {
                    Countup++;
                    if (Countup != Line)
                    {
                        using (StringWriter sw = new StringWriter(sb))
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(sb.ToString());
            }
        }

        public void writeToStylesTileColor(DevComponents.DotNetBar.Metro.MetroTileItem keuse, DevComponents.DotNetBar.Metro.eMetroTileColor kl)
        {

            int lineNumber = 0;

            string line;
            string[] words = new string[2];
            char[] sep = { '/' };
            bool found = false;
            StreamReader inputStream;
            string filename = path + @"\Styles\TileColors\tileColors.txt";


            //Kry die knoppie en kleur wat verander moet word
            inputStream = File.OpenText(filename);
            line = inputStream.ReadLine();

            while (line != null && found == false)
            {
                lineNumber++;
                words = line.Split(sep);
                if (words[0] == keuse.Name)
                {
                    words[1] = " " + kl + " ";
                    inputStream.Close();
                    File_DeleteLine(lineNumber, filename);


                    // MessageBox.Show(words[0] + words[1]);

                    StreamWriter write = File.AppendText(path + @"\Styles\TileColors\tileColors.txt");
                    write.WriteLine(keuse.Name + "/" + words[1]);
                    write.Close();



                    found = true;
                }
                else
                {
                    line = inputStream.ReadLine();
                }

            }
            inputStream.Close();
            readFromStyleColor(keuse);

        }

        public void changeTheme(MetroFramework.Components.MetroStyleManager manager, MetroFramework.MetroThemeStyle styl)
        {
            manager.Theme = styl;

        }

        public void defTheme()
        {
            string filename = path + @"\Styles\Theme\theme.txt";
            StreamWriter write = File.AppendText(filename);


            if (new FileInfo(filename).Length == 0)
            {
                MetroFramework.MetroThemeStyle stylDefault = new MetroFramework.MetroThemeStyle();
                write.WriteLine("" + stylDefault + "");


                write.Close();
            }
            else
            {
                write.Close();
            }


        }
        public void writeTheme(MetroFramework.Components.MetroStyleManager manager, MetroFramework.MetroThemeStyle styl)
        {
            string filename = path + @"\Styles\Theme\theme.txt";
            string line;
            StreamReader lees = File.OpenText(filename);
            line = lees.ReadLine();
            if (line != null)
            {
                line = line.Replace(line, "" + styl + "");
                lees.Close();
                //  MessageBox.Show(line);
                File_DeleteLine(1, filename);
            }

            StreamWriter write = File.AppendText(filename);
            write.WriteLine(line);
            write.Close();
            readTheme(manager);


        }

        public void readTheme(MetroFramework.Components.MetroStyleManager manager)
        {
            string filename = path + @"\Styles\Theme\theme.txt";
            MetroFramework.MetroThemeStyle chosenStyle = new MetroFramework.MetroThemeStyle();
            StreamReader lees = File.OpenText(filename);
            string line = lees.ReadLine();

            if (line == "Dark")
            {
                chosenStyle = MetroFramework.MetroThemeStyle.Dark;
            } else
            {
                chosenStyle = MetroFramework.MetroThemeStyle.Default;
            }
            changeTheme(manager, chosenStyle);
            lees.Close();
        }

        public void cloneTheme(MetroFramework.Forms.MetroForm main, MetroFramework.Forms.MetroForm sub)
        {
            sub.StyleManager = main.StyleManager;
            main.StyleManager.Clone(sub);
        }



        //The following method copies a template to a new name
        public void copyTemplate(String name, String newName)
        {
            string fileName = name;
            string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\StatementTemplates\";
            string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Statements\" + newName;

            // Use Path class to manipulate file and directory paths.
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            File.Copy(sourceFile, destFile, true);

            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            if (Directory.Exists(sourcePath))
            {
                string[] files = Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = Path.GetFileName(s);
                    destFile = Path.Combine(targetPath, fileName);
                    File.Copy(s, destFile, true);
                }
            }
        }
        //This method replaces a bookmark in a template whith text
        public void ReplaceBookmarkText(Microsoft.Office.Interop.Word.Document doc, string bookmarkName, string text)
        {
            if (doc.Bookmarks.Exists(bookmarkName))
            {
                Object name = bookmarkName;
                Microsoft.Office.Interop.Word.Range range =
                doc.Bookmarks.get_Item(ref name).Range;
                range.Text = text;
                object newRange = range;
                doc.Bookmarks.Add(bookmarkName, ref newRange);
            }

        }
        //A method that adds data using sql into the database
        public void add(String table, String field, String values)
        {
            /*SqlDataReader reader;
            

            cmd.CommandText = "INSERT INTO @P1 VALUES (@P2)";
            cmd.Parameters.AddWithValue("@P1", table);
            cmd.Parameters.AddWithValue("@P2", field);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();*/


            /*SqlCommand cmd = new SqlCommand();
            string saveStaff = "INSERT into " + table + " (" + field + ") " + " VALUES ('" + values + "');";
            cmd = new SqlCommand(saveStaff, conn);
            cmd.ExecuteNonQuery();*/
            pnlDBLoadingMessege uc = new pnlDBLoadingMessege();
            try
            {

                
                uc.Hide();
                uc.Parent = frmMainPage.ActiveForm;
                uc.Left = 500;
                uc.Top = 300;
                uc.Show();
                uc.BringToFront();
                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT into " + table + " (" + field + ") " + " VALUES (" + values + ")", conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
                uc.Hide();
            }
            catch (SystemException ex)
            {
                conn.Close();
                uc.Hide();
                String msg = ex.Message.Substring(0, 6);
                if (msg == "Cannot")
                {
                    field = field.Substring(field.IndexOf(",") + 1);
                    values = values.Substring(values.IndexOf(",") + 1);

                    recallAdd(table, field, values);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Connection error. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Thread.Sleep(5000);
                        recallAdd(table, field, values);
                    }
                }
               
            }
            


        }
        //Recalls the add if the method fails
        public void recallAdd(String table, String field, String values)
        {
            add(table, field, values);
        }
        //A method that deletes data using sql out of the database
        public void delete(String table, String crit)
        {

            /*string sql = "DELETE FROM @P1 WHERE RowID = @RowID";

            SqlCommand deleteRecord = new SqlCommand();
            deleteRecord.Connection = conn;
            deleteRecord.CommandType = CommandType.Text;
            deleteRecord.CommandText = sql;

            SqlParameter RowParameter = new SqlParameter();
            deleteRecord.Parameters.AddWithValue("@P1",table);
            RowParameter.ParameterName = "@RowID";
            RowParameter.SqlDbType = SqlDbType.Int;
            RowParameter.IsNullable = false;
            RowParameter.Value = rowID;

            deleteRecord.Parameters.Add(RowParameter);

            deleteRecord.Connection.Open();

            deleteRecord.ExecuteNonQuery();

            deleteRecord.Connection.Close();

            DataSet ds = new DataSet();
            ds.GetChanges();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.Fill(ds,table);*/

            pnlDBLoadingMessege uc = new pnlDBLoadingMessege();
            try
            {
          
                uc.Hide();
                uc.Parent = frmMainPage.ActiveForm;
                uc.Left = 500;
                uc.Top = 300;
                uc.Show();
                uc.BringToFront();
                conn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + crit, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();

                uc.Hide();
            }
            catch (SystemException ex)
            {
                conn.Close();
                uc.Hide();
                DialogResult result = MessageBox.Show("Connection error. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Thread.Sleep(5000);
                    recallDelete(table, crit);
                }

            }
        }
        //Recalls in case of failure
        private void recallDelete(String table, String crit)
        {
            delete(table,crit);
        }

        //A method that edits data using sql in the database
        public void edit(String table, String field, String values, String crit)
        {
            /*SqlDataReader reader;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE @P1 SET @P3 = @P2 WHERE RowID = @RowID";
            cmd.Parameters.AddWithValue("@P1", table);
            cmd.Parameters.AddWithValue("@P2", field);
            cmd.Parameters.AddWithValue("@P3", column);
            SqlParameter RowParameter = new SqlParameter();
            RowParameter.ParameterName = "@RowID";
            RowParameter.SqlDbType = SqlDbType.Int;
            RowParameter.IsNullable = false;
            RowParameter.Value = rowID;
            cmd.Parameters.Add(RowParameter);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();


            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            conn.Close();*/
            pnlDBLoadingMessege uc = new pnlDBLoadingMessege();
            try
            {
               
                uc.Hide();
                uc.Parent = frmMainPage.ActiveForm;
                uc.Left = 500;
                uc.Top = 300;
                uc.Show();
                uc.BringToFront();
                field += ",";
                values += ",";
                string fld;
                string val;
                String setString = "";
                while (field != "")
                {
                    fld = field.Substring(0, field.IndexOf(","));
                    val = values.Substring(0, values.IndexOf(","));
                    setString += fld + "=" + val + ",";


                    field = field.Substring(field.IndexOf(",") + 1);
                    values = values.Substring(values.IndexOf(",") + 1);
                }
                setString = setString.Substring(0, setString.Length - 1);
                conn.Open();
                using (SqlCommand command = new SqlCommand("UPDATE " + table + " SET " + setString + " WHERE " + crit, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();

                uc.Hide();
            }
            catch (SystemException ex)
            {
                conn.Close();
                uc.Hide();
                MessageBox.Show(ex.Message);
                DialogResult result = MessageBox.Show("Connection error. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Thread.Sleep(5000);
                    recallEdit(table, field, values, crit);
                }
            }
        }
        //recall in case of failure
        private void recallEdit(String table, String field, String values, String crit)
        {
            edit(table, field, values, crit);
        }
        
        //Regex method tot test the validity of a email
        public bool isEmail(String text)
        {
            if (Regex.IsMatch(text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                return true;
            else
            {
                //MessageBox.Show("Please make sure that you correctly typed in the textbox");
                return false;
            }
        }
        //Regex method tot test the validity of a number
        public bool isTelephone(String text)
        {
            if (Regex.IsMatch(text, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
                return true;
            else
            {
                //MessageBox.Show("Please make sure that it is a valid number");
                return false;
            }
        }
        //Regex method tot test the validity of a string
        public bool isText(String text)
        {
            if (Regex.IsMatch(text, @"^[a-zA-Z0-9]*$"))
                return true;
            else
            {
                //MessageBox.Show("Please make sure that you correctly typed in the textbox");
                return false;
            }
        }
        //Regex method tot test the validity of a string with spaces
        public bool isTextWithSpace(String text)
        {
            if (Regex.IsMatch(text, @"^[a-zA-Z0-9 ]*$"))
                return true;
            else
            {
                //MessageBox.Show("Please make sure that you correctly typed in the textbox");
                return false;
            }
        }
        //Regex method tot test the validity of a url
        public bool isURL(String text)
        {
            if (Regex.IsMatch(text, @"(http(s)?://)?([\w-]+\.)+[\w-]+[.com]+(/[/?%&=]*)?"))
                return true;
            else
            {
                //MessageBox.Show("Please make sure that you correctly typed in the textbox");
                return false;
            }
        }
        //Regex method tot test the validity of a number
        public bool isNumber(String text)
        {
            if (Regex.IsMatch(text, @"^[0-9]*$"))
                return true;
            else
            {
                //MessageBox.Show("Please make sure that it is a valid number");
                return false;
            }
        }
        //Regex method tot test the validity of currency
        public bool isMoney(String text)
        {
            if (Regex.IsMatch(text, @"^[+-]?((\d+(\.\d*)?)|(\.\d+))$"))
                return true;
            else
            {
                //MessageBox.Show("Please make sure that it is a valid number");
                return false;
            }
        }
        //A method that uses the names and values of the controls in a groupbox to send back all the column names and values to add edit and delete data in the database
        public void getFieldsAndValues(out String fields, out String values, GroupBox gb, String extra)
        {
            fields = "";
            values = "";
            String extra2 = "";
            String current;
            try
            {
                foreach (Control obj in gb.Controls)
                {
                    if ((obj is MetroTextBox) || (obj is MetroDateTime))
                        extra2 = "txt" + extra;
                    else if (obj is MetroComboBox)
                        extra2 = "cmb" + extra;
                    else
                        goto out2;
                    current = obj.Name.Substring(extra2.Length);

                    fields += current + ",";
                    if (current == "Amount")
                        values += obj.Text + ",";
                    else
                        values += "'" + obj.Text + "',";

                    out2:;
                }
                values = values.Substring(0, values.Length - 1);
                fields = fields.Substring(0, fields.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //This method is used to calculte the amount a client owes on a certain consultation
        public double calculateAmount(String consultation, MetroGrid dgv)
        {
            double worked = 0;
            if (consultation == "all")
                fillDGV(dgv, "Consultations");
            else
                filterDGV(dgv, "Consultations", " WHERE Consultation = " + consultation);
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                worked += Convert.ToDouble(dgv.Rows[i].Cells["Amount"].Value.ToString());
            }

            double payed = 0;
            if (consultation == "all")
                fillDGV(dgv, "Payments");
            else
                filterDGV(dgv, "Payments", " WHERE Consultation = " + consultation);
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                payed += Convert.ToDouble(dgv.Rows[i].Cells["Amount"].Value.ToString());
            }

            return worked - payed;
        }

        //This method is used to calculte the amount a client owes on a certain consultation during a certain time period
        public double calculateAmount(String name, String surname, MetroGrid dgv, double diff1, double diff2)
        {
            double worked = 0;
            filterDGV(dgv, "Consultations", " WHERE Name = '" + name + "' AND Surname = '" + surname + "'");
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                String date = dgv.Rows[i].Cells["Date"].Value.ToString();
                int index1 = date.IndexOf(@"/");
                int index2 = date.LastIndexOf(@"/");
                int year = Convert.ToInt16(date.Substring(index2 + 1, 4));
                int mon = Convert.ToInt16(date.Substring(0, index1));
                int day = Convert.ToInt16(date.Substring(index1 + 1, index2 - index1 - 1));
                double diff = (Convert.ToInt16(DateTime.Now.Year) - year) * 365  + (Convert.ToInt16(DateTime.Now.Month) - mon)*30 + (Convert.ToInt16(DateTime.Now.Day) - day);
                if (diff >= diff1 && diff < diff2)
                worked += Convert.ToDouble(dgv.Rows[i].Cells["Amount"].Value.ToString());
            }

            double payed = 0;

            filterDGV(dgv, "Payments", " WHERE Client_Name = '" + name + "' AND Client_Surname = '" + surname + "'");
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                String date = dgv.Rows[i].Cells["Date"].Value.ToString();
                int index1 = date.IndexOf(@"/");
                int index2 = date.LastIndexOf(@"/");
                int year = Convert.ToInt16(date.Substring(index2 + 1, 4));
                int mon = Convert.ToInt16(date.Substring(0, index1));
                int day = Convert.ToInt16(date.Substring(index1 + 1, index2 - index1 - 1));
                double diff = (Convert.ToInt16(DateTime.Now.Year) - year) * 365 + (Convert.ToInt16(DateTime.Now.Month) - mon) * 30 + (Convert.ToInt16(DateTime.Now.Day) - day);
                if (diff >= diff1 && diff < diff2)
                    payed += Convert.ToDouble(dgv.Rows[i].Cells["Amount"].Value.ToString());
            }

            return worked - payed;
        }
        //This method fills the analisis textbox to show the years financial standing
        public String Analysis(String folder1, String folder2, String type, MetroComboBox cmb)
        {
            MetroGrid dgv = new MetroGrid();
            dgv.Parent = frmStatistics.ActiveForm;
            dgv.Hide();

            String month;
            String amount;
            Double total = 0;
            String subA="", subB="";
            String text = "";
            int f1=0, f2 = 0;
            if (type == "Tax")
            {
                f1 = 4;
                f2 = 3;
            }
            else if (type == "Analysis")
            {
                f1 = 9;
                f2 = 4;
            }
            
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + folder1 + "Archive";
            DirectoryInfo d = new DirectoryInfo(filepath);
            string filepath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + folder2 + "Archive";
            DirectoryInfo d2 = new DirectoryInfo(filepath2);
            foreach (var fle in d.GetFiles())
            {
                if (fle.Name.Substring(0, 4) == cmb.Text)
                {
                    month = fle.Name.Substring(5,fle.Name.IndexOf(".")-5);
                    foreach (var fle2 in d2.GetFiles())
                    {
                        if(fle.Name == fle2.Name)
                        {
                            StreamReader file1 =
                           new StreamReader(filepath + @"\" + fle.Name);
                            StreamReader file2 =
                           new StreamReader(filepath2 + @"\" + fle2.Name);

                            string line;
                            while ((line = file1.ReadLine()) != null)
                            {
                                for (int i = 0; i < f1; i++)
                                {
                                    
                                    line = line.Remove(0, line.IndexOf(";") + 1);
                                }
                                amount = line.Substring(0, line.IndexOf(";"));
                                total += Convert.ToDouble(amount);
                            }
                            filterDGV(dgv, folder1, " WHERE Date BETWEEN '" + cmb.Text + "0101' AND '" + cmb.Text + "1231'");
                            for(int i = 0; i < dgv.RowCount-1;i++)
                            {
                                total += Convert.ToDouble(dgv.Rows[i].Cells["Amount"].Value.ToString());
                            }
                            subA = total + "";
                            total = 0;
                            String income = "";
                            while ((line = file2.ReadLine()) != null)
                            {
                                for (int i = 0; i < f2; i++)
                                {
                                    if (i == 2)
                                        income = line.Substring(0, line.IndexOf(";"));
                                    line = line.Remove(0, line.IndexOf(";") + 1);
                                }
                                amount = line.Substring(0, line.IndexOf(";"));
                                if (income == "Income")
                                    total -= Convert.ToDouble(amount);
                                else
                                    total += Convert.ToDouble(amount);
                            }
                            filterDGV(dgv, folder2, " WHERE Date BETWEEN '" + cmb.Text + "0101' AND '" + cmb.Text + "1231'");
                            for (int i = 0; i < dgv.RowCount - 1; i++)
                            {
                                total += Convert.ToDouble(dgv.Rows[i].Cells["Amount"].Value.ToString());
                            }
                            subB = total + "";
                            total = 0;
                            if (subA == "")
                                subA = "0";
                            if (subB == "")
                                subB = "0";

                            text += month + "\t" + subA + "\t\t" + subB + "\r\n";
                            
                        }
                    }
                    
                    
                }
            }
            dgv = null;
            return text;

        }
            
            
    }
}
