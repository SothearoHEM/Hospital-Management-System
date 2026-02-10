namespace Hospital_Management_System.Control
{
    partial class DashhboradControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardTotalDoctorsLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashboardTotalPatientsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dashboardVisitsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 262);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboardGridView);
            this.panel2.Location = new System.Drawing.Point(8, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 418);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.dashboardTotalDoctorsLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(60, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 140);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Doctors";
            // 
            // dashboardTotalDoctorsLabel
            // 
            this.dashboardTotalDoctorsLabel.AutoSize = true;
            this.dashboardTotalDoctorsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTotalDoctorsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboardTotalDoctorsLabel.Location = new System.Drawing.Point(12, 83);
            this.dashboardTotalDoctorsLabel.Name = "dashboardTotalDoctorsLabel";
            this.dashboardTotalDoctorsLabel.Size = new System.Drawing.Size(51, 37);
            this.dashboardTotalDoctorsLabel.TabIndex = 1;
            this.dashboardTotalDoctorsLabel.Text = "20";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.dashboardTotalPatientsLabel);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(445, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 140);
            this.panel4.TabIndex = 3;
            // 
            // dashboardTotalPatientsLabel
            // 
            this.dashboardTotalPatientsLabel.AutoSize = true;
            this.dashboardTotalPatientsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTotalPatientsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboardTotalPatientsLabel.Location = new System.Drawing.Point(12, 83);
            this.dashboardTotalPatientsLabel.Name = "dashboardTotalPatientsLabel";
            this.dashboardTotalPatientsLabel.Size = new System.Drawing.Size(51, 37);
            this.dashboardTotalPatientsLabel.TabIndex = 1;
            this.dashboardTotalPatientsLabel.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Patients";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.dashboardVisitsLabel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(829, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 140);
            this.panel5.TabIndex = 3;
            // 
            // dashboardVisitsLabel
            // 
            this.dashboardVisitsLabel.AutoSize = true;
            this.dashboardVisitsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardVisitsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboardVisitsLabel.Location = new System.Drawing.Point(12, 83);
            this.dashboardVisitsLabel.Name = "dashboardVisitsLabel";
            this.dashboardVisitsLabel.Size = new System.Drawing.Size(51, 37);
            this.dashboardVisitsLabel.TabIndex = 1;
            this.dashboardVisitsLabel.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Active Visits";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::Hospital_Management_System.Properties.Resources.empathy_2612496;
            this.pictureBox3.Location = new System.Drawing.Point(197, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::Hospital_Management_System.Properties.Resources.clinic_15234431;
            this.pictureBox2.Location = new System.Drawing.Point(197, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources.doctor_2785482;
            this.pictureBox1.Location = new System.Drawing.Point(197, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardGridView
            // 
            this.dashboardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashboardGridView.Location = new System.Drawing.Point(3, 3);
            this.dashboardGridView.Name = "dashboardGridView";
            this.dashboardGridView.RowHeadersWidth = 51;
            this.dashboardGridView.RowTemplate.Height = 24;
            this.dashboardGridView.Size = new System.Drawing.Size(1164, 412);
            this.dashboardGridView.TabIndex = 0;
            // 
            // DashhboradControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashhboradControl";
            this.Size = new System.Drawing.Size(1190, 716);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dashboardTotalDoctorsLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label dashboardVisitsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label dashboardTotalPatientsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dashboardGridView;
    }
}
