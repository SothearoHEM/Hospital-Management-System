using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Test connection
            //try
            //{
            //    using (SqlConnection conn = DatabaseConnection.GetConnection())
            //    {
            //        conn.Open();
            //        MessageBox.Show("Database connected successfully!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Database connection failed: " + ex.Message);
            //    return;
            //}
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
