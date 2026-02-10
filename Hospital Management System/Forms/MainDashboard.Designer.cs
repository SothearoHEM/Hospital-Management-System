namespace Hospital_Management_System.Forms
{
    partial class MainDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard_close_btn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.checkInOutManage_btn = new System.Windows.Forms.Button();
            this.patientManage_btn = new System.Windows.Forms.Button();
            this.doctorManage_btn = new System.Windows.Forms.Button();
            this.dasboard_btn = new System.Windows.Forms.Button();
            this.doctorManagementControl1 = new Hospital_Management_System.Control.DoctorManagementControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dashboard_close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management System - Dashboard";
            // 
            // dashboard_close_btn
            // 
            this.dashboard_close_btn.AutoSize = true;
            this.dashboard_close_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_close_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboard_close_btn.Location = new System.Drawing.Point(1401, 9);
            this.dashboard_close_btn.Name = "dashboard_close_btn";
            this.dashboard_close_btn.Size = new System.Drawing.Size(37, 37);
            this.dashboard_close_btn.TabIndex = 0;
            this.dashboard_close_btn.Text = "X";
            this.dashboard_close_btn.Click += new System.EventHandler(this.dashboard_close_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.logOut_btn);
            this.panel2.Controls.Add(this.report_btn);
            this.panel2.Controls.Add(this.checkInOutManage_btn);
            this.panel2.Controls.Add(this.patientManage_btn);
            this.panel2.Controls.Add(this.doctorManage_btn);
            this.panel2.Controls.Add(this.dasboard_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 730);
            this.panel2.TabIndex = 2;
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut_btn.Location = new System.Drawing.Point(12, 644);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(225, 65);
            this.logOut_btn.TabIndex = 5;
            this.logOut_btn.Text = "LogOut";
            this.logOut_btn.UseVisualStyleBackColor = false;
            // 
            // report_btn
            // 
            this.report_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.report_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.report_btn.Location = new System.Drawing.Point(12, 391);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(225, 65);
            this.report_btn.TabIndex = 4;
            this.report_btn.Text = "Report";
            this.report_btn.UseVisualStyleBackColor = false;
            // 
            // checkInOutManage_btn
            // 
            this.checkInOutManage_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkInOutManage_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInOutManage_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkInOutManage_btn.Location = new System.Drawing.Point(12, 300);
            this.checkInOutManage_btn.Name = "checkInOutManage_btn";
            this.checkInOutManage_btn.Size = new System.Drawing.Size(225, 65);
            this.checkInOutManage_btn.TabIndex = 3;
            this.checkInOutManage_btn.Text = "Check In/Out Management";
            this.checkInOutManage_btn.UseVisualStyleBackColor = false;
            // 
            // patientManage_btn
            // 
            this.patientManage_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.patientManage_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientManage_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.patientManage_btn.Location = new System.Drawing.Point(12, 212);
            this.patientManage_btn.Name = "patientManage_btn";
            this.patientManage_btn.Size = new System.Drawing.Size(225, 65);
            this.patientManage_btn.TabIndex = 2;
            this.patientManage_btn.Text = "Patients Management";
            this.patientManage_btn.UseVisualStyleBackColor = false;
            // 
            // doctorManage_btn
            // 
            this.doctorManage_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.doctorManage_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorManage_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.doctorManage_btn.Location = new System.Drawing.Point(12, 119);
            this.doctorManage_btn.Name = "doctorManage_btn";
            this.doctorManage_btn.Size = new System.Drawing.Size(225, 65);
            this.doctorManage_btn.TabIndex = 1;
            this.doctorManage_btn.Text = "Doctors Management";
            this.doctorManage_btn.UseVisualStyleBackColor = false;
            // 
            // dasboard_btn
            // 
            this.dasboard_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dasboard_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dasboard_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dasboard_btn.Location = new System.Drawing.Point(12, 24);
            this.dasboard_btn.Name = "dasboard_btn";
            this.dasboard_btn.Size = new System.Drawing.Size(225, 65);
            this.dasboard_btn.TabIndex = 0;
            this.dasboard_btn.Text = "Dashboard";
            this.dasboard_btn.UseVisualStyleBackColor = false;
            // 
            // doctorManagementControl1
            // 
            this.doctorManagementControl1.Location = new System.Drawing.Point(256, 76);
            this.doctorManagementControl1.Name = "doctorManagementControl1";
            this.doctorManagementControl1.Size = new System.Drawing.Size(1190, 716);
            this.doctorManagementControl1.TabIndex = 3;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.doctorManagementControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashboard_close_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dasboard_btn;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.Button checkInOutManage_btn;
        private System.Windows.Forms.Button patientManage_btn;
        private System.Windows.Forms.Button doctorManage_btn;
        private Control.DoctorManagementControl doctorManagementControl1;
    }
}