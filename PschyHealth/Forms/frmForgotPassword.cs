using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;

namespace PschyHealth
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = jarvisdevelopment.database.windows.net; Initial Catalog = JarvisDev; User ID = ProjectJarvis; Password =JarvisProject2016;");
            
            SqlCommand cmd = new SqlCommand("SELECT *FROM Staff WHERE Email='"+txtEmail.Text+"'", cn);
            SqlDataReader rd;

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string sEmail = rd.GetString(26);
                    if(sEmail == txtEmail.Text)
                    {
                        MessageBox.Show("Your email was sent succesfully");
                        rd.Close();
                        rd.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
            cn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = jarvisdevelopment.database.windows.net; Initial Catalog = JarvisDev; User ID = ProjectJarvis; Password =JarvisProject2016;");

            SqlCommand cmd = new SqlCommand("SELECT *FROM Staff WHERE Email='" + txtEmail.Text + "'", cn);
            SqlDataReader rd;

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string sEmail = rd.GetString(26);
                    if (sEmail == txtEmail.Text)
                    {
                        MessageBox.Show("Your email was sent succesfully");
                        rd.Close();
                        rd.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            cn.Close();
        }
    }
}

