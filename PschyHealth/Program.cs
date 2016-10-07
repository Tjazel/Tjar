using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PschyHealth
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmLogin frmLogin = new frmLogin();
                Application.Run(frmLogin);
            }
            catch(FormatException e)
            {
                MessageBox.Show("Hier is groot kak" + e);
            }
            
        }
    }
}
