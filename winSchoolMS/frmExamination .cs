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
    public partial class frmExamination : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        double percentage;
        string Grade;
        string Result;
        public frmExamination()
        {
            InitializeComponent();
        }

        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            string QRY = "SELECT * FROM tblStudentEducationalDetails WHERE EnrollmentNo = @EnrollmentNo";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);

            // Add the parameter to the SqlDataAdapter
            da.SelectCommand.Parameters.AddWithValue("@EnrollmentNo", txtEnrollmentNo.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            txtFullName.Enabled = false;
            txtClass.Enabled = false;
            txtSection.Enabled = false;

            if (dt.Rows.Count > 0)
            {
                txtFullName.Text = dt.Rows[0]["FullName"].ToString();
                txtClass.Text = dt.Rows[0]["Class"].ToString();
                txtSection.Text = dt.Rows[0]["Section"].ToString();
            }
            else
            {
                txtFullName.Text = string.Empty;
                txtClass.Text = string.Empty;
                txtSection.Text = string.Empty;
            }
        }

        private void txtObtainedMarks_TextChanged(object sender, EventArgs e)
        {
            if (txtObtainedMarks.Text != "")
            {
                percentage = Convert.ToInt32(txtObtainedMarks.Text) * 100;

                percentage = percentage / Convert.ToInt32(txtTotalMarks.Text);
                txtPercentage.Text = percentage.ToString(("0.00")) + " %";
                if (percentage >= 80)
                {
                    Grade = "A1";
                    Result = "Pass";

                }
                else if (percentage >= 70)
                {
                    Grade = "A";
                    Result = "Pass";
                }
                else if (percentage >= 60)
                {
                    Grade = "B";
                    Result = "Pass";
                }
                else if (percentage >= 50)
                {
                    Grade = "C";
                    Result = "Pass";
                }
                else if (percentage >= 40)
                {
                    Grade = "D";
                    Result = "Pass";
                }
                else
                {
                    Grade = "F";
                    Result = "fail";
                }
                txtGrade.Text = Grade;
                txtResult.Text = Result;
            }

        }
    }
    }

