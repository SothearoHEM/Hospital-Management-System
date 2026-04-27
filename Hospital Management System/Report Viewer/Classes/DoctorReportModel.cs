using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Report_Viewer.Classes
{
    internal class DoctorReportModel
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

        // Audit Fields
        public DateTime Updated_At { get; set; }

    }
}
