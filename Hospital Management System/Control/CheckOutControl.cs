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

                        // Make sure controls exist and are not null
                        MessageBox.Show("visit id: " + row["VisitID"] + ", patient id: " + row["PatientID"] + ", patient name: " + row["PatientName"] + ", doctor name: " + row["AssignedDoctor"] + ", check in time: " + row["CheckInTime"] + ", room no: " + row["RoomNo"] + ", diagnosis: " + row["Diagnosis"]);

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
    }
}
