using Hospital_Management_System.Report_Viewer.Forms;
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
using static Hospital_Management_System.Control.CheckInControl;

namespace Hospital_Management_System.Control
{
    public partial class PatientManagementControl : UserControl
    {
        SqlConnection cn = DatabaseConnection.GetConnection();
        SqlCommand cmd;

        public PatientManagementControl()
        {
            InitializeComponent();
            this.Load += PatientManagementControl_Load;
            this.VisibleChanged += PatientManagementControl_VisibleChanged;
        }

        private void PatientManagementControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && !this.DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                displayPatientsData();
                LoadActiveDoctors();
            }
        }
        private void PatientManagementControl_Load_1(object sender, EventArgs e)
        {
            LoadActiveDoctors();
        }

        private void LoadActiveDoctors()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                string query = @"SELECT DoctorID, FullName
                                 FROM Doctors
                                 WHERE Status = 'Active' AND Is_Deleted = 0
                                 ORDER BY FullName ASC";
                cmd = new SqlCommand(query, cn);
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

                comboPatientAssignedDoctor.DisplayMember = "DisplayText";
                comboPatientAssignedDoctor.ValueMember = "DoctorID";
                comboPatientAssignedDoctor.DataSource = doctors;

                comboPatientAssignedDoctor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

        private void PatientManagementControl_Load(object sender, EventArgs e)
        {
            // Only load data at runtime, not in design mode
            if (!this.DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                displayPatientsData();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void displayPatientsData()
        {
            Classes.PatientData patientData = new Classes.PatientData();
            List<Classes.PatientData> patients = patientData.GetAllPatients();
            patientGridView.DataSource = patients;
        }

        public void ClearInputFields()
        {
            textPatientID.Clear();
            textPatientFirstName.Clear();
            comboPatientGender.SelectedIndex = -1;
            patientDOB.Value = DateTime.Now.AddYears(-30);
            textPatientPhoneNumber.Clear();
            textPatientAddress.Clear();
            comboPatientAssignedDoctor.SelectedIndex = -1;
            comboPatientBloodType.SelectedIndex = -1;
            textPatientAllergies.Clear();
            textPatientDiagnosis.Clear();
        }

        public bool EmptyFields()
        {
            if (string.IsNullOrWhiteSpace(textPatientID.Text) ||
                string.IsNullOrWhiteSpace(textPatientFirstName.Text) ||
                comboPatientGender.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textPatientPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(textPatientAddress.Text) ||
                comboPatientAssignedDoctor.SelectedIndex == -1 ||
                comboPatientBloodType.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textPatientAllergies.Text) ||
                string.IsNullOrWhiteSpace(textPatientDiagnosis.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void addPatient_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmptyFields())
                {
                    return;
                }

                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                String sqlInsertCmd = @"INSERT INTO Patients (PatientID, FullName, DOB, Gender, Phone, Address, DoctorID, BloodType, Allergies, Diagnosis)
                                       VALUES (@PatientID, @FullName, @DOB, @Gender, @Phone, @Address,@DoctorID, @BloodType, @Allergies, @Diagnosis)";
                cmd = new SqlCommand(sqlInsertCmd, cn);

                cmd.Parameters.AddWithValue("@PatientID", textPatientID.Text);
                cmd.Parameters.AddWithValue("@FullName", textPatientFirstName.Text);
                cmd.Parameters.AddWithValue("@DOB", patientDOB.Value);
                cmd.Parameters.AddWithValue("@Gender", comboPatientGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", textPatientPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Address", textPatientAddress.Text);
                cmd.Parameters.AddWithValue("@DoctorID", comboPatientAssignedDoctor.SelectedValue != null ? comboPatientAssignedDoctor.SelectedValue.ToString() : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@BloodType", comboPatientBloodType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Allergies", textPatientAllergies.Text);
                cmd.Parameters.AddWithValue("@Diagnosis", textPatientDiagnosis.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                displayPatientsData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void updatePatient_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textPatientID.Text))
                {
                    MessageBox.Show("Please select a patient to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EmptyFields())
                {
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to update this patient's information?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    String sqlUpdateCmd = @"UPDATE Patients SET FullName = @FullName, DOB = @DOB, Gender = @Gender, Phone = @Phone, Address = @Address,DoctorID = @DoctorID, BloodType = @BloodType, Allergies = @Allergies, Diagnosis = @Diagnosis, Updated_At = @Updated_At
                                             WHERE PatientID = @PatientID";
                    cmd = new SqlCommand(sqlUpdateCmd, cn);

                    cmd.Parameters.AddWithValue("@PatientID", textPatientID.Text);
                    cmd.Parameters.AddWithValue("@FullName", textPatientFirstName.Text);
                    cmd.Parameters.AddWithValue("@DOB", patientDOB.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboPatientGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone", textPatientPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Address", textPatientAddress.Text);
                    cmd.Parameters.AddWithValue("@DoctorID", comboPatientAssignedDoctor.SelectedValue != null ? comboPatientAssignedDoctor.SelectedValue.ToString() : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@BloodType", comboPatientBloodType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Allergies", textPatientAllergies.Text);
                    cmd.Parameters.AddWithValue("@Diagnosis", textPatientDiagnosis.Text);
                    cmd.Parameters.AddWithValue("@Updated_At", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displayPatientsData();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void deletePatient_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textPatientID.Text))
                {
                    MessageBox.Show("Please select a patient to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    String sqlDeleteCmd = "UPDATE Patients SET Is_Deleted = 1, Updated_At = @Updated_At WHERE PatientID = @PatientID";
                    cmd = new SqlCommand(sqlDeleteCmd, cn);

                    cmd.Parameters.AddWithValue("@PatientID", textPatientID.Text);
                    cmd.Parameters.AddWithValue("@Updated_At", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displayPatientsData();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void clearPatient_btn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void patientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = patientGridView.Rows[e.RowIndex];
                textPatientID.Text = row.Cells["PatientID"].Value?.ToString();
                textPatientFirstName.Text = row.Cells["FullName"].Value?.ToString();
                comboPatientGender.SelectedItem = row.Cells["Gender"].Value?.ToString();

                if (row.Cells["DOB"].Value != DBNull.Value && row.Cells["DOB"].Value != null)
                {
                    patientDOB.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                }

                textPatientPhoneNumber.Text = row.Cells["Phone"].Value?.ToString();
                textPatientAddress.Text = row.Cells["Address"].Value?.ToString();
                comboPatientAssignedDoctor.SelectedValue = row.Cells["DoctorID"].Value?.ToString();
                comboPatientBloodType.SelectedItem = row.Cells["BloodType"].Value?.ToString();
                textPatientAllergies.Text = row.Cells["Allergies"].Value?.ToString();
                textPatientDiagnosis.Text = row.Cells["Diagnosis"].Value?.ToString();
            }
        }

        private void PrintPatientsReport_btn_Click(object sender, EventArgs e)
        {
            PatientsReportForm reportForm = new PatientsReportForm();
            reportForm.Show();
        }

      
    }
}
