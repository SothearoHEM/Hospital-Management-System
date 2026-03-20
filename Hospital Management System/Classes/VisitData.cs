using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Classes
{
    internal class VisitData
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

        // Audit Fields
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public bool Is_Deleted { get; set; }

        // Constructor
        public VisitData()
        {
            CheckInTime = DateTime.Now;
            Status = "Active";
            Created_At = DateTime.Now;
            Updated_At = DateTime.Now;
            Is_Deleted = false;
        }
    }
}
