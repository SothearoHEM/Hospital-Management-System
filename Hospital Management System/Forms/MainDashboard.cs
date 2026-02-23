using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Forms
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void dashboard_close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dasboard_btn_Click(object sender, EventArgs e)
        {
            dashhboradControl1.Visible = true;
            doctorManagementControl1.Visible = false;
            patientManagementControl1.Visible = false;
            patientCheckInOutControl1.Visible = false;
        }

        private void doctorManage_btn_Click(object sender, EventArgs e)
        {
            dashhboradControl1.Visible = false;
            doctorManagementControl1.Visible = true;
            patientManagementControl1.Visible = false;
            patientCheckInOutControl1.Visible = false;
        }

        private void patientManage_btn_Click(object sender, EventArgs e)
        {
            dashhboradControl1.Visible = false;
            doctorManagementControl1.Visible = false;
            patientManagementControl1.Visible = true;
            patientCheckInOutControl1.Visible = false;
        }

        private void checkInOutManage_btn_Click(object sender, EventArgs e)
        {
            dashhboradControl1.Visible = false;
            doctorManagementControl1.Visible = false;
            patientManagementControl1.Visible = false;
            patientCheckInOutControl1.Visible = true;
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
