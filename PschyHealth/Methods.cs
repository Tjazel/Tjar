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
            silentFillDGV(dgv,sTable,"",true);
        }
        public async void silentFillDGV(MetroGrid dgv, String sTable, String filter, Boolean silent)
        {
            

            pnlDBLoadingMessege uc = new pnlDBLoadingMessege();
            uc.Hide();
            uc.Parent = frmMainPage.ActiveForm;
            uc.Left = 500;
            uc.Top = 300;
            uc.Show();
            uc.BringToFront();

            await Task.Delay(100);
            Thread.Sleep(1000);
            try
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
                uc.Hide();
                uc.SendToBack();
                uc = null;
            }
            catch (SqlException e)
            {

                String mes = e.Message.Substring(0, 17);
                MessageBox.Show(e.Message);
                if (!silent)
                {
                    if (mes == "A network-related")
                    {
                        DialogResult result = MessageBox.Show("Connection timed out. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Thread.Sleep(5000);
                            recallFilter(dgv, sTable, filter);
                        }
                    }           
                    else
                    {
                        DialogResult result = MessageBox.Show("Connection error. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            recallFilter(dgv, sTable, filter);
                        }
                    }
                }
                else
                {
                    Thread.Sleep(5000);
                    recallFilter(dgv, sTable, filter);
                }
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DialogResult result = MessageBox.Show("Connection error. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    recallFilter(dgv, sTable, filter);
                }
            }
        }

        //werk nie reg nie
        //public string fillText(string buttonText)
        //{
        //    if (buttonText=="Maandeliks")
        //    {
        //        string good = "";
        //        for (int i = 0; i <= 12; i++)
        //        {
        //            good += "Total income for the ";
        //            double goodSum = 0, badSum = 0;
        //            SqlCommand cmd = new SqlCommand();
        //            SqlDataReader reader;
        //            cmd.CommandText = "SELECT * FROM Accounting WHERE Date LIKE @P1 AND Type = 'Income'";
        //            cmd.Parameters.AddWithValue("@P1", "*-*"+Convert.ToString(i)+"*");
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Connection = conn;
        //            conn.Open();
        //            reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                goodSum += Convert.ToDouble(reader["Amount"].ToString());
        //            }
        //            reader.Close();
        //            good += Convert.ToString(i) + "th month :R" + Convert.ToString(goodSum) + "\r\n";
        //            conn.Close();
        //        }
        //        string bad = "\n";
        //        for (int i = 0; i <= 12; i++)
        //        {
        //            bad += "Total expense for the ";
        //            double badSum = 0;
        //            SqlCommand cmd = new SqlCommand();
        //            SqlDataReader reader;
        //            cmd.CommandText = "SELECT * FROM Accounting WHERE Date LIKE @P1 AND Type <> 'Income'";
        //            cmd.Parameters.AddWithValue("@P1", "*-*" + Convert.ToString(i) + "*");
        //            cmd.CommandType = CommandType.Text;
        //            cmd.Connection = conn;
        //            conn.Open();
        //            reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                badSum += Convert.ToDouble(reader["Amount"].ToString());
        //            }
        //            reader.Close();
        //            bad += Convert.ToString(i) + "th month :R" + Convert.ToString(badSum) + "\r\n";
        //            conn.Close();
        //        }
        //        buttonText = good + bad;
        //    }
        //    if (buttonText == "Geldvloei")
        //    {

        //    }
        //    conn.Close();
        //    return buttonText;
        //}

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


        public void filterDGV(MetroGrid dgv, String sTable, String filter)
        {
            silentFillDGV(dgv, sTable, filter, false);
        }

        private void recallFilter(MetroGrid dgv, String sTable, String filter)
        {
            filterDGV(dgv, sTable, filter);
        }



        public void fillCMB(MetroComboBox cmb, MetroGrid dgv)
        {
            cmb.Items.Clear();
            for (int i = 0; i < dgv.ColumnCount; i++)
                cmb.Items.Add(dgv.Columns[i].Name);
        }


        public void fillCMBrow(MetroComboBox cmb1, MetroComboBox cmb2, MetroGrid dgv)
        {   
            if(cmb1 != null)
                cmb1.Items.Clear();
            if (cmb2 != null)
                cmb2.Items.Clear();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (cmb1 != null)
                    cmb1.Items.Add(dgv.Rows[i].Cells["First_Name"].Value.ToString());
                if (cmb2 != null)
                    cmb2.Items.Add(dgv.Rows[i].Cells["Surname"].Value.ToString());
            }
        }
        public void fillCMBrow(MetroComboBox cmb, MetroGrid dgv)
        {
            cmb.Items.Clear();
            string entry;
            for (int i = 0; i < dgv.RowCount-1; i++)
            {
                entry = dgv.Rows[i].Cells["Surname"].Value.ToString() + ", " + dgv.Rows[i].Cells["First_Name"].Value.ToString();
                if (!cmb.Items.Contains(entry))
                    cmb.Items.Add(entry);
            }
        }

        public void fillTextbox(GroupBox gb, MetroGrid dgv, String extra, Boolean enabled, Boolean empty)
        {
            try
            {
                foreach (Control obj in gb.Controls)
                {
                    if ((obj is MetroTextBox) || (obj is MetroDateTime))
                        extra = "txt" + extra;
                    else if (obj is MetroComboBox)
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
                conn.Close();
                return;
            }


        }

        public void fillTextbox(GroupBox gb, MetroGrid dgv, String extra, Boolean enabled)
        {
            fillTextbox(gb, dgv, extra, enabled, false);
        }

        public void CheckFolder(String path)
        {
            if (!File.Exists(path))
                Directory.CreateDirectory(path);
        }

        public void WriteFile(String path, String txt)
        {
            CheckFile(path);
            File.AppendAllText(path + ".txt", txt);
        }

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

        public void Archive(MetroGrid dgv, String table, String field, String crit)
        {
            String arch = "";
            for(int i = 0; i < dgv.RowCount-1; i++)
            {
                if (dgv.Rows[i].Cells[field].Value.ToString() == crit)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        arch += dgv.Rows[i].Cells[j].Value.ToString() + ";";
                    }
                    arch += "\r\n";
                    WriteFile(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + table + @"Archive\" + DateTime.Now.Year.ToString() + @"-" + DateTime.Now.Month.ToString(), arch);
                    delete(table, field + "='" + crit + "'");
                }

            }
            
        }
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
                if (diff > months)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        arch += dgv.Rows[i].Cells[j].Value.ToString() + ";";
                    }
                    arch += "\r\n";
                }
            }
            WriteFile(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + table + @"Archive\" + DateTime.Now.Year.ToString() + @"-" + DateTime.Now.Month.ToString(), arch);
        }

        public Boolean validNumber(String txt)
        {
            string[] valids = { "."};
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

        public Boolean validString(String txt)
        {
            char[] valids = { ' ','.','-' };
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
            if(dtxt != String.Concat(txt.Where(Char.IsDigit))||(dtxt.Length>8)|| (dtxt.Length < 6))
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

            if(new FileInfo(filename).Length==0)
            {
                write.WriteLine(""+cl+"");
                write.Close();
            }
            else
            {
                write.Close();
            }
        }

        public void writeStyle( MetroFramework.Components.MetroStyleManager manager, MetroFramework.MetroColorStyle cl)
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

            
            

            switch(line)
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

        public void changeTheme(MetroFramework.Components.MetroStyleManager manager ,MetroFramework.MetroThemeStyle styl)
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
            if(line!=null)
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
            
            if(line =="Dark")
            {
                chosenStyle = MetroFramework.MetroThemeStyle.Dark;
            }else
            {
                chosenStyle = MetroFramework.MetroThemeStyle.Default;
            }
            changeTheme(manager, chosenStyle);
            lees.Close();
        }

        public void cloneTheme(MetroFramework.Forms.MetroForm main,MetroFramework.Forms.MetroForm sub)
        {
            sub.StyleManager = main.StyleManager;
            main.StyleManager.Clone(sub);
        }
        

        

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

        public void ReplaceBookmarkText(Microsoft.Office.Interop.Word.Document doc,string bookmarkName,string text)
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

            try
            {


                conn.Open();
                using (SqlCommand command = new SqlCommand("INSERT into " + table + " (" + field + ") " + " VALUES (" + values + ")", conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();

            }
            catch (SystemException ex)
            {
                conn.Close();
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }


        }

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


            try
            {

                conn.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + crit, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();

            }
            catch (SystemException ex)
            {
                conn.Close();
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }



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

            try
            {
                field += ",";
                values += ",";
                string fld;
                string val;
                String setString = "";
                while(field != "")
                {
                    fld = field.Substring(0, field.IndexOf(","));
                    val = values.Substring(0, values.IndexOf(","));
                    setString +=  fld + "=" + val + ",";


                    field = field.Substring(field.IndexOf(",")+1);
                    values = values.Substring(values.IndexOf(",")+1);
                }
                setString = setString.Substring(0, setString.Length-1);
                conn.Open();
                using (SqlCommand command = new SqlCommand("UPDATE " + table + " SET " + setString + " WHERE " + crit, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();

            }
            catch (SystemException ex)
            {
                conn.Close();
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

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
                        values += "'" +obj.Text + "',";

                out2:;
                }
                values = values.Substring(0, values.Length - 1);
                fields = fields.Substring(0, fields.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                conn.Close();
                return;
            }
        }

        public double calculateAmount(String consultation, MetroGrid dgv)
        {
            double worked = 0;
            if (consultation == "all")
                fillDGV(dgv, "Consultations");
            else
                filterDGV(dgv, "Consultations", " WHERE Consultation = " + consultation);
            for(int i = 0; i<dgv.RowCount-1; i++)
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
    }
}
