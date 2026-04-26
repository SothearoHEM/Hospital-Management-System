using Hospital_Management_System.Classes;
using Hospital_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Control
{
    public partial class CheckInControl : UserControl
    {
        SqlConnection conn = DatabaseConnection.GetConnection();
        SqlCommand cmd = new SqlCommand();
        public CheckInControl()
        {
            InitializeComponent();
            DisplayCheckInData();
            this.VisibleChanged += CheckInControl_VisibleChanged;
        }

        private void CheckInControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                DisplayCheckInData();
                LoadActiveDoctors();
            }
        }

        private void CheckInControl_Load_1(object sender, EventArgs e)
        {
            LoadActiveDoctors();
        }

        private void LoadActiveDoctors()
        {
            try
            {
                conn.Open();
                string query = @"SELECT DoctorID, FullName
                                 FROM Doctors
                                 WHERE Status = 'Active' AND Is_Deleted = 0
                                 ORDER BY FullName ASC";
                cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                var doctors = new List<DoctorItem>();
                while (reader.Read())
                {
                    doctors.Add(new DoctorItem
                    {
                        DoctorID = reader["DoctorID"].ToString(),
                        DisplayText = reader["DoctorID"].ToString() + " - " + reader["FullName"].ToString()
                    });
                }
                reader.Close();

                textPatientDoctorCheckIn.DisplayMember = "DisplayText"; 
                textPatientDoctorCheckIn.ValueMember = "DoctorID"; 
                textPatientDoctorCheckIn.DataSource = doctors;
                
                textPatientDoctorCheckIn.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public class DoctorItem
        {
            public string DoctorID { get; set; }
            public string DisplayText { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void DisplayCheckInData()
        {
            ActiveVisitData visitData = new ActiveVisitData();
            List<ActiveVisitData> activeVisits = visitData.GetAllActiveVisits();
            checkInGridView.DataSource = activeVisits;
        }
        private void searchPatient_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string searchTerm = textPatientIDCheckIn.Text.Trim();
                string query = @"SELECT PatientID, FullName FROM Patients 
                                 WHERE (PatientID LIKE @SearchTerm OR FullName LIKE @SearchTerm) 
                                 AND Is_Deleted = 0";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);
                textPatientNameCheckIn.Text = dataSet.Tables[0].Rows.Count > 0 ? dataSet.Tables[0].Rows[0]["FullName"].ToString() : "No patient found";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching patient: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void checkIn_btn_checkInForm_Click(object sender, EventArgs e)
        {
            if (emtyFields())
            {
                MessageBox.Show("Please fill in all required fields (marked with *).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string doctorID = textPatientDoctorCheckIn.SelectedValue.ToString();
                string insertQuery = @"INSERT INTO Visits (PatientID, DoctorID, CheckInTime, RoomNo, Reason, Status)
                                       VALUES (@PatientID, @DoctorID, @CheckInTime, @RoomNo, @Reason, @Status)";
                cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@PatientID", textPatientIDCheckIn.Text.Trim());
                cmd.Parameters.AddWithValue("@DoctorID", doctorID); // Inserting the actual ID
                cmd.Parameters.AddWithValue("@CheckInTime", checkInDate_CheckInForm.Value);
                cmd.Parameters.AddWithValue("@RoomNo", textRoomNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Reason", textReasonForVisit.Text.Trim());
                cmd.Parameters.AddWithValue("@Status", "Active");

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient checked in successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayCheckInData();
                    ClearCheckInForm();
                }
                else
                {
                    MessageBox.Show("Check-in failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking in patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private bool emtyFields()
        {
            if (string.IsNullOrWhiteSpace(textPatientIDCheckIn.Text) ||
                string.IsNullOrWhiteSpace(textPatientNameCheckIn.Text) ||
                textPatientDoctorCheckIn.SelectedValue == null ||
                string.IsNullOrWhiteSpace(textRoomNumber.Text) ||
                string.IsNullOrWhiteSpace(textReasonForVisit.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearCheckInForm()
        {
            textPatientIDCheckIn.Clear();
            textPatientNameCheckIn.Clear();
            textPatientDoctorCheckIn.SelectedIndex = -1;
            textRoomNumber.Clear();
            textReasonForVisit.Clear();
            checkInDate_CheckInForm.Value = DateTime.Now;
        }

        private void clear_btn__checkInForm_checkInForm_Click(object sender, EventArgs e)
        {
            ClearCheckInForm();
        }

        private void update_btn__checkInForm_checkInForm_Click(object sender, EventArgs e)
        {
            if (emtyFields())
            {
                MessageBox.Show("Please fill in all required fields (marked with *).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if(checkInGridView.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this visit's information?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        string visitID = checkInGridView.SelectedRows[0].Cells["VisitID"].Value.ToString();
                        string doctorID = textPatientDoctorCheckIn.SelectedValue.ToString();
                        string updateQuery = @"UPDATE Visits 
                                               SET DoctorID = @DoctorID, CheckInTime = @CheckInTime, RoomNo = @RoomNo, Reason = @Reason , Updated_At = @Updated_At
                                               WHERE VisitID = @VisitID";
                        cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                        cmd.Parameters.AddWithValue("@CheckInTime", checkInDate_CheckInForm.Value);
                        cmd.Parameters.AddWithValue("@RoomNo", textRoomNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@Reason", textReasonForVisit.Text.Trim());
                        cmd.Parameters.AddWithValue("@Updated_At", DateTime.Now);
                        cmd.Parameters.AddWithValue("@VisitID", visitID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Visit updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayCheckInData();
                            ClearCheckInForm();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a visit to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating visit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void checkInGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = checkInGridView.Rows[e.RowIndex];
                    string visitID = row.Cells["VisitID"].Value.ToString();
                    string query = @"SELECT v.VisitID, v.PatientID, p.FullName AS PatientName, v.DoctorID, d.FullName AS DoctorName, 
                                     v.CheckInTime, v.RoomNo, v.Reason, v.Status
                                     FROM Visits v
                                     JOIN Patients p ON v.PatientID = p.PatientID
                                     JOIN Doctors d ON v.DoctorID = d.DoctorID
                                     WHERE v.VisitID = @VisitID";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@VisitID", visitID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textPatientIDCheckIn.Text = reader["PatientID"].ToString();
                        textPatientNameCheckIn.Text = reader["PatientName"].ToString();
                        textRoomNumber.Text = reader["RoomNo"].ToString();
                        textReasonForVisit.Text = reader["Reason"].ToString();
                        checkInDate_CheckInForm.Value = Convert.ToDateTime(reader["CheckInTime"]);
                        string doctorID = reader["DoctorID"].ToString();
                        for (int i = 0; i < textPatientDoctorCheckIn.Items.Count; i++)
                        {
                            DoctorItem item = (DoctorItem)textPatientDoctorCheckIn.Items[i];
                            if (item.DoctorID == doctorID)
                            {
                                textPatientDoctorCheckIn.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading visit details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void delete_btn_checkInForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInGridView.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this visit?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        string visitID = checkInGridView.SelectedRows[0].Cells["VisitID"].Value.ToString();
                        string deleteQuery = @"UPDATE Visits SET Is_Deleted = 1, Status = 'Inactive', Updated_At = @Updated_At WHERE VisitID = @VisitID";
                        cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@VisitID", visitID);
                        cmd.Parameters.AddWithValue("@Updated_At", DateTime.Now);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Visit deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayCheckInData();
                            ClearCheckInForm();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a visit to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting visit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void checkOut_btn_checkInForm_Click(object sender, EventArgs e)
        {
            if (checkInGridView.SelectedRows.Count > 0)
            {
                int visitID = Convert.ToInt32(checkInGridView.SelectedRows[0].Cells["VisitID"].Value);

                var patientControl = this.Parent?.Parent as PatientCheckInOutControl;

                if (patientControl != null)
                {
                    patientControl.checkOutControl1.LoadCheckOutData(visitID);
                    patientControl.checkOutControl1.Visible = true;
                    patientControl.checkOutControl1.BringToFront();

                    this.Visible = false;
                }
                else
                {
                    var mainDashboard = this.FindForm() as MainDashboard;

                }

                ClearCheckInForm();
            }
            else
            {
                MessageBox.Show("Please select a visit to check out.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
