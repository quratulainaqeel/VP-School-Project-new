namespace winSchoolMS
{
    partial class frmExamReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.rdbMid = new System.Windows.Forms.RadioButton();
            this.rdbFinal = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gvExamReport = new System.Windows.Forms.DataGridView();
            this.btngenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvExamReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Exam Type";
            // 
            // rdbMid
            // 
            this.rdbMid.AutoSize = true;
            this.rdbMid.Location = new System.Drawing.Point(326, 180);
            this.rdbMid.Name = "rdbMid";
            this.rdbMid.Size = new System.Drawing.Size(42, 17);
            this.rdbMid.TabIndex = 71;
            this.rdbMid.TabStop = true;
            this.rdbMid.Text = "Mid";
            this.rdbMid.UseVisualStyleBackColor = true;
            // 
            // rdbFinal
            // 
            this.rdbFinal.AutoSize = true;
            this.rdbFinal.Location = new System.Drawing.Point(273, 180);
            this.rdbFinal.Name = "rdbFinal";
            this.rdbFinal.Size = new System.Drawing.Size(47, 17);
            this.rdbFinal.TabIndex = 70;
            this.rdbFinal.TabStop = true;
            this.rdbFinal.Text = "Final";
            this.rdbFinal.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(953, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(579, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Class";
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.Location = new System.Drawing.Point(265, 127);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(164, 20);
            this.txtEnrollmentNo.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(189, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Enrollment No";
            // 
            // gvExamReport
            // 
            this.gvExamReport.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvExamReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExamReport.Location = new System.Drawing.Point(192, 282);
            this.gvExamReport.Name = "gvExamReport";
            this.gvExamReport.Size = new System.Drawing.Size(1004, 325);
            this.gvExamReport.TabIndex = 73;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.ForeColor = System.Drawing.SystemColors.Window;
            this.btngenerate.Location = new System.Drawing.Point(624, 208);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(151, 41);
            this.btngenerate.TabIndex = 74;
            this.btngenerate.Text = "Generate Report";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 65);
            this.panel1.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(618, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam Report";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSection.Location = new System.Drawing.Point(1002, 132);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(172, 21);
            this.cmbSection.TabIndex = 100;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbClass.Location = new System.Drawing.Point(624, 132);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(172, 21);
            this.cmbClass.TabIndex = 99;
            // 
            // frmExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.gvExamReport);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbMid);
            this.Controls.Add(this.rdbFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnrollmentNo);
            this.Controls.Add(this.label6);
            this.Name = "frmExamReport";
            this.Text = "frmExamReport";
            ((System.ComponentModel.ISupportInitialize)(this.gvExamReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbMid;
        private System.Windows.Forms.RadioButton rdbFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvExamReport;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbClass;
    }
}