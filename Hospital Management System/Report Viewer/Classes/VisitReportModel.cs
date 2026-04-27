using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Report_Viewer.Classes
{
    internal class VisitReportModel
    {
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
    }
}
