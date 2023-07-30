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

namespace winproject
{
    public partial class frmStudentAttendance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        string AttendanceId;
        public frmStudentAttendance()
        {
            InitializeComponent();
        }
        private void frmStudentAttendance_Load(object sender, EventArgs e)
        {

            cmbClass.SelectedIndex = 0;

            string QRY = "Select * from tblStudentAttendane";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendance.DataSource = dt;

            txtfullname.Enabled = false;
            cmbSection.Enabled = false;

        }
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string QRY = "Select * from tblStudentEducationalDetails where Class = @class";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            da.SelectCommand.Parameters.AddWithValue("@class", cmbClass.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbEnrollmentNo.DataSource = dt;
            cmbEnrollmentNo.ValueMember = "AdmissionId";
            cmbEnrollmentNo.DisplayMember = "EnrollmentNo";

            DataRow dr = dt.NewRow();
            dr["AdmissionID"] = -1;
            dr["EnrollmentNo"] = "Select";
            dt.Rows.InsertAt(dr, 0);
            cmbEnrollmentNo.SelectedIndex = 0;
            cmbSection.Text = "";

            txtfullname.Enabled = false;
            cmbSection.Enabled = false;

        }

        private void cmbEnrollmentNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string QRY = "SELECT * FROM tblStudentEducationalDetails WHERE EnrollmentNo = @EnrollmentNo";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);

            // Add the parameter to the SqlDataAdapter
            da.SelectCommand.Parameters.AddWithValue("@EnrollmentNo", cmbEnrollmentNo.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                txtfullname.Text = dt.Rows[0]["FullName"].ToString();
                cmbSection.Text = dt.Rows[0]["Section"].ToString();
               ;
            }
            else
            {
                txtfullname.Text = string.Empty;
                txtfullname.Text = string.Empty;
            }

            txtfullname.Enabled = false;
            cmbSection.Enabled = false;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string AttendanceStatus = string.Empty;
            if (rdbPresent.Checked)
            {
                AttendanceStatus = "Present";
            }
            if (rdbAbsent.Checked)
            {
                AttendanceStatus = "Absent";
            }
            if (rdbLeave.Checked)
            {
                AttendanceStatus = "Leave";
            }
            
            string QRY = "Insert into tblStudentAttendane (EnrollmentNo, FullName, Class, Section, Month, Date, Time, AttendanceStatus) Values('" + cmbEnrollmentNo.Text + "','" + txtfullname.Text + "','" + cmbClass.Text + "','" + cmbSection.Text + "','" + cmbSection.Text + "','" + dtpDate.Text + "','" + dtpTime.Text + "','" + AttendanceStatus + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

           // cmbEnrollmentNo.SelectedIndex = 0;            
            cmbClass.SelectedIndex = 0;
            cmbSection.Text = "";
            txtfullname.Text = "";
            cmbSection.Text = "";

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentAttendane order by EnrollmentNo desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendance.DataSource = dt;

            txtfullname.Enabled = false;
            cmbSection.Enabled = false;
                      

            MessageBox.Show("Data Inserted Sucessfully");
        }

        private void gvStudentAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AttendanceId = gvStudentAttendance.Rows[e.RowIndex].Cells[0].Value.ToString();
            string enrollmentNo = gvStudentAttendance.Rows[e.RowIndex].Cells[1].Value.ToString();
            string FullName = gvStudentAttendance.Rows[e.RowIndex].Cells[2].Value.ToString();
            string stdclass =  gvStudentAttendance.Rows[e.RowIndex].Cells[3].Value.ToString();
            string section = gvStudentAttendance.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Month = gvStudentAttendance.Rows[e.RowIndex].Cells[5].Value.ToString();
            string date = gvStudentAttendance.Rows[e.RowIndex].Cells[6].Value.ToString();
            string time = gvStudentAttendance.Rows[e.RowIndex].Cells[7].Value.ToString();
            string status = gvStudentAttendance.Rows[e.RowIndex].Cells[8].Value.ToString().Trim().ToLower();


            cmbEnrollmentNo.Text = enrollmentNo;
            txtfullname.Text = FullName;
            cmbClass.Text = stdclass;
            cmbSection.Text = section;
            cmbMonth.Text = Month;
            dtpDate.Text = date;
            dtpTime.Text = time;

            if (status == "present")
            {
                rdbPresent.Checked = true;
                rdbAbsent.Checked = false;
                rdbLeave.Checked = false;
            }
            else if (status == "absent")
            {
                rdbPresent.Checked = false;
                rdbAbsent.Checked = true;
                rdbLeave.Checked = false;
            }
            else if (status == "leave")
            {
                rdbPresent.Checked = false;
                rdbAbsent.Checked = false;
                rdbLeave.Checked = true;
            }
            else
            {
                MessageBox.Show("not defined");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = string.Empty;
            if (rdbPresent.Checked)
            {
                status = "Present";
            }
            if (rdbAbsent.Checked)
            {
                status = "Absent";
            }
            if (rdbLeave.Checked)
            {
                status = "Leave";
            }

            string QRY = "Update tblStudentAttendane Set Date = '" + dtpDate.Text + "',Time = '" + dtpTime.Text + "' ,Month = '" + cmbMonth.Text + "',AttendanceStatus = '" + status + "' where AttendanceID = " + AttendanceId;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
                       
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentAttendane order by Class", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendance.DataSource = dt;

            cmbClass.SelectedIndex = 0;
            cmbSection.Text = "";
            txtfullname.Text = "";
            cmbSection.Text = "";

            txtfullname.Enabled = false;
            cmbSection.Enabled = false;


            MessageBox.Show("Data Updated Sucessfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string QRY = "Delete from tblStudentAttendane where AttendanceID =" + AttendanceId;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentAttendane order by Class", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendance.DataSource = dt;

            cmbClass.SelectedIndex = 0;
            cmbSection.Text = "";
            txtfullname.Text = "";
            cmbSection.Text = "";

            txtfullname.Enabled = false;
            cmbSection.Enabled = false;
            MessageBox.Show("Data Deleted Sucessfully");
        }
    }
}