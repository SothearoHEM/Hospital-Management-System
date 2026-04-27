using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Report_Viewer.Classes
{
    internal class PatientReportModel
    {
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
    }
}
