using System;
using System.Data.SqlClient;
using System.Configuration;

namespace HospitalManagementSystem
{
    public class DatabaseConnection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}