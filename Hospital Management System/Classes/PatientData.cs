using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Classes
{
    internal class PatientData
    {
        // Basic Fields
        public string PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string BloodType { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string KnownAllergies { get; set; }
        public string MedicalHistoryNotes { get; set; }

        // Audit Fields
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Computed Properties
        public string FullName => $"{FirstName} {LastName}";
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
        public bool IsModified => UpdatedAt > CreatedAt;

        // Constructor
        public PatientData()
        {
            DateOfBirth = DateTime.Now.AddYears(-30);
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public List<PatientData> GetAllPatients()
        {
            List<PatientData> patients = new List<PatientData>();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT * FROM Patients 
                                   WHERE IsDeleted = 0 
                                   ORDER BY FirstName, LastName";

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
                throw new Exception("Error loading patients: " + ex.Message);
            }

            return patients;
        }
        public PatientData ReaderToPatient(SqlDataReader reader)
        {
            return new PatientData
            {
                PatientID = reader["PatientID"].ToString(),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                Gender = reader["Gender"].ToString(),
                PhoneNumber = reader["PhoneNumber"].ToString(),
                BloodType = reader["BloodType"].ToString(),
                EmailAddress = reader["EmailAddress"].ToString(),
                Address = reader["Address"].ToString(),
                KnownAllergies = reader["KnownAllergies"].ToString(),
                MedicalHistoryNotes = reader["MedicalHistoryNotes"].ToString(),
                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
            };
        }
    }
    }
