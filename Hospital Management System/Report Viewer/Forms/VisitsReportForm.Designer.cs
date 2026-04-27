namespace Hospital_Management_System.Report_Viewer.Forms
{
    partial class VisitsReportForm
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
            this.reportViewerVisits = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerVisits
            // 
            this.reportViewerVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerVisits.LocalReport.ReportEmbeddedResource = "Hospital_Management_System.Report Viewer.WiZards.VisitsWizard.rdlc";
            this.reportViewerVisits.Location = new System.Drawing.Point(0, 0);
            this.reportViewerVisits.Name = "reportViewerVisits";
            this.reportViewerVisits.ServerReport.BearerToken = null;
            this.reportViewerVisits.Size = new System.Drawing.Size(1334, 719);
            this.reportViewerVisits.TabIndex = 0;
            // 
            // VisitsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 719);
            this.Controls.Add(this.reportViewerVisits);
            this.Name = "VisitsReportForm";
            this.Text = "VisitsReportForm";
            this.Load += new System.EventHandler(this.VisitsReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVisits;
    }
}