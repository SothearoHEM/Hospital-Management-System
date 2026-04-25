using Hospital_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System.Control
{
    public partial class DoctorManagementControl : UserControl
    {
        SqlConnection cn = DatabaseConnection.GetConnection();
        SqlCommand cmd;
        
        // Add a field to keep track of the chosen image.
        private string selectedImagePath = string.Empty;

        public DoctorManagementControl()
        {
            InitializeComponent();
            this.Load += DoctorManagementControl_Load;
        }

        private void DoctorManagementControl_Load(object sender, EventArgs e)
        {
            // Only load data at runtime, not in design mode
            if (!this.DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                displayDoctors();
            }
        }
        public void ClearInputFields()
        {
            textDoctorID.Clear();
            textDoctorFullName.Clear();
            comboDoctorGender.SelectedIndex = -1;
            textDoctorSpecialization.Clear();
            textDoctorPhoneNumber.Clear();
            textDoctorEmail.Clear();
            comboDoctorStatus.SelectedIndex = -1;
            textDoctorLicenseNumber.Clear();
            selectedImagePath = string.Empty;
            if (pictureDoctor.Image != null)
            {
                pictureDoctor.Image.Dispose();
                pictureDoctor.Image = null;
            }
        }



        private void doctorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displayDoctors()
        {
            DoctorData doctorData = new DoctorData();
            List<DoctorData> doctors = doctorData.GetAllDoctors();
            doctorGridView.DataSource = doctors;
        }
        public bool EmptyFields()
        {
            if (string.IsNullOrWhiteSpace(textDoctorID.Text) ||
                string.IsNullOrWhiteSpace(textDoctorFullName.Text) ||
                comboDoctorGender.SelectedIndex == -1 || 
                string.IsNullOrWhiteSpace(textDoctorSpecialization.Text) ||
                string.IsNullOrWhiteSpace(textDoctorPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(textDoctorEmail.Text) ||
                comboDoctorStatus.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textDoctorLicenseNumber.Text) ||
                string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void addDoctor_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmptyFields())
                {
                    return;
                }

                string relativePath = null;

                // Handle Image Copying & Path Generation
                if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                {
                    string directoryPath = Path.Combine(Application.StartupPath, "DoctorsDirectory");
                    
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // Use DoctorID for unique naming to prevent overwrites, appending original extension
                    string fileExtension = Path.GetExtension(selectedImagePath);
                    string fileName = textDoctorID.Text.Trim() + fileExtension;
                    string destinationPath = Path.Combine(directoryPath, fileName);

                    File.Copy(selectedImagePath, destinationPath, true);

                    // Create the relative path for the database
                    relativePath = Path.Combine("DoctorsDirectory", fileName);
                }

                cn.Open();
                String sqlInsertCmd = "INSERT INTO Doctors (DoctorID, FullName, Gender, Specialization, Phone, Email, Status, LicenseNo, Img_Path) " +
                                      "VALUES (@DoctorID, @FullName, @Gender, @Specialization, @Phone, @Email, @Status, @LicenseNo, @Img_Path)";
                cmd = new SqlCommand(sqlInsertCmd, cn);

                cmd.Parameters.AddWithValue("@DoctorID", textDoctorID.Text);
                cmd.Parameters.AddWithValue("@FullName", textDoctorFullName.Text);
                cmd.Parameters.AddWithValue("@Gender", comboDoctorGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Specialization", textDoctorSpecialization.Text);
                cmd.Parameters.AddWithValue("@Phone", textDoctorPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Email", textDoctorEmail.Text);
                cmd.Parameters.AddWithValue("@Status", comboDoctorStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@LicenseNo", textDoctorLicenseNumber.Text);
                
                // Use the relative path if an image was selected, otherwise use DBNull
                if (relativePath != null)
                    cmd.Parameters.AddWithValue("@Img_Path", relativePath);
                else
                    cmd.Parameters.AddWithValue("@Img_Path", DBNull.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                displayDoctors();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void doctorImportImg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                    openFileDialog.Title = "Select Doctor Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedImagePath = openFileDialog.FileName;
                        pictureDoctor.Image = Image.FromFile(selectedImagePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearDoctor_btn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void updateDoctor_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmptyFields())
                {
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to update this doctor's information?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string relativePath = null;

                    // Handle Image Path & Copying
                    if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        string directoryPath = Path.Combine(Application.StartupPath, "DoctorsDirectory");
                        string fileExtension = Path.GetExtension(selectedImagePath);
                        string fileName = textDoctorID.Text.Trim() + fileExtension;
                        string destinationPath = Path.Combine(directoryPath, fileName);

                        // If the currently selected image isn't already the final destination path, copy it.
                        if (!selectedImagePath.Equals(destinationPath, StringComparison.OrdinalIgnoreCase))
                        {
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            // Dispose the image preview so we release the file lock before potentially overwriting it
                            if (pictureDoctor.Image != null)
                            {
                                pictureDoctor.Image.Dispose();
                                pictureDoctor.Image = null;
                            }

                            File.Copy(selectedImagePath, destinationPath, true);
                        }

                        // Set the relative path for the database
                        relativePath = Path.Combine("DoctorsDirectory", fileName);
                    }

                    cn.Open();
                    String sqlUpdateCmd = "UPDATE Doctors SET FullName = @FullName, Gender = @Gender, Specialization = @Specialization, Phone = @Phone, Email = @Email, Status = @Status, LicenseNo = @LicenseNo, Img_Path = @Img_Path , Updated_At = @Updated_At " +
                                          "WHERE DoctorID = @DoctorID";
                    cmd = new SqlCommand(sqlUpdateCmd, cn);
                    cmd.Parameters.AddWithValue("@DoctorID", textDoctorID.Text);
                    cmd.Parameters.AddWithValue("@FullName", textDoctorFullName.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboDoctorGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Specialization", textDoctorSpecialization.Text);
                    cmd.Parameters.AddWithValue("@Phone", textDoctorPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", textDoctorEmail.Text);
                    cmd.Parameters.AddWithValue("@Status", comboDoctorStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LicenseNo", textDoctorLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@Updated_At", DateTime.Now);

                    // Use the relative path if an image exists, otherwise DBNull
                    if (relativePath != null)
                        cmd.Parameters.AddWithValue("@Img_Path", relativePath);
                    else
                        cmd.Parameters.AddWithValue("@Img_Path", DBNull.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    displayDoctors();
                    ClearInputFields();
                    
                }
                else
                {
                    MessageBox.Show("Update cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void doctorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = doctorGridView.Rows[e.RowIndex];
                textDoctorID.Text = row.Cells["DoctorID"].Value.ToString();
                textDoctorFullName.Text = row.Cells["FullName"].Value.ToString();
                comboDoctorGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                textDoctorSpecialization.Text = row.Cells["Specialization"].Value.ToString();
                textDoctorPhoneNumber.Text = row.Cells["Phone"].Value.ToString();
                textDoctorEmail.Text = row.Cells["Email"].Value.ToString();
                comboDoctorStatus.SelectedItem = row.Cells["Status"].Value.ToString();
                textDoctorLicenseNumber.Text = row.Cells["LicenseNo"].Value.ToString();
                try
                {
                    if (row.Cells["Img_Path"].Value != DBNull.Value)
                    {
                        string imgPath = Path.Combine(Application.StartupPath, row.Cells["Img_Path"].Value.ToString());
                        if (File.Exists(imgPath))
                        {
                            pictureDoctor.Image = Image.FromFile(imgPath);
                            selectedImagePath = imgPath; // Update the selected image path
                        }
                        else
                        {
                            pictureDoctor.Image = null;
                            selectedImagePath = string.Empty;
                        }
                    }
                    else
                    {
                        pictureDoctor.Image = null;
                        selectedImagePath = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureDoctor.Image = null;
                    selectedImagePath = string.Empty;
                }
            }
        }

        private void deleteDoctor_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textDoctorID.Text))
                {
                    MessageBox.Show("Please select a doctor to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    String sqlDeleteCmd = "UPDATE Doctors SET Is_Deleted = 1, Status = 'Inactive' WHERE DoctorID = @DoctorID";
                    cmd = new SqlCommand(sqlDeleteCmd, cn);
                    cmd.Parameters.AddWithValue("@DoctorID", textDoctorID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displayDoctors();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
