namespace winSchoolMS
{
    partial class frmFeePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeePayment));
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gvFeesPayment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExaminationFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLabFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMonthlyfee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFullName = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvFeesPayment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(631, 334);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(165, 20);
            this.txtTotalAmount.TabIndex = 64;
            this.txtTotalAmount.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(527, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 16);
            this.label14.TabIndex = 63;
            this.label14.Text = "Total Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(559, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(615, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 31);
            this.label11.TabIndex = 60;
            this.label11.Text = "Fees Payment";
            // 
            // gvFeesPayment
            // 
            this.gvFeesPayment.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvFeesPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFeesPayment.Location = new System.Drawing.Point(48, 455);
            this.gvFeesPayment.Name = "gvFeesPayment";
            this.gvFeesPayment.Size = new System.Drawing.Size(1286, 209);
            this.gvFeesPayment.TabIndex = 59;
            this.gvFeesPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFeesPayment_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(980, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Time";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(200, 286);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(165, 20);
            this.txtFine.TabIndex = 51;
            this.txtFine.Text = "0";
            this.txtFine.TextChanged += new System.EventHandler(this.txtFine_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(116, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Fine";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(1051, 233);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(165, 20);
            this.txtDiscount.TabIndex = 49;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(980, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(980, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Class";
            // 
            // txtExaminationFee
            // 
            this.txtExaminationFee.Location = new System.Drawing.Point(202, 233);
            this.txtExaminationFee.Name = "txtExaminationFee";
            this.txtExaminationFee.Size = new System.Drawing.Size(165, 20);
            this.txtExaminationFee.TabIndex = 45;
            this.txtExaminationFee.Text = "0";
            this.txtExaminationFee.TextChanged += new System.EventHandler(this.txtExaminationFee_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(116, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Examination fee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(559, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "FullName";
            // 
            // txtLabFee
            // 
            this.txtLabFee.Location = new System.Drawing.Point(631, 233);
            this.txtLabFee.Name = "txtLabFee";
            this.txtLabFee.Size = new System.Drawing.Size(165, 20);
            this.txtLabFee.TabIndex = 41;
            this.txtLabFee.Text = "0";
            this.txtLabFee.TextChanged += new System.EventHandler(this.txtLabFee_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(560, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Lab fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(14, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(116, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Enrollment No";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(451, 390);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 41);
            this.btnInsert.TabIndex = 65;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(680, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 41);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(906, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo.Location = new System.Drawing.Point(202, 128);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(165, 20);
            this.txtEnrollmentNo.TabIndex = 68;
            this.txtEnrollmentNo.TextChanged += new System.EventHandler(this.txtEnrollmentNo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(-5, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 65);
            this.panel1.TabIndex = 71;
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
            this.cmbClass.Location = new System.Drawing.Point(1051, 125);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(165, 21);
            this.cmbClass.TabIndex = 72;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(631, 286);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(165, 20);
            this.dtpDate.TabIndex = 73;
            // 
            // txtMonthlyfee
            // 
            this.txtMonthlyfee.Location = new System.Drawing.Point(1051, 179);
            this.txtMonthlyfee.Name = "txtMonthlyfee";
            this.txtMonthlyfee.Size = new System.Drawing.Size(165, 20);
            this.txtMonthlyfee.TabIndex = 78;
            this.txtMonthlyfee.Text = "0";
            this.txtMonthlyfee.TextChanged += new System.EventHandler(this.txtMonthlyfee_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(980, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Monthly fee";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "Augest",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(631, 178);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(165, 21);
            this.cmbMonth.TabIndex = 80;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.SystemColors.Window;
            this.Label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label.Location = new System.Drawing.Point(560, 181);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(37, 13);
            this.Label.TabIndex = 79;
            this.Label.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(1222, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "%";
            // 
            // cmbFullName
            // 
            this.cmbFullName.FormattingEnabled = true;
            this.cmbFullName.Location = new System.Drawing.Point(631, 127);
            this.cmbFullName.Name = "cmbFullName";
            this.cmbFullName.Size = new System.Drawing.Size(165, 21);
            this.cmbFullName.TabIndex = 82;
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSection.Location = new System.Drawing.Point(202, 178);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(163, 21);
            this.cmbSection.TabIndex = 84;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(116, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 83;
            this.label15.Text = "Section";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(1051, 288);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(165, 20);
            this.dtpTime.TabIndex = 85;
            // 
            // frmFeePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.txtMonthlyfee);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtEnrollmentNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gvFeesPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExaminationFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLabFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFeePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fees Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFeePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvFeesPayment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gvFeesPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExaminationFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLabFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEnrollmentNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtMonthlyfee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFullName;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}