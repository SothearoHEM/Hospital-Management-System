using System;
using Hospital_Management_System;
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
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Specialization { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string LicenseNo { get; set; }
        public string Status { get; set; }
        public string Img_Path { get; set; }

        // Audit Fields
        public DateTime Updated_At { get; set; }
        

        // Constructor
        public DoctorData()
        {
            Status = "Active";
            Updated_At = DateTime.Now;
        }
        public List<DoctorData> GetAllDoctors()
        {
            List<DoctorData> doctors = new List<DoctorData>();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT DoctorID, FullName, Gender, Specialization, Phone, Email, LicenseNo, Status,Img_Path, Updated_At
                                   FROM Doctors
                                   WHERE Status = 'Active' AND Is_Deleted = 0 ORDER BY FullName ASC";

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
                throw new Exception("Error loading doctors: " + ex.ToString(), ex);
            }

            return doctors;
        }

        private DoctorData ReaderToDoctorData(SqlDataReader reader)
        {
            return new DoctorData
            {
                DoctorID = reader["DoctorID"]?.ToString(),
                FullName = reader["FullName"]?.ToString(),
                Gender = reader["Gender"]?.ToString(),
                Specialization = reader["Specialization"]?.ToString(),
                Phone = reader["Phone"]?.ToString(),
                Email = reader["Email"]?.ToString(),
                LicenseNo = reader["LicenseNo"]?.ToString(),
                Status = reader["Status"]?.ToString(),
                Img_Path = reader["Img_Path"]?.ToString(),
                Updated_At = reader["Updated_At"] != DBNull.Value ? Convert.ToDateTime(reader["Updated_At"]) : DateTime.MinValue
            };
        }

        public int getTotalDoctors()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Doctors WHERE Status = 'Active' AND Is_Deleted = 0";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting doctors: " + ex.ToString(), ex);
            }
            return count;
        }
    }
}
