namespace Hospital_Management_System.Control
{
    partial class CheckInControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_btn_checkInForm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkOut_btn_checkInForm = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.checkInGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPatientDoctorCheckIn = new System.Windows.Forms.ComboBox();
            this.PrintVisitsReport_btn = new System.Windows.Forms.Button();
            this.clear_btn__checkInForm_checkInForm = new System.Windows.Forms.Button();
            this.checkIn_btn_checkInForm = new System.Windows.Forms.Button();
            this.textReasonForVisit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textRoomNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkInDate_CheckInForm = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPatientNameCheckIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchPatient_btn = new System.Windows.Forms.Button();
            this.textPatientIDCheckIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete_btn_checkInForm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkOut_btn_checkInForm);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.checkInGridView);
            this.panel1.Location = new System.Drawing.Point(8, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 314);
            this.panel1.TabIndex = 1;
            // 
            // delete_btn_checkInForm
            // 
            this.delete_btn_checkInForm.BackColor = System.Drawing.Color.IndianRed;
            this.delete_btn_checkInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn_checkInForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_btn_checkInForm.Location = new System.Drawing.Point(699, 269);
            this.delete_btn_checkInForm.Name = "delete_btn_checkInForm";
            this.delete_btn_checkInForm.Size = new System.Drawing.Size(218, 40);
            this.delete_btn_checkInForm.TabIndex = 52;
            this.delete_btn_checkInForm.Text = "Delete";
            this.delete_btn_checkInForm.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 51;
            this.label3.Text = "Active Visits";
            // 
            // checkOut_btn_checkInForm
            // 
            this.checkOut_btn_checkInForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkOut_btn_checkInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_btn_checkInForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkOut_btn_checkInForm.Location = new System.Drawing.Point(921, 269);
            this.checkOut_btn_checkInForm.Name = "checkOut_btn_checkInForm";
            this.checkOut_btn_checkInForm.Size = new System.Drawing.Size(218, 40);
            this.checkOut_btn_checkInForm.TabIndex = 50;
            this.checkOut_btn_checkInForm.Text = "Check Out";
            this.checkOut_btn_checkInForm.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(409, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 23);
            this.label13.TabIndex = 50;
            this.label13.Text = "Selected Patient to Check Out *";
            // 
            // checkInGridView
            // 
            this.checkInGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkInGridView.Location = new System.Drawing.Point(3, 38);
            this.checkInGridView.Name = "checkInGridView";
            this.checkInGridView.RowHeadersWidth = 51;
            this.checkInGridView.RowTemplate.Height = 24;
            this.checkInGridView.Size = new System.Drawing.Size(1136, 225);
            this.checkInGridView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textPatientDoctorCheckIn);
            this.panel2.Controls.Add(this.PrintVisitsReport_btn);
            this.panel2.Controls.Add(this.clear_btn__checkInForm_checkInForm);
            this.panel2.Controls.Add(this.checkIn_btn_checkInForm);
            this.panel2.Controls.Add(this.textReasonForVisit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textRoomNumber);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.checkInDate_CheckInForm);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textPatientNameCheckIn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.searchPatient_btn);
            this.panel2.Controls.Add(this.textPatientIDCheckIn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 307);
            this.panel2.TabIndex = 2;
            // 
            // textPatientDoctorCheckIn
            // 
            this.textPatientDoctorCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientDoctorCheckIn.FormattingEnabled = true;
            this.textPatientDoctorCheckIn.Location = new System.Drawing.Point(761, 63);
            this.textPatientDoctorCheckIn.Name = "textPatientDoctorCheckIn";
            this.textPatientDoctorCheckIn.Size = new System.Drawing.Size(361, 37);
            this.textPatientDoctorCheckIn.TabIndex = 51;
            // 
            // PrintVisitsReport_btn
            // 
            this.PrintVisitsReport_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PrintVisitsReport_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintVisitsReport_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintVisitsReport_btn.Location = new System.Drawing.Point(242, 251);
            this.PrintVisitsReport_btn.Name = "PrintVisitsReport_btn";
            this.PrintVisitsReport_btn.Size = new System.Drawing.Size(274, 45);
            this.PrintVisitsReport_btn.TabIndex = 50;
            this.PrintVisitsReport_btn.Text = "Print Visits Report";
            this.PrintVisitsReport_btn.UseVisualStyleBackColor = false;
            // 
            // clear_btn__checkInForm_checkInForm
            // 
            this.clear_btn__checkInForm_checkInForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clear_btn__checkInForm_checkInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn__checkInForm_checkInForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_btn__checkInForm_checkInForm.Location = new System.Drawing.Point(8, 200);
            this.clear_btn__checkInForm_checkInForm.Name = "clear_btn__checkInForm_checkInForm";
            this.clear_btn__checkInForm_checkInForm.Size = new System.Drawing.Size(218, 45);
            this.clear_btn__checkInForm_checkInForm.TabIndex = 49;
            this.clear_btn__checkInForm_checkInForm.Text = "Clear";
            this.clear_btn__checkInForm_checkInForm.UseVisualStyleBackColor = false;
            // 
            // checkIn_btn_checkInForm
            // 
            this.checkIn_btn_checkInForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkIn_btn_checkInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_btn_checkInForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkIn_btn_checkInForm.Location = new System.Drawing.Point(8, 251);
            this.checkIn_btn_checkInForm.Name = "checkIn_btn_checkInForm";
            this.checkIn_btn_checkInForm.Size = new System.Drawing.Size(218, 45);
            this.checkIn_btn_checkInForm.TabIndex = 48;
            this.checkIn_btn_checkInForm.Text = "Check In Patient";
            this.checkIn_btn_checkInForm.UseVisualStyleBackColor = false;
            // 
            // textReasonForVisit
            // 
            this.textReasonForVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textReasonForVisit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReasonForVisit.Location = new System.Drawing.Point(761, 155);
            this.textReasonForVisit.Multiline = true;
            this.textReasonForVisit.Name = "textReasonForVisit";
            this.textReasonForVisit.Size = new System.Drawing.Size(361, 141);
            this.textReasonForVisit.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(756, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 27);
            this.label11.TabIndex = 44;
            this.label11.Text = "Reason for Visit *";
            // 
            // textRoomNumber
            // 
            this.textRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRoomNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoomNumber.Location = new System.Drawing.Point(386, 157);
            this.textRoomNumber.Name = "textRoomNumber";
            this.textRoomNumber.Size = new System.Drawing.Size(354, 33);
            this.textRoomNumber.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 27);
            this.label9.TabIndex = 40;
            this.label9.Text = "Room Number";
            // 
            // checkInDate_CheckInForm
            // 
            this.checkInDate_CheckInForm.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDate_CheckInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDate_CheckInForm.Location = new System.Drawing.Point(8, 155);
            this.checkInDate_CheckInForm.Name = "checkInDate_CheckInForm";
            this.checkInDate_CheckInForm.Size = new System.Drawing.Size(364, 33);
            this.checkInDate_CheckInForm.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 27);
            this.label8.TabIndex = 38;
            this.label8.Text = "Check-In Date & Time *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(756, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Assigned Doctor *";
            // 
            // textPatientNameCheckIn
            // 
            this.textPatientNameCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientNameCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientNameCheckIn.Location = new System.Drawing.Point(381, 66);
            this.textPatientNameCheckIn.Name = "textPatientNameCheckIn";
            this.textPatientNameCheckIn.ReadOnly = true;
            this.textPatientNameCheckIn.Size = new System.Drawing.Size(359, 33);
            this.textPatientNameCheckIn.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Patient Name";
            // 
            // searchPatient_btn
            // 
            this.searchPatient_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchPatient_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatient_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchPatient_btn.Location = new System.Drawing.Point(254, 60);
            this.searchPatient_btn.Name = "searchPatient_btn";
            this.searchPatient_btn.Size = new System.Drawing.Size(118, 39);
            this.searchPatient_btn.TabIndex = 27;
            this.searchPatient_btn.Text = "Search";
            this.searchPatient_btn.UseVisualStyleBackColor = false;
            this.searchPatient_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPatientIDCheckIn
            // 
            this.textPatientIDCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientIDCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientIDCheckIn.Location = new System.Drawing.Point(8, 66);
            this.textPatientIDCheckIn.Name = "textPatientIDCheckIn";
            this.textPatientIDCheckIn.Size = new System.Drawing.Size(240, 33);
            this.textPatientIDCheckIn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient ID *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In Form";
            // 
            // CheckInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckInControl";
            this.Size = new System.Drawing.Size(1165, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPatientIDCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchPatient_btn;
        private System.Windows.Forms.TextBox textPatientNameCheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker checkInDate_CheckInForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRoomNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textReasonForVisit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView checkInGridView;
        private System.Windows.Forms.Button clear_btn__checkInForm_checkInForm;
        private System.Windows.Forms.Button checkIn_btn_checkInForm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button checkOut_btn_checkInForm;
        private System.Windows.Forms.Button delete_btn_checkInForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrintVisitsReport_btn;
        private System.Windows.Forms.ComboBox textPatientDoctorCheckIn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
