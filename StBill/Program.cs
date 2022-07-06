using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StBill.Properties;

namespace StBill
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Settings.Default.DB_LINK=="")
            {
                Application.Run(new frmSetDataSource());
            }
            else
            {
                Application.Run(new frmLogin());
            }
            

        }
    }
}
