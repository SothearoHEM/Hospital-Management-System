using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Report_Viewer.Classes
{
    internal class PatienMedicalBillReceiptModel
    {
        public int VisitID { get; set; }
        public DateTime Date { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string AssignedDoctor { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string RoomNo { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string ReasonForVisit { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        public DateTime FollowUpDate { get; set; }
    }
}
