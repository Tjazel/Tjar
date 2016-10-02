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

using System.Threading;


namespace PschyHealth
{
    //The Methods class saves a sertain methods and procedures that will be used in the program more than once.
    //The main reason for this class is to reuse code, thus not making the program too large, and also making it more efficient.
    class Methods
    {
        SqlConnection conn = new SqlConnection("Data Source=jarvisdevelopment.database.windows.net;Initial Catalog=JarvisDev;User id=JohannJarvis;Password=allersJohann96;");
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

                String connectionString =
                "Data Source = jarvisdevelopment.database.windows.net; Initial Catalog = JarvisDev; User ID = RuanJarvis; Password = Claassen93";

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
                //MessageBox.Show(e.Message);
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
        //    SqlCommand cmd = new SqlCommand();
        //    SqlDataReader reader;

        //    cmd.CommandText = "SELECT * FROM Staff WHERE Username = @P1 AND Password = @P2";
        //    cmd.Parameters.AddWithValue("@P1", username);
        //    cmd.Parameters.AddWithValue("@P2", password);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = conn;
        //    conn.Open();

        //    reader = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(reader);
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

        public void fillTextbox(GroupBox gb, MetroGrid dgv, String extra, Boolean enabled)
        {
            try
            {
                foreach (Control obj in gb.Controls)
                {
                    if ((obj is MetroTextBox)||(obj is MetroDateTime))
                        extra = "txt" + extra;
                    else if (obj is MetroComboBox)
                        extra = "cmb" + extra;
                    else
                        goto out1;
                    obj.Enabled = enabled;
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
                out1:;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }


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
                        arch += dgv.Rows[i].Cells[j].Value.ToString() + "; ";
                    }
                    arch += "\r\n";
                }
            }
            WriteFile(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDoc‌​uments) + @"\JarvisDevelopment\Archive\" + table + @"Archive\" + DateTime.Now.Year.ToString() + @"-" + DateTime.Now.Month.ToString(), arch);
        }

        public void filtercmbChange(MetroGrid dgv, String sTable, String filter)
        {
            
        }
    }
}
