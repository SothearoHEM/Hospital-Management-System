namespace Hospital_Management_System.Report_Viewer.Forms
{
    partial class DoctorsReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.doctorReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerDoctor = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.doctorReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorReportModelBindingSource
            // 
            this.doctorReportModelBindingSource.DataSource = typeof(Hospital_Management_System.Report_Viewer.Classes.DoctorReportModel);
            // 
            // reportViewerDoctor
            // 
            this.reportViewerDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DoctorsDataSet";
            reportDataSource1.Value = this.doctorReportModelBindingSource;
            this.reportViewerDoctor.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDoctor.LocalReport.ReportEmbeddedResource = "Hospital_Management_System.Report Viewer.WiZards.DoctorsWizard.rdlc";
            this.reportViewerDoctor.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDoctor.Name = "reportViewerDoctor";
            this.reportViewerDoctor.ServerReport.BearerToken = null;
            this.reportViewerDoctor.Size = new System.Drawing.Size(1334, 719);
            this.reportViewerDoctor.TabIndex = 0;
            // 
            // DoctorsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 719);
            this.Controls.Add(this.reportViewerDoctor);
            this.Name = "DoctorsReportForm";
            this.Text = "DoctorsReportForm";
            this.Load += new System.EventHandler(this.DoctorsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDoctor;
        private System.Windows.Forms.BindingSource doctorReportModelBindingSource;
    }
}