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

        public frmStudentAttendance()
        {
            InitializeComponent();
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
            }
            else
            {
                txtfullname.Text = string.Empty;
                txtfullname.Text = string.Empty;
            }

            
        }

        private void frmStudentAttendance_Load(object sender, EventArgs e)
        {
            
            cmbClass.SelectedIndex = 0;

            string QRY = "Select * from tblStudentAttendane";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendance.DataSource = dt;
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
            
            string QRY = "Insert into tblStudentAttendane (EnrollmentNo, FullName, Class, Section, Date, Time, AttendanceStatus) Values('" + cmbEnrollmentNo.Text + "','" + txtfullname.Text + "','" + cmbClass.Text + "','" + cmbSection.Text + "','" + dtpDate.Text + "','" + dtpTime.Text + "','" + AttendanceStatus + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            cmbEnrollmentNo.SelectedIndex = 0;            
            cmbClass.SelectedIndex = 0;
            cmbSection.Text = "";

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentAttendane order by EnrollmentNo desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendance.DataSource = dt;

            MessageBox.Show("Data Inserted Sucessfully");
        }
    }
}
