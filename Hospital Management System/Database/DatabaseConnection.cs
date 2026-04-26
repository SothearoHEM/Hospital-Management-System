using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Hospital_Management_System
{
    public class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=DESKTOP-HU3F7EL\MSSQLSERVER2022;Initial Catalog=HospitalDB;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}