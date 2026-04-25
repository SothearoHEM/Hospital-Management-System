using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Classes
{
    internal class ActiveVisitData
    {
        // Basic Fields
        public int VisitID { get; set; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public string Status { get; set; }
        public string RoomNo { get; set; }
        public string Reason { get; set; }
        public string Prescription { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public DateTime Updated_At { get; set; }

        // Constructor
        public ActiveVisitData()
        {
            CheckInTime = DateTime.Now;
            Status = "Active";
            Updated_At = DateTime.Now;
        }
        public List<ActiveVisitData> GetAllActiveVisits()
        {
            List<ActiveVisitData> activeVisitDatas = new List<ActiveVisitData>();

            // Simulate fetching data from a database
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Visits WHERE Is_Deleted = 0 AND Status = 'Active' ORDER BY CheckInTime DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ActiveVisitData visitData = new ActiveVisitData
                                {
                                    VisitID = reader.GetInt32(reader.GetOrdinal("VisitID")),
                                    PatientID = reader.GetString(reader.GetOrdinal("PatientID")),
                                    DoctorID = reader.GetString(reader.GetOrdinal("DoctorID")),
                                    CheckInTime = reader.GetDateTime(reader.GetOrdinal("CheckInTime")),
                                    CheckOutTime = reader.IsDBNull(reader.GetOrdinal("CheckOutTime")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("CheckOutTime")),
                                    Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? null : reader.GetString(reader.GetOrdinal("Status")),
                                    RoomNo = reader.IsDBNull(reader.GetOrdinal("RoomNo")) ? null : reader.GetString(reader.GetOrdinal("RoomNo")),
                                    Reason = reader.IsDBNull(reader.GetOrdinal("Reason")) ? null : reader.GetString(reader.GetOrdinal("Reason")),
                                    Prescription = reader.IsDBNull(reader.GetOrdinal("Prescription")) ? null : reader.GetString(reader.GetOrdinal("Prescription")),
                                    FollowUpDate = reader.IsDBNull(reader.GetOrdinal("FollowUpDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FollowUpDate")),
                                    Updated_At = reader.GetDateTime(reader.GetOrdinal("Updated_At")),
                                };
                                activeVisitDatas.Add(visitData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching active visits: " + ex.Message);
            }
            return activeVisitDatas;
        }
    }
}
