using System;
using Hospital_Management_System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hospital_Management_System.Classes
{
    internal class PatientData
    {
        // Basic Fields
        public string PatientID { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string Diagnosis { get; set; }
        public DateTime Updated_At { get; set; }


        // Constructor
        public PatientData()
        {
            DOB = DateTime.Now.AddYears(-30);
            Updated_At = DateTime.Now;

        }
        public List<PatientData> GetAllPatients()
        {
            List<PatientData> patients = new List<PatientData>();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT PatientID, FullName, DOB, Gender, Phone, Address, BloodType, Allergies, Diagnosis, Updated_At
                                   FROM Patients
                                   WHERE Is_Deleted = 0
                                   ORDER BY FullName";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        patients.Add(ReaderToPatient(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading patients: " + ex.ToString(), ex);
            }

            return patients;
        }
        public PatientData ReaderToPatient(SqlDataReader reader)
        {
            return new PatientData
            {
                PatientID = reader["PatientID"]?.ToString(),
                FullName = reader["FullName"]?.ToString(),
                DOB = reader["DOB"] != DBNull.Value ? Convert.ToDateTime(reader["DOB"]) : DateTime.MinValue,
                Gender = reader["Gender"]?.ToString(),
                Phone = reader["Phone"]?.ToString(),
                Address = reader["Address"]?.ToString(),
                BloodType = reader["BloodType"]?.ToString(),
                Allergies = reader["Allergies"]?.ToString(),
                Diagnosis = reader["Diagnosis"]?.ToString(),
                Updated_At = reader["Updated_At"] != DBNull.Value ? Convert.ToDateTime(reader["Updated_At"]) : DateTime.MinValue
            };
        }
        public int getTotalPatients()
        {
            int totalPatients = 0;
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Patients WHERE Is_Deleted = 0";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    totalPatients = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting patients: " + ex.ToString(), ex);
            }
            return totalPatients;
        }
    }
}
