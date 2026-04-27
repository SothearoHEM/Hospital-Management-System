using Hospital_Management_System.Classes;
using Hospital_Management_System.Report_Viewer.Classes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Report_Viewer.Forms
{
    public partial class VisitsReportForm : Form
    {
        public VisitsReportForm()
        {
            InitializeComponent();
        }

        private void VisitsReportForm_Load(object sender, EventArgs e)
        {
            ShowVisitsReport();
        }

        public void ShowVisitsReport()
        {
            try
            {
                List<VisitReportModel> visits = new List<VisitReportModel>();

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Visits"; 
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        visits.Add(new VisitReportModel
                        {
                            VisitID = Convert.ToInt32(dr["VisitID"]),
                            PatientID = dr["PatientID"].ToString(),
                            DoctorID = dr["DoctorID"].ToString(),
                            CheckInTime = dr["CheckInTime"] != DBNull.Value ? Convert.ToDateTime(dr["CheckInTime"]) : DateTime.MinValue,
                            CheckOutTime = dr["CheckOutTime"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dr["CheckOutTime"]) : null,
                            Status = dr["Status"].ToString(),
                            RoomNo = dr["RoomNo"].ToString(),
                            Reason = dr["Reason"].ToString(),
                            Prescription = dr["Prescription"].ToString(),
                            FollowUpDate = dr["FollowUpDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dr["FollowUpDate"]) : null,
                            Updated_At = dr["Updated_At"] != DBNull.Value ? Convert.ToDateTime(dr["Updated_At"]) : DateTime.MinValue
                        });
                    }
                }

                string reportPath = Path.Combine(Application.StartupPath, "Report Viewer", "WiZards", "VisitsWizard.rdlc");
                reportViewerVisits.LocalReport.ReportPath = reportPath;
                reportViewerVisits.LocalReport.DataSources.Clear();
                
                ReportDataSource rds = new ReportDataSource("DataSet1", visits);
                reportViewerVisits.LocalReport.DataSources.Add(rds);

                reportViewerVisits.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
