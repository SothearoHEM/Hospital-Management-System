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
    public partial class DoctorsReportForm : Form
    {
        public DoctorsReportForm()
        {
            InitializeComponent();
        }

        private void DoctorsReportForm_Load(object sender, EventArgs e)
        {
            ShowDoctorReport();
        }

        public void ShowDoctorReport()
        {
            try
            {
                List<DoctorReportModel> doctors = new List<DoctorReportModel>();

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT DoctorID, FullName,Gender, Specialization, Phone, Email, LicenseNo, Status, Updated_At FROM Doctors";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        doctors.Add(new DoctorReportModel
                        {
                            DoctorID = dr["DoctorID"].ToString(),
                            FullName = dr["FullName"].ToString(),
                            Gender = dr["Gender"].ToString(),
                            Specialization = dr["Specialization"].ToString(),
                            Phone = dr["Phone"].ToString(),
                            Email = dr["Email"].ToString(),
                            LicenseNo = dr["LicenseNo"].ToString(),
                            Status = dr["Status"].ToString(),
                            Updated_At = dr["Updated_At"] != DBNull.Value ? Convert.ToDateTime(dr["Updated_At"]) : DateTime.MinValue,
                        });
                    }
                }

                string reportPath = Path.Combine(Application.StartupPath, "Report Viewer", "WiZards", "DoctorsWizard.rdlc");
                reportViewerDoctor.LocalReport.ReportPath = reportPath;
                reportViewerDoctor.LocalReport.DataSources.Clear();
                
                ReportDataSource rds = new ReportDataSource("DoctorsDataSet", doctors);
                reportViewerDoctor.LocalReport.DataSources.Add(rds);

                reportViewerDoctor.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
