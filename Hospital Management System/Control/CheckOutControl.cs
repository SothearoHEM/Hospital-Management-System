using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System.Control
{
    public partial class CheckOutControl : UserControl
    {
        SqlConnection conn = DatabaseConnection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        public CheckOutControl()
        {
            InitializeComponent();
        }
        public void LoadCheckOutData(int VisitID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"SELECT 
                    V.VisitID, 
                    P.PatientID, 
                    P.FullName AS PatientName, 
                    D.FullName AS AssignedDoctor, 
                    V.CheckInTime, 
                    V.RoomNo,
                    P.Diagnosis 
                FROM Visits V
                LEFT JOIN Patients P ON V.PatientID = P.PatientID
                LEFT JOIN Doctors D ON V.DoctorID = D.DoctorID
                WHERE V.VisitID = @VisitID AND V.Is_Deleted = 0;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@VisitID", VisitID);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        if (textVisitID != null) textVisitID.Text = row["VisitID"].ToString();
                        if (textPatientID_checkOutForm != null) textPatientID_checkOutForm.Text = row["PatientID"].ToString();
                        if (textPatientName_checkOutForm != null) textPatientName_checkOutForm.Text = row["PatientName"].ToString();
                        if (textPatientDoctor_checkOutForm != null) textPatientDoctor_checkOutForm.Text = row["AssignedDoctor"].ToString();
                        if (chackInDate_checkOutForm != null) chackInDate_checkOutForm.Text = Convert.ToDateTime(row["CheckInTime"]).ToString("yyyy-MM-dd HH:mm:ss");
                        if (textRoomNumber_checkOutForm != null) textRoomNumber_checkOutForm.Text = row["RoomNo"].ToString();
                        if (textDiagnosis_CheckOut_Form != null) textDiagnosis_CheckOut_Form.Text = row["Diagnosis"].ToString();


                        // Force refresh
                        this.Refresh();
                        Application.DoEvents();
                    }
                    else
                    {
                        MessageBox.Show("រកមិនឃើញទិន្នន័យសម្រាប់ Visit ID: " + VisitID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading checkout data: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void CheckOutControl_Load(object sender, EventArgs e)
        {
        }

        private void clear_btn_checkOutForm_Click(object sender, EventArgs e)
        {
            chackOutDate_checkOutForm.Value = DateTime.Now;
            FollowUpData.Value = DateTime.Now;
            textPrescription.Clear();
        }

        private void cancel_btn_checkOutForm_Click(object sender, EventArgs e)
        {
            var patientControl = this.Parent?.Parent as PatientCheckInOutControl;

            if (patientControl != null)
            {
                patientControl.checkInControl1.Visible = true;
                patientControl.checkInControl1.BringToFront();
                this.Visible = false;
            }

            textVisitID?.Clear();
            textPatientID_checkOutForm?.Clear();
            textPatientName_checkOutForm?.Clear();
            textPatientDoctor_checkOutForm?.Clear();
            chackInDate_checkOutForm?.Clear();
            textRoomNumber_checkOutForm?.Clear();
            textDiagnosis_CheckOut_Form?.Clear();
            textPrescription?.Clear();

            if (chackOutDate_checkOutForm != null) chackOutDate_checkOutForm.Value = DateTime.Now;
            if (FollowUpData != null) FollowUpData.Value = DateTime.Now;
        }
        private bool emptyFields()
        {
            return string.IsNullOrWhiteSpace(textVisitID.Text) ||
                   string.IsNullOrWhiteSpace(textPatientID_checkOutForm.Text) ||
                   string.IsNullOrWhiteSpace(textPatientName_checkOutForm.Text) ||
                   string.IsNullOrWhiteSpace(textPatientDoctor_checkOutForm.Text) ||
                   string.IsNullOrWhiteSpace(chackInDate_checkOutForm.Text) ||
                   string.IsNullOrWhiteSpace(textRoomNumber_checkOutForm.Text) ||
                   string.IsNullOrWhiteSpace(textDiagnosis_CheckOut_Form.Text) ||
                   string.IsNullOrWhiteSpace(textPrescription.Text);
        }

        private void checkOut_btn_checkOutForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (emptyFields())
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to check out this patient?", "Confirm Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    string VisitID = textVisitID.Text;
                    string updateVisitQuery = @"UPDATE Visits 
                        SET CheckOutTime = @CheckOutTime, 
                            Prescription = @Prescription, 
                            FollowUpDate = @FollowUpDate, 
                            Status = 'Checked Out'
                        WHERE VisitID = @VisitID";
                    cmd = new SqlCommand(updateVisitQuery, conn);
                    cmd.Parameters.AddWithValue("@CheckOutTime", chackOutDate_checkOutForm.Value);
                    cmd.Parameters.AddWithValue("@Prescription", textPrescription.Text);
                    cmd.Parameters.AddWithValue("@FollowUpDate", FollowUpData.Value);
                    cmd.Parameters.AddWithValue("@VisitID", VisitID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient checked out successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var patientControl = this.Parent?.Parent as PatientCheckInOutControl;

                    if (patientControl != null)
                    {
                        patientControl.checkInControl1.Visible = true;
                        patientControl.checkInControl1.BringToFront();
                        this.Visible = false;
                    }

                    textVisitID?.Clear();
                    textPatientID_checkOutForm?.Clear();
                    textPatientName_checkOutForm?.Clear();
                    textPatientDoctor_checkOutForm?.Clear();
                    chackInDate_checkOutForm?.Clear();
                    textRoomNumber_checkOutForm?.Clear();
                    textDiagnosis_CheckOut_Form?.Clear();
                    textPrescription?.Clear();

                    if (chackOutDate_checkOutForm != null) chackOutDate_checkOutForm.Value = DateTime.Now;
                    if (FollowUpData != null) FollowUpData.Value = DateTime.Now;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during checkout: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
