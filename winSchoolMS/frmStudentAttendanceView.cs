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
    public partial class frmStudentAttendanceView : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        public frmStudentAttendanceView()
        {
            InitializeComponent();
        }

        private void frmStudentAttendanceView_Load(object sender, EventArgs e)
        {
            string QRY = "Select * from tblStudentAttendane";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendanceView.DataSource = dt;          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string QRY = "select EnrollmentNo, FullName, Class, Section, Month, Date, Time, AttendanceStatus  from tblStudentAttendane  where (EnrollmentNo like '%"+txtSearch.Text+"%' OR FullName like '%"+txtSearch.Text+"%' OR Date like '%"+ txtSearch.Text+"%' OR AttendanceStatus like '%"+ txtSearch.Text+"%' ) AND Class like '%"+cmbClass.Text+"%' AND Section like '%"+cmbSection.Text+"%' AND Month like '%"+cmbMonth.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentAttendanceView.DataSource = dt;
        }
    }
}
