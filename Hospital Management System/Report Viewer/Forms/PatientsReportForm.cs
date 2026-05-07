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
    public partial class PatientsReportForm : Form
    {
        public PatientsReportForm()
        {
            InitializeComponent();
        }

        private void PatientsReportForm_Load(object sender, EventArgs e)
        {
            ShowPatientReport();
        }

        public void ShowPatientReport()
        {
            try
            {
                List<PatientReportModel> patients = new List<PatientReportModel>();

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Patients"; 
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        patients.Add(new PatientReportModel
                        {
                            PatientID = dr["PatientID"].ToString(),
                            FullName = dr["FullName"].ToString(),
                            DOB = dr["DOB"] != DBNull.Value ? Convert.ToDateTime(dr["DOB"]) : DateTime.MinValue,
                            Gender = dr["Gender"].ToString(),
                            Phone = dr["Phone"].ToString(),
                            Address = dr["Address"].ToString(),
                            DoctorID = dr["DoctorID"].ToString(),
                            BloodType = dr["BloodType"].ToString(),
                            Allergies = dr["Allergies"].ToString(),
                            Diagnosis = dr["Diagnosis"].ToString(),
                            Updated_At = dr["Updated_At"] != DBNull.Value ? Convert.ToDateTime(dr["Updated_At"]) : DateTime.MinValue
                        });
                    }
                }

                string reportPath = Path.Combine(Application.StartupPath, "Report Viewer", "WiZards", "PatientsWizard.rdlc");
                reportViewerPatients.LocalReport.ReportPath = reportPath;
                reportViewerPatients.LocalReport.DataSources.Clear();
                
                ReportDataSource rds = new ReportDataSource("DataSet1", patients);
                reportViewerPatients.LocalReport.DataSources.Add(rds);

                reportViewerPatients.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void patientReportModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
