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
    public partial class FrmExaminationDetail : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");

        public FrmExaminationDetail()
        {
            InitializeComponent();
        }

        private void FrmExaminationDetail_Load(object sender, EventArgs e)
        {
            string QRY = "Select * from tblExamination";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvExamination.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string QRY = "SELECT EnrollmentNo, FullName,ExamType, COUNT(*) * 100 AS TotalMarks,"+
            "SUM(CONVERT(INT, ObtainedMarks)) AS TotalObtainedMarks, COUNT(*) AS TotalSubjects,"+
            " SUM(CONVERT(INT, ObtainedMarks)) / COUNT(*) AS Percentage FROM [dbo].[tblExamination]"+
            " WHERE (EnrollmentNo = 'ALSS-006') AND (Class = '10') AND (Section = 'A') AND "+
            " (Examtype = 'Mid') GROUP BY EnrollmentNo, FullName, TotalMarks, ExamType";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvExamination.DataSource = dt;
        }
    }
}
