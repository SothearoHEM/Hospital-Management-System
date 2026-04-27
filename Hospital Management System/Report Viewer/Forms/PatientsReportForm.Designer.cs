namespace Hospital_Management_System.Report_Viewer.Forms
{
    partial class PatientsReportForm
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
            this.reportViewerPatients = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPatients
            // 
            this.reportViewerPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPatients.LocalReport.ReportEmbeddedResource = "Hospital_Management_System.Report Viewer.WiZards.PatientsWizard.rdlc";
            this.reportViewerPatients.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPatients.Name = "reportViewerPatients";
            this.reportViewerPatients.ServerReport.BearerToken = null;
            this.reportViewerPatients.Size = new System.Drawing.Size(1334, 719);
            this.reportViewerPatients.TabIndex = 0;
            // 
            // PatientsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 719);
            this.Controls.Add(this.reportViewerPatients);
            this.Name = "PatientsReportForm";
            this.Text = "PatientsReportForm";
            this.Load += new System.EventHandler(this.PatientsReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPatients;
    }
}