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
    public partial class PatientCheckInOutControl : UserControl
    {
        public PatientCheckInOutControl()
        {
            InitializeComponent();
        }

        private void checkIn_btn_Click(object sender, EventArgs e)
        {
            checkInControl1.Visible = true;
            checkOutControl1.Visible = false;
        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            checkOutControl1.Visible = true;
            checkInControl1.Visible = false;
        }
    }
}
