using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Report_Viewer.Forms
{
    public partial class PatienMedicalBillReceipt : Form
    {
        public PatienMedicalBillReceipt()
        {
            InitializeComponent();
        }

        private void PatienMedicalBillReceipt_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
