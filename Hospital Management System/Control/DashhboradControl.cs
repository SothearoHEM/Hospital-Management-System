using Hospital_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Control
{
    public partial class DashhboradControl : UserControl
    {
        public DashhboradControl()
        {
            InitializeComponent();
            RefreshData();
            this.VisibleChanged += DashhboradControl_VisibleChanged;
        }

        private void DashhboradControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                RefreshData();
            }
        }

        public void RefreshData()
        {
            DisplayTodayVisit();
            DisplayTotalDoctors();
            DisplayTotalPatients();
            DisplayTotalActiveVisits();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void DisplayTodayVisit()
        {
            ActiveVisitData visitData = new ActiveVisitData();
            List<ActiveVisitData> todayVisits = visitData.GetTodayActiveVisits();
            dashboardGridView.DataSource = todayVisits;
        }
        public void DisplayTotalDoctors()
        {
            DoctorData doctorData = new DoctorData();
            dashboardTotalDoctorsLabel.Text = doctorData.getTotalDoctors().ToString();
        }
        public void DisplayTotalPatients()
        {
            PatientData patientData = new PatientData();
            dashboardTotalPatientsLabel.Text = patientData.getTotalPatients().ToString();
        }
        public void DisplayTotalActiveVisits()
        {
            ActiveVisitData visitData = new ActiveVisitData();
            dashboardVisitsLabel.Text = visitData.getTotalActiveVisits().ToString();
        }
    }
}
