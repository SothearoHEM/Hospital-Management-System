using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.ApplicationExit += Application_ApplicationExit;
            
            Forms.LoginForm loginForm = new Forms.LoginForm();
            Application.Run(loginForm);
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            // Clean up if needed
        }
    }
}
