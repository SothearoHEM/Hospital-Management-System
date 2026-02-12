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
            this.checkOut_btn_checkInForm = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.checkInGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear_btn__checkInForm_checkInForm = new System.Windows.Forms.Button();
            this.checkIn_btn_checkInForm = new System.Windows.Forms.Button();
            this.textCurrentSym = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textReasonForVisit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboVisitType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textRoomNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkInDate_CheckInForm = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textPatientBloodTypeCheckIn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPatientDoctorCheckIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPatientGenderCheckIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPatientAgeCheckIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPatientNameCheckIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchPatient_btn = new System.Windows.Forms.Button();
            this.textPatientIDCheckIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkOut_btn_checkInForm);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.checkInGridView);
            this.panel1.Location = new System.Drawing.Point(8, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 255);
            this.panel1.TabIndex = 1;
            // 
            // checkOut_btn_checkInForm
            // 
            this.checkOut_btn_checkInForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkOut_btn_checkInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_btn_checkInForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkOut_btn_checkInForm.Location = new System.Drawing.Point(921, 213);
            this.checkOut_btn_checkInForm.Name = "checkOut_btn_checkInForm";
            this.checkOut_btn_checkInForm.Size = new System.Drawing.Size(218, 42);
            this.checkOut_btn_checkInForm.TabIndex = 50;
            this.checkOut_btn_checkInForm.Text = "Check Out";
            this.checkOut_btn_checkInForm.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(631, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 23);
            this.label13.TabIndex = 50;
            this.label13.Text = "Selected Patient to Check Out *";
            // 
            // checkInGridView
            // 
            this.checkInGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkInGridView.Location = new System.Drawing.Point(3, 3);
            this.checkInGridView.Name = "checkInGridView";
            this.checkInGridView.RowHeadersWidth = 51;
            this.checkInGridView.RowTemplate.Height = 24;
            this.checkInGridView.Size = new System.Drawing.Size(1136, 206);
            this.checkInGridView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clear_btn__checkInForm_checkInForm);
            this.panel2.Controls.Add(this.checkIn_btn_checkInForm);
            this.panel2.Controls.Add(this.textCurrentSym);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textReasonForVisit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboVisitType);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textRoomNumber);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.checkInDate_CheckInForm);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textPatientBloodTypeCheckIn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textPatientDoctorCheckIn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textPatientGenderCheckIn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textPatientAgeCheckIn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textPatientNameCheckIn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.searchPatient_btn);
            this.panel2.Controls.Add(this.textPatientIDCheckIn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 366);
            this.panel2.TabIndex = 2;
            // 
            // clear_btn__checkInForm_checkInForm
            // 
            this.clear_btn__checkInForm_checkInForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clear_btn__checkInForm_checkInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn__checkInForm_checkInForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_btn__checkInForm_checkInForm.Location = new System.Drawing.Point(904, 296);
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
            this.checkIn_btn_checkInForm.Location = new System.Drawing.Point(904, 236);
            this.checkIn_btn_checkInForm.Name = "checkIn_btn_checkInForm";
            this.checkIn_btn_checkInForm.Size = new System.Drawing.Size(218, 45);
            this.checkIn_btn_checkInForm.TabIndex = 48;
            this.checkIn_btn_checkInForm.Text = "Check In Patient";
            this.checkIn_btn_checkInForm.UseVisualStyleBackColor = false;
            // 
            // textCurrentSym
            // 
            this.textCurrentSym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCurrentSym.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentSym.Location = new System.Drawing.Point(477, 236);
            this.textCurrentSym.Multiline = true;
            this.textCurrentSym.Name = "textCurrentSym";
            this.textCurrentSym.Size = new System.Drawing.Size(396, 123);
            this.textCurrentSym.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(472, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 27);
            this.label12.TabIndex = 46;
            this.label12.Text = "Current Symptoms";
            // 
            // textReasonForVisit
            // 
            this.textReasonForVisit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textReasonForVisit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReasonForVisit.Location = new System.Drawing.Point(8, 236);
            this.textReasonForVisit.Multiline = true;
            this.textReasonForVisit.Name = "textReasonForVisit";
            this.textReasonForVisit.Size = new System.Drawing.Size(443, 123);
            this.textReasonForVisit.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 27);
            this.label11.TabIndex = 44;
            this.label11.Text = "Reason for Visit *";
            // 
            // comboVisitType
            // 
            this.comboVisitType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVisitType.FormattingEnabled = true;
            this.comboVisitType.Location = new System.Drawing.Point(867, 157);
            this.comboVisitType.Name = "comboVisitType";
            this.comboVisitType.Size = new System.Drawing.Size(255, 35);
            this.comboVisitType.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(866, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 27);
            this.label10.TabIndex = 42;
            this.label10.Text = "Visit Type";
            // 
            // textRoomNumber
            // 
            this.textRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRoomNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoomNumber.Location = new System.Drawing.Point(591, 157);
            this.textRoomNumber.Name = "textRoomNumber";
            this.textRoomNumber.Size = new System.Drawing.Size(240, 33);
            this.textRoomNumber.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 27);
            this.label9.TabIndex = 40;
            this.label9.Text = "Room Number";
            // 
            // checkInDate_CheckInForm
            // 
            this.checkInDate_CheckInForm.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDate_CheckInForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDate_CheckInForm.Location = new System.Drawing.Point(290, 155);
            this.checkInDate_CheckInForm.Name = "checkInDate_CheckInForm";
            this.checkInDate_CheckInForm.Size = new System.Drawing.Size(240, 33);
            this.checkInDate_CheckInForm.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 27);
            this.label8.TabIndex = 38;
            this.label8.Text = "Check-In Date & Time *";
            // 
            // textPatientBloodTypeCheckIn
            // 
            this.textPatientBloodTypeCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientBloodTypeCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientBloodTypeCheckIn.Location = new System.Drawing.Point(977, 72);
            this.textPatientBloodTypeCheckIn.Name = "textPatientBloodTypeCheckIn";
            this.textPatientBloodTypeCheckIn.Size = new System.Drawing.Size(145, 33);
            this.textPatientBloodTypeCheckIn.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(972, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 36;
            this.label7.Text = "Blood Type";
            // 
            // textPatientDoctorCheckIn
            // 
            this.textPatientDoctorCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientDoctorCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientDoctorCheckIn.Location = new System.Drawing.Point(8, 155);
            this.textPatientDoctorCheckIn.Name = "textPatientDoctorCheckIn";
            this.textPatientDoctorCheckIn.Size = new System.Drawing.Size(240, 33);
            this.textPatientDoctorCheckIn.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Assigned Doctor *";
            // 
            // textPatientGenderCheckIn
            // 
            this.textPatientGenderCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientGenderCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientGenderCheckIn.Location = new System.Drawing.Point(796, 72);
            this.textPatientGenderCheckIn.Name = "textPatientGenderCheckIn";
            this.textPatientGenderCheckIn.Size = new System.Drawing.Size(141, 33);
            this.textPatientGenderCheckIn.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(791, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Gender";
            // 
            // textPatientAgeCheckIn
            // 
            this.textPatientAgeCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientAgeCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientAgeCheckIn.Location = new System.Drawing.Point(591, 72);
            this.textPatientAgeCheckIn.Name = "textPatientAgeCheckIn";
            this.textPatientAgeCheckIn.Size = new System.Drawing.Size(150, 33);
            this.textPatientAgeCheckIn.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "Age";
            // 
            // textPatientNameCheckIn
            // 
            this.textPatientNameCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientNameCheckIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientNameCheckIn.Location = new System.Drawing.Point(316, 70);
            this.textPatientNameCheckIn.Name = "textPatientNameCheckIn";
            this.textPatientNameCheckIn.Size = new System.Drawing.Size(240, 33);
            this.textPatientNameCheckIn.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 40);
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
            this.searchPatient_btn.Location = new System.Drawing.Point(176, 64);
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
            this.textPatientIDCheckIn.Size = new System.Drawing.Size(162, 33);
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
        private System.Windows.Forms.TextBox textPatientBloodTypeCheckIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPatientDoctorCheckIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPatientGenderCheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPatientAgeCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textRoomNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textCurrentSym;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textReasonForVisit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboVisitType;
        private System.Windows.Forms.DataGridView checkInGridView;
        private System.Windows.Forms.Button clear_btn__checkInForm_checkInForm;
        private System.Windows.Forms.Button checkIn_btn_checkInForm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button checkOut_btn_checkInForm;
    }
}
