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

        // Check-In Information
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }
        public string AssignedDoctor { get; set; }
        public DateTime CheckInDateTime { get; set; }
        public string RoomNumber { get; set; }
        public string VisitType { get; set; }
        public string ReasonForVisit { get; set; }
        public string CurrentSymptoms { get; set; }

        // Check-Out Information
        public DateTime? CheckOutDateTime { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string Duration { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        public string MedicalNotes { get; set; }

        public string Status { get; set; }

        // Audit Fields
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        // Computed Properties
        public string CheckInTime => CheckInDateTime.ToString("hh:mm tt");
        public string CheckInDate => CheckInDateTime.ToString("yyyy-MM-dd");
        public string CheckOutTime => CheckOutDateTime?.ToString("hh:mm tt") ?? "N/A";
        public bool IsActive => Status == "Active" && !IsDeleted;
        public bool IsCompleted => Status == "Completed";
        public bool IsModified => UpdatedAt > CreatedAt;
        public string RecordStatus => IsDeleted ? "Deleted" : Status;

        // Constructor
        public VisitData()
        {
            CheckInDateTime = DateTime.Now;
            Status = "Active";
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsDeleted = false;
        }
    }
}
