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
    public partial class PatienMedicalBillReceipt : Form
    {
        private int _visitID = -1;
        private DateTime? _checkOutDate;
        private string _prescription;
        private DateTime? _followUpDate;

        public PatienMedicalBillReceipt()
        {
            InitializeComponent();
        }

        public PatienMedicalBillReceipt(int visitID, DateTime? checkOutDate = null, string prescription = null, DateTime? followUpDate = null) : this()
        {
            _visitID = visitID;
            _checkOutDate = checkOutDate;
            _prescription = prescription;
            _followUpDate = followUpDate;
        }

        private void PatienMedicalBillReceipt_Load(object sender, EventArgs e)
        {
            ShowPatientMedicalBillReceipt();
        }

        public void ShowPatientMedicalBillReceipt()
        {
            try
            {
                List<PatienMedicalBillReceiptModel> bills = new List<PatienMedicalBillReceiptModel>();

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT 
                                        V.VisitID, 
                                        P.PatientID, 
                                        P.FullName AS PatientName, 
                                        D.FullName AS AssignedDoctor, 
                                        P.BloodType,
                                        P.Allergies,
                                        V.RoomNo,
                                        V.CheckInTime,
                                        V.CheckOutTime,
                                        V.Reason,
                                        P.Diagnosis,
                                        V.Prescription,
                                        V.FollowUpDate
                                     FROM Visits V
                                     JOIN Patients P ON V.PatientID = P.PatientID
                                     JOIN Doctors D ON V.DoctorID = D.DoctorID";

                    if (_visitID > 0)
                    {
                        query += " WHERE V.VisitID = @VisitID";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (_visitID > 0)
                    {
                        cmd.Parameters.AddWithValue("@VisitID", _visitID);
                    }

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        bills.Add(new PatienMedicalBillReceiptModel
                        {
                            VisitID = Convert.ToInt32(dr["VisitID"]),
                            Date = DateTime.Now,
                            PatientID = dr["PatientID"].ToString(),
                            PatientName = dr["PatientName"].ToString(),
                            AssignedDoctor = dr["AssignedDoctor"].ToString(),
                            BloodType = dr["BloodType"].ToString(),
                            Allergies = dr["Allergies"].ToString(),
                            RoomNo = dr["RoomNo"].ToString(),
                            CheckInDate = dr["CheckInTime"] != DBNull.Value ? Convert.ToDateTime(dr["CheckInTime"]) : DateTime.MinValue,
                            CheckOutDate = _checkOutDate ?? (dr["CheckOutTime"] != DBNull.Value ? Convert.ToDateTime(dr["CheckOutTime"]) : DateTime.MinValue),
                            ReasonForVisit = dr["Reason"].ToString(),
                            Diagnosis = dr["Diagnosis"].ToString(),
                            Prescription = _prescription ?? dr["Prescription"].ToString(),
                            FollowUpDate = _followUpDate ?? (dr["FollowUpDate"] != DBNull.Value ? Convert.ToDateTime(dr["FollowUpDate"]) : DateTime.MinValue)
                        });
                    }
                }

                string reportPath = Path.Combine(Application.StartupPath, "Report Viewer", "WiZards", "PatienMedicalBillReceiptWizard.rdlc");
                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();
                
                ReportDataSource rds = new ReportDataSource("DataSet1", bills);
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void patienMedicalBillReceiptModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
