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
        string examid;
        public frmExamination()
        {
            InitializeComponent();
        }
        private void frmExamination_Load(object sender, EventArgs e)
        {
            string QRY = "Select * from tblExamination";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvExamination.DataSource = dt;
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
                txtPercentage.Text = percentage.ToString("0.00") + " %";
                if (percentage >= 80)
                {
                    Grade = "A-1";
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

      

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            string QRY = "Select * from tblCourses where Class = @class";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            da.SelectCommand.Parameters.AddWithValue("@class", txtClass.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbSubject.DataSource = dt;
            cmbSubject.ValueMember = "ID";
            cmbSubject.DisplayMember = "Course";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string type = string.Empty;
            if (rdbFinal.Checked)
            {
                type = "Final";
            }
            if (rdbMid.Checked)
            {
                type = "Mid";
            }

            string QRY = "Insert into tblExamination (EnrollmentNo, FullName, Class, Section, Subject, ExamType, TotalMarks, ObtainedMarks, Percentage, Grade, Result, EvaluatedBy) Values('" + txtEnrollmentNo.Text + "','" + txtFullName.Text + "','" + txtClass.Text + "','" + txtSection.Text + "','" + cmbSubject.Text + "','" + type + "','" + txtTotalMarks.Text + "','" + txtObtainedMarks.Text + "','" + txtPercentage.Text + "','" + txtGrade.Text + "','" + txtResult.Text + "','" +txtEvaluated.Text + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtEnrollmentNo.Text = "";
            txtFullName.Text = "";
            txtClass.Text = "";
            txtSection.Text = "";
            cmbSubject.Text = "";
            txtTotalMarks.Text = "";
            txtObtainedMarks.Text = "";
            txtPercentage.Text = "";
            txtGrade.Text = "";
            txtResult.Text = "";
            txtEvaluated.Text = "";
            rdbFinal.Checked = false;
            rdbMid.Checked = false;


            SqlDataAdapter da = new SqlDataAdapter("Select * from tblExamination order by ExamID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvExamination.DataSource = dt;

            MessageBox.Show("Data Inserted Sucessfully");
        }

        private void gvExamination_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            examid = gvExamination.Rows[e.RowIndex].Cells[0].Value.ToString();
            string enrollmentNo = gvExamination.Rows[e.RowIndex].Cells[1].Value.ToString();
            string fullname = gvExamination.Rows[e.RowIndex].Cells[2].Value.ToString();
            string stdclass = gvExamination.Rows[e.RowIndex].Cells[3].Value.ToString();
            string section = gvExamination.Rows[e.RowIndex].Cells[4].Value.ToString();
            string subject = gvExamination.Rows[e.RowIndex].Cells[5].Value.ToString();
            string type = gvExamination.Rows[e.RowIndex].Cells[6].Value.ToString().ToLower();
            string totmarks = gvExamination.Rows[e.RowIndex].Cells[7].Value.ToString();
            string obtmarks = gvExamination.Rows[e.RowIndex].Cells[8].Value.ToString();
            string perc = gvExamination.Rows[e.RowIndex].Cells[9].Value.ToString();
            string grade = gvExamination.Rows[e.RowIndex].Cells[10].Value.ToString();
            string result = gvExamination.Rows[e.RowIndex].Cells[11].Value.ToString();
            string evaluatedby = gvExamination.Rows[e.RowIndex].Cells[12].Value.ToString();

            if (type == "mid")
            {
                rdbMid.Checked = true;
                rdbFinal.Checked = false;
            }
            else if (type == "final")
            {
                rdbFinal.Checked = true;
                rdbMid.Checked = false;
            }
            else
            {
                MessageBox.Show("not defined");
            }

            txtEnrollmentNo.Text = enrollmentNo;
            txtFullName.Text = fullname;
            txtClass.Text = stdclass;
            txtSection.Text = section;
            cmbSubject.Text = subject;
            txtTotalMarks.Text = totmarks;
            txtObtainedMarks.Text = obtmarks;
            txtPercentage.Text = perc;
            txtGrade.Text = grade;
            txtResult.Text = result;
            txtEvaluated.Text = evaluatedby;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string type = string.Empty;
            if (rdbFinal.Checked)
            {
                type = "Final";
            }
            if (rdbMid.Checked)
            {
                type = "Mid";
            }

            string QRY = "Update tblExamination set EnrollmentNo = '" + txtEnrollmentNo.Text + "',FullName = '" + txtFullName.Text + "', Class = '" + txtClass.Text + "', Section = '" + txtSection.Text + "', Subject = '" + cmbSubject.Text + "',  ExamType = '" + type + "', TotalMarks = '" + txtTotalMarks.Text + "', ObtainedMarks = '" + txtObtainedMarks.Text + "', Percentage = '" + txtPercentage.Text + "', Grade = '" + txtGrade.Text + "', Result = '" + txtResult.Text + "', EvaluatedBy = '" + txtEvaluated.Text + "' where ExamID = " + examid;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtEnrollmentNo.Text = "";
            txtFullName.Text = "";
            txtClass.Text = "";
            txtSection.Text = "";
            cmbSubject.Text = "";
            txtTotalMarks.Text = "";
            txtObtainedMarks.Text = "";
            txtPercentage.Text = "";
            txtGrade.Text = "";
            txtResult.Text = "";
            txtEvaluated.Text = "";
            rdbFinal.Checked = false;
            rdbMid.Checked = false;

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblExamination order by EnrollmentNo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvExamination.DataSource = dt;

            MessageBox.Show("Data Updated Sucessfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string QRY = "Delete from tblExamination  where ExamID = " + examid;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            txtEnrollmentNo.Text = "";
            txtFullName.Text = "";
            txtClass.Text = "";
            txtSection.Text = "";
            cmbSubject.Text = "";
            txtTotalMarks.Text = "";
            txtObtainedMarks.Text = "";
            txtPercentage.Text = "";
            txtGrade.Text = "";
            txtResult.Text = "";
            txtEvaluated.Text = "";
            rdbFinal.Checked = false;
            rdbMid.Checked = false;

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblExamination order by EnrollmentNo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvExamination.DataSource = dt;

            MessageBox.Show("Data Deleted Sucessfully");
        }
    }
    }

