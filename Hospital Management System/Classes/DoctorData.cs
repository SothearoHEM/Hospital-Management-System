using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Classes
{
    internal class DoctorData
    {
        // Basic Fields
        public string DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string LicenseNumber { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }

        // Audit Fields
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Computed Properties
        public string FullName => $"Dr. {FirstName} {LastName}";
        public string DisplayName => $"{FullName} - {Specialization}";
        public bool IsModified => UpdatedAt > CreatedAt;

        // Constructor
        public DoctorData()
        {
            Status = "Active";
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public List<DoctorData> GetAllDoctors()
        {
            List<DoctorData> doctors = new List<DoctorData>();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT * FROM Doctors 
                                   WHERE IsDeleted = 0 
                                   ORDER BY FirstName, LastName";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        doctors.Add(ReaderToDoctorData(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading doctors: " + ex.Message);
            }

            return doctors;
        }

        private DoctorData ReaderToDoctorData(SqlDataReader reader)
        {
            return new DoctorData
            {
                DoctorID = reader["DoctorID"]?.ToString(),
                FirstName = reader["FirstName"]?.ToString(),
                LastName = reader["LastName"]?.ToString(),
                Gender = reader["Gender"]?.ToString(),
                Specialization = reader["Specialization"]?.ToString(),
                PhoneNumber = reader["PhoneNumber"]?.ToString(),
                EmailAddress = reader["EmailAddress"]?.ToString(),
                LicenseNumber = reader["LicenseNumber"]?.ToString(),
                Status = reader["Status"]?.ToString(),
                ImagePath = reader["ImagePath"]?.ToString(),
                CreatedAt = reader["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedAt"]) : DateTime.MinValue,
                UpdatedAt = reader["UpdatedAt"] != DBNull.Value ? Convert.ToDateTime(reader["UpdatedAt"]) : DateTime.MinValue,
            };
        }
    }
}
