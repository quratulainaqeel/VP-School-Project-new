using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winSchoolMS
{
    public partial class frmFeePayment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        double discount = 0;
        string paymentid;
        public frmFeePayment()
        {
            InitializeComponent();
        }

        private void frmFeePayment_Load(object sender, EventArgs e)
        {
            string QRY = "Select * from tblStudentFeePayment";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeesPayment.DataSource = dt;

            string FullNameQRY = "SELECT * FROM tblStudentEducationalDetails";
            SqlDataAdapter FullNameda = new SqlDataAdapter(FullNameQRY, con);
            DataTable FullNamedt = new DataTable();
            FullNameda.Fill(FullNamedt);

            cmbFullName.DataSource = FullNamedt;
            cmbFullName.ValueMember = "AdmissionID";
            cmbFullName.DisplayMember = "FullName"; 

            // Create new row
            DataRow dr = FullNamedt.NewRow();
            dr["AdmissionID"] = -1; 
            dr["FullName"] = "Select Name"; 
            FullNamedt.Rows.InsertAt(dr, 0);
            cmbFullName.SelectedIndex = 0;

        }


        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            string QRY = "SELECT * FROM tblStudentEducationalDetails WHERE EnrollmentNo = @EnrollmentNo";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);

            // Add the parameter to the SqlDataAdapter
            da.SelectCommand.Parameters.AddWithValue("@EnrollmentNo", txtEnrollmentNo.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbFullName.Text = dt.Rows[0]["FullName"].ToString();
                cmbClass.Text = dt.Rows[0]["Class"].ToString();
                cmbSection.Text = dt.Rows[0]["Section"].ToString();
            }
            else
            {
                cmbFullName.Text = string.Empty;
                cmbClass.Text = string.Empty;
                cmbSection.Text = string.Empty;
            }
        }

        private void txtMonthlyfee_TextChanged(object sender, EventArgs e)
        {
            if (txtMonthlyfee.Text != "")
            {
                txtTotalAmount.Text = Convert.ToString(txtMonthlyfee.Text);
            }
        }

        private void txtExaminationFee_TextChanged(object sender, EventArgs e)
        {
            if (txtExaminationFee.Text != "")
            {
                txtTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtMonthlyfee.Text) + Convert.ToInt32(txtExaminationFee.Text));
            }
        }

        private void txtLabFee_TextChanged(object sender, EventArgs e)
        {
            if (txtLabFee.Text != "")
            {
                txtTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtMonthlyfee.Text) + Convert.ToInt32(txtLabFee.Text) + Convert.ToInt32(txtExaminationFee.Text));
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "")
            {
                discount = Convert.ToInt32(txtMonthlyfee.Text) * ((double)Convert.ToInt32(txtDiscount.Text) / 100);

                txtTotalAmount.Text = Convert.ToString(Convert.ToInt32(txtMonthlyfee.Text) + Convert.ToInt32(txtLabFee.Text) + Convert.ToInt32(txtExaminationFee.Text) - discount);
            }
        }

        private void txtFine_TextChanged(object sender, EventArgs e)
        {
            if (txtFine.Text != "")
            {
                txtTotalAmount.Text = Convert.ToString((Convert.ToInt32(txtMonthlyfee.Text) + Convert.ToInt32(txtLabFee.Text) + Convert.ToInt32(txtExaminationFee.Text) - discount) + Convert.ToInt32(txtFine.Text));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string QRY = "Insert into tblStudentFeePayment (EnrollmentNo, FullName, Class, Section, Month, MonthlyFee, ExaminationFee, LabFee, Discount, Fine, Date, Time, TotalAmount) Values('" + txtEnrollmentNo.Text + "','" + cmbFullName.Text + "','" + cmbClass.Text + "','" + cmbSection.Text + "','" + cmbMonth.Text + "','" + txtMonthlyfee.Text + "','" + txtExaminationFee.Text + "','" + txtLabFee.Text + "','" + txtDiscount.Text + "','" + txtFine.Text + "','" + dtpDate.Text + "','" + dtpTime.Text + "','" + txtTotalAmount.Text + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtEnrollmentNo.Text = "";
            cmbFullName.Text = "Select Name";
            cmbClass.Text = "";
            cmbSection.Text = "";
            cmbMonth.Text = "";
            txtMonthlyfee.Text = "";
            txtMonthlyfee.Text = "";
            txtExaminationFee.Text = "";
            txtLabFee.Text = "";
            txtDiscount.Text = "";
            txtFine.Text = "";
            txtTotalAmount.Text = "";

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentFeePayment order by EnrollmentNo desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeesPayment.DataSource = dt;

            MessageBox.Show("Data Inserted Sucessfully");


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string QRY = "Update tblStudentFeePayment Set Month = '" + cmbMonth.Text + "', MonthlyFee = '" + txtMonthlyfee.Text + "', ExaminationFee = '" + txtExaminationFee.Text + "', LabFee = '" + txtLabFee.Text + "', Discount = '" + txtDiscount.Text + "', Fine = '" + txtFine.Text + "', Date = '" + dtpDate.Text + "', Time = '" + dtpTime.Text + "', TotalAmount = '" + txtTotalAmount.Text + "' where PaymentID = " + paymentid;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtEnrollmentNo.Text = "";
            cmbFullName.Text = "Select Name";
            cmbClass.Text = "";
            cmbSection.Text = "";
            cmbMonth.Text = "";
            txtMonthlyfee.Text = "";
            txtMonthlyfee.Text = "";
            txtExaminationFee.Text = "";
            txtLabFee.Text = "";
            txtDiscount.Text = "";
            txtFine.Text = "";
            txtTotalAmount.Text = "";
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Now;



            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentFeePayment order by EnrollmentNo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeesPayment.DataSource = dt;

            MessageBox.Show("Data Updated Sucessfully");
        }

        private void gvFeesPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            paymentid = gvFeesPayment.Rows[e.RowIndex].Cells[0].Value.ToString();
            string enrollmentno = gvFeesPayment.Rows[e.RowIndex].Cells[1].Value.ToString();
            string fullname = gvFeesPayment.Rows[e.RowIndex].Cells[2].Value.ToString();
            string stdclass = gvFeesPayment.Rows[e.RowIndex].Cells[3].Value.ToString();
            string section = gvFeesPayment.Rows[e.RowIndex].Cells[4].Value.ToString();
            string month = gvFeesPayment.Rows[e.RowIndex].Cells[5].Value.ToString();
            string monthlyfee = gvFeesPayment.Rows[e.RowIndex].Cells[6].Value.ToString();
            string examinationfee = gvFeesPayment.Rows[e.RowIndex].Cells[7].Value.ToString();
            string labfee = gvFeesPayment.Rows[e.RowIndex].Cells[8].Value.ToString();
            string discount = gvFeesPayment.Rows[e.RowIndex].Cells[9].Value.ToString();
            string fine = gvFeesPayment.Rows[e.RowIndex].Cells[10].Value.ToString();
            string date = gvFeesPayment.Rows[e.RowIndex].Cells[11].Value.ToString();
            string time = gvFeesPayment.Rows[e.RowIndex].Cells[12].Value.ToString();
            string totalamount = gvFeesPayment.Rows[e.RowIndex].Cells[13].Value.ToString();

            txtEnrollmentNo.Text = enrollmentno;
            cmbFullName.Text = fullname;
            cmbClass.Text = stdclass;
            cmbSection.Text = section;
            cmbMonth.Text = month;
            txtMonthlyfee.Text = monthlyfee;
            txtExaminationFee.Text = examinationfee;
            txtLabFee.Text = labfee;
            txtDiscount.Text = discount;
            txtFine.Text = fine;
            dtpDate.Text = date;
            dtpTime.Text = time;
            txtTotalAmount.Text = totalamount;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string QRY = "Delete from tblStudentFeePayment where PaymentID =" + paymentid;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentFeePayment order by EnrollmentNo desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeesPayment.DataSource = dt;

            txtEnrollmentNo.Text = "";
            cmbFullName.Text = "Select Name";
            cmbClass.Text = "";
            cmbSection.Text = "";
            cmbMonth.Text = "";
            txtMonthlyfee.Text = "";
            txtMonthlyfee.Text = "";
            txtExaminationFee.Text = "";
            txtLabFee.Text = "";
            txtDiscount.Text = "";
            txtFine.Text = "";
            txtTotalAmount.Text = "";
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Now;

            MessageBox.Show("Data Deleted Sucessfully");
        }
    }
}
