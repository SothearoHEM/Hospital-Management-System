namespace Hospital_Management_System.Control
{
    partial class PatientManagementControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPatientMedicalNote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textPatientAllergies = new System.Windows.Forms.TextBox();
            this.comboPatientBloodType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textPatientEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.patientDOB = new System.Windows.Forms.DateTimePicker();
            this.comboPatientGender = new System.Windows.Forms.ComboBox();
            this.clearPatient_btn = new System.Windows.Forms.Button();
            this.deletePatient_btn = new System.Windows.Forms.Button();
            this.updatePatient_btn = new System.Windows.Forms.Button();
            this.addPatient_btn = new System.Windows.Forms.Button();
            this.textPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPatientLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPatientAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPatientFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPatientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.patientGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 345);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Management";
            // 
            // patientGridView
            // 
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Location = new System.Drawing.Point(8, 46);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.RowHeadersWidth = 51;
            this.patientGridView.RowTemplate.Height = 24;
            this.patientGridView.Size = new System.Drawing.Size(1168, 296);
            this.patientGridView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textPatientMedicalNote);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textPatientAllergies);
            this.panel2.Controls.Add(this.comboPatientBloodType);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textPatientEmail);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.patientDOB);
            this.panel2.Controls.Add(this.comboPatientGender);
            this.panel2.Controls.Add(this.clearPatient_btn);
            this.panel2.Controls.Add(this.deletePatient_btn);
            this.panel2.Controls.Add(this.updatePatient_btn);
            this.panel2.Controls.Add(this.addPatient_btn);
            this.panel2.Controls.Add(this.textPatientPhoneNumber);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textPatientLastName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textPatientAddress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textPatientFirstName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textPatientID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(8, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 362);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textPatientMedicalNote
            // 
            this.textPatientMedicalNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientMedicalNote.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientMedicalNote.Location = new System.Drawing.Point(603, 188);
            this.textPatientMedicalNote.Multiline = true;
            this.textPatientMedicalNote.Name = "textPatientMedicalNote";
            this.textPatientMedicalNote.Size = new System.Drawing.Size(250, 143);
            this.textPatientMedicalNote.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(598, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 27);
            this.label12.TabIndex = 32;
            this.label12.Text = "Medical History Notes";
            // 
            // textPatientAllergies
            // 
            this.textPatientAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientAllergies.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientAllergies.Location = new System.Drawing.Point(311, 188);
            this.textPatientAllergies.Multiline = true;
            this.textPatientAllergies.Name = "textPatientAllergies";
            this.textPatientAllergies.Size = new System.Drawing.Size(250, 143);
            this.textPatientAllergies.TabIndex = 31;
            // 
            // comboPatientBloodType
            // 
            this.comboPatientBloodType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPatientBloodType.FormattingEnabled = true;
            this.comboPatientBloodType.Location = new System.Drawing.Point(603, 116);
            this.comboPatientBloodType.Name = "comboPatientBloodType";
            this.comboPatientBloodType.Size = new System.Drawing.Size(250, 35);
            this.comboPatientBloodType.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(598, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 27);
            this.label11.TabIndex = 29;
            this.label11.Text = "Blood Type";
            // 
            // textPatientEmail
            // 
            this.textPatientEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientEmail.Location = new System.Drawing.Point(883, 116);
            this.textPatientEmail.Name = "textPatientEmail";
            this.textPatientEmail.Size = new System.Drawing.Size(250, 33);
            this.textPatientEmail.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(878, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 27);
            this.label10.TabIndex = 27;
            this.label10.Text = "Email Address";
            // 
            // patientDOB
            // 
            this.patientDOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDOB.Location = new System.Drawing.Point(883, 41);
            this.patientDOB.Name = "patientDOB";
            this.patientDOB.Size = new System.Drawing.Size(250, 33);
            this.patientDOB.TabIndex = 26;
            // 
            // comboPatientGender
            // 
            this.comboPatientGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPatientGender.FormattingEnabled = true;
            this.comboPatientGender.Location = new System.Drawing.Point(24, 114);
            this.comboPatientGender.Name = "comboPatientGender";
            this.comboPatientGender.Size = new System.Drawing.Size(250, 35);
            this.comboPatientGender.TabIndex = 25;
            // 
            // clearPatient_btn
            // 
            this.clearPatient_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearPatient_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPatient_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearPatient_btn.Location = new System.Drawing.Point(936, 245);
            this.clearPatient_btn.Name = "clearPatient_btn";
            this.clearPatient_btn.Size = new System.Drawing.Size(197, 40);
            this.clearPatient_btn.TabIndex = 24;
            this.clearPatient_btn.Text = "Clear";
            this.clearPatient_btn.UseVisualStyleBackColor = false;
            // 
            // deletePatient_btn
            // 
            this.deletePatient_btn.BackColor = System.Drawing.Color.IndianRed;
            this.deletePatient_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatient_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletePatient_btn.Location = new System.Drawing.Point(936, 291);
            this.deletePatient_btn.Name = "deletePatient_btn";
            this.deletePatient_btn.Size = new System.Drawing.Size(197, 40);
            this.deletePatient_btn.TabIndex = 23;
            this.deletePatient_btn.Text = "Delete";
            this.deletePatient_btn.UseVisualStyleBackColor = false;
            // 
            // updatePatient_btn
            // 
            this.updatePatient_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.updatePatient_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatient_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updatePatient_btn.Location = new System.Drawing.Point(936, 199);
            this.updatePatient_btn.Name = "updatePatient_btn";
            this.updatePatient_btn.Size = new System.Drawing.Size(197, 40);
            this.updatePatient_btn.TabIndex = 22;
            this.updatePatient_btn.Text = "Update";
            this.updatePatient_btn.UseVisualStyleBackColor = false;
            // 
            // addPatient_btn
            // 
            this.addPatient_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addPatient_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatient_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addPatient_btn.Location = new System.Drawing.Point(936, 155);
            this.addPatient_btn.Name = "addPatient_btn";
            this.addPatient_btn.Size = new System.Drawing.Size(197, 40);
            this.addPatient_btn.TabIndex = 21;
            this.addPatient_btn.Text = "Add Patient";
            this.addPatient_btn.UseVisualStyleBackColor = false;
            // 
            // textPatientPhoneNumber
            // 
            this.textPatientPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientPhoneNumber.Location = new System.Drawing.Point(311, 116);
            this.textPatientPhoneNumber.Name = "textPatientPhoneNumber";
            this.textPatientPhoneNumber.Size = new System.Drawing.Size(250, 33);
            this.textPatientPhoneNumber.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Known Allergies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender *";
            // 
            // textPatientLastName
            // 
            this.textPatientLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientLastName.Location = new System.Drawing.Point(603, 43);
            this.textPatientLastName.Name = "textPatientLastName";
            this.textPatientLastName.Size = new System.Drawing.Size(250, 33);
            this.textPatientLastName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name *";
            // 
            // textPatientAddress
            // 
            this.textPatientAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientAddress.Location = new System.Drawing.Point(24, 188);
            this.textPatientAddress.Multiline = true;
            this.textPatientAddress.Name = "textPatientAddress";
            this.textPatientAddress.Size = new System.Drawing.Size(250, 143);
            this.textPatientAddress.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // textPatientFirstName
            // 
            this.textPatientFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientFirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientFirstName.Location = new System.Drawing.Point(311, 41);
            this.textPatientFirstName.Name = "textPatientFirstName";
            this.textPatientFirstName.Size = new System.Drawing.Size(250, 33);
            this.textPatientFirstName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "First Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(878, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth *";
            // 
            // textPatientID
            // 
            this.textPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPatientID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPatientID.Location = new System.Drawing.Point(24, 41);
            this.textPatientID.Name = "textPatientID";
            this.textPatientID.Size = new System.Drawing.Size(250, 33);
            this.textPatientID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient ID *";
            // 
            // PatientManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientManagementControl";
            this.Size = new System.Drawing.Size(1190, 716);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearPatient_btn;
        private System.Windows.Forms.Button deletePatient_btn;
        private System.Windows.Forms.Button updatePatient_btn;
        private System.Windows.Forms.Button addPatient_btn;
        private System.Windows.Forms.TextBox textPatientPhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPatientLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPatientAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPatientFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPatientGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPatientMedicalNote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textPatientAllergies;
        private System.Windows.Forms.ComboBox comboPatientBloodType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPatientEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker patientDOB;
    }
}
