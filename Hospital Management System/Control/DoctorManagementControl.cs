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
    public partial class DoctorManagementControl : UserControl
    {
        public DoctorManagementControl()
        {
            InitializeComponent();
            displayDoctors();
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
    }
}
