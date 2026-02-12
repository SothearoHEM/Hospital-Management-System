namespace Hospital_Management_System.Control
{
    partial class PatientCheckInOutControl
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
            this.checkIn_btn = new System.Windows.Forms.Button();
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkInControl1 = new Hospital_Management_System.Control.CheckInControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkIn_btn);
            this.panel1.Controls.Add(this.checkOut_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 47);
            this.panel1.TabIndex = 0;
            // 
            // checkIn_btn
            // 
            this.checkIn_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkIn_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkIn_btn.Location = new System.Drawing.Point(755, 3);
            this.checkIn_btn.Name = "checkIn_btn";
            this.checkIn_btn.Size = new System.Drawing.Size(197, 40);
            this.checkIn_btn.TabIndex = 26;
            this.checkIn_btn.Text = "Check In";
            this.checkIn_btn.UseVisualStyleBackColor = false;
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.checkOut_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkOut_btn.Location = new System.Drawing.Point(958, 3);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Size = new System.Drawing.Size(197, 40);
            this.checkOut_btn.TabIndex = 25;
            this.checkOut_btn.Text = "Check Out";
            this.checkOut_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient Check In / Out";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkInControl1);
            this.panel2.Location = new System.Drawing.Point(9, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 644);
            this.panel2.TabIndex = 1;
            // 
            // checkInControl1
            // 
            this.checkInControl1.Location = new System.Drawing.Point(4, 5);
            this.checkInControl1.Name = "checkInControl1";
            this.checkInControl1.Size = new System.Drawing.Size(1165, 640);
            this.checkInControl1.TabIndex = 0;
            // 
            // PatientCheckInOutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientCheckInOutControl";
            this.Size = new System.Drawing.Size(1190, 716);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkIn_btn;
        private System.Windows.Forms.Button checkOut_btn;
        private CheckInControl checkInControl1;
    }
}
