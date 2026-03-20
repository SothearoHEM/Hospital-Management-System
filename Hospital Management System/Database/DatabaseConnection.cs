using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Hospital_Management_System
{
    public class DatabaseConnection
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}