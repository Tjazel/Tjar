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


namespace PschyHealth
{
    //The Methods class saves a sertain methods and procedures that will be used in the program more than once.
    //The main reason for this class is to reuse code, thus not making the program too large, and also making it more efficient.
    class Methods
    {
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
        public void silentFillDGV(MetroGrid dgv, String sTable, String filter, Boolean silent)
        {
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
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Connection error. Reconnect?", "Reconnect", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    recallFilter(dgv, sTable, filter);
                }
            }
        }

        //Hierdie is die kode vir die Login
        //public bool checkLogin(String username, String password)
        //{
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader reader;

        //cmd.CommandText = "SELECT * FROM Staff WHERE Username = @P1 AND Password = @P2";
        //    cmd.Parameters.AddWithValue("@P1", username);
        //    cmd.Parameters.AddWithValue("@P2", password);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = conn;
        //    conn.Open();

        //reader = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //dt.Load(reader);
        //    // Data is accessible through the DataReader object here.
        //    if (dt.Rows.Count == 1)
        //    {
        //        conn.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        conn.Close();
        //        return false;
        //    }

        //}

        

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
        public void dieKnoppie(DevComponents.DotNetBar.Metro.MetroTileItem keuse)
        {
            Knoppie = keuse;
        }

        public void kleur(DevComponents.DotNetBar.Metro.eMetroTileColor kl)
        {
            Knoppie.TileColor = kl;

        }

        public void pos(Form frm, Panel pnl)
        {
            frm.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            pnl.Location = new Point(posX, posY);
            pnl.Show();
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
                        extra = "cmb" + extra;
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
                return;
            }
        }
    }
}
