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
    public partial class frmExamReport : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        public frmExamReport()
        {
            InitializeComponent();
        }

        private void btngenerate_Click(object sender, EventArgs e)
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

            string QRY = "SELECT EnrollmentNo, FullName, ExamType, COUNT(*) * 100 AS TotalMarks," +
             " SUM(CONVERT(INT, ObtainedMarks)) AS TotalObtainedMarks, COUNT(*) AS TotalSubjects," +
             " SUM(CONVERT(INT, ObtainedMarks)) / COUNT(*) AS Percentage, " +
             " CASE " +
             "   WHEN SUM(CONVERT(INT, ObtainedMarks)) / COUNT(*) >= 80 THEN 'A-1' " +
             "   WHEN SUM(CONVERT(INT, ObtainedMarks)) / COUNT(*) >= 70 THEN 'A' " +
             "   WHEN SUM(CONVERT(INT, ObtainedMarks)) / COUNT(*) >= 60 THEN 'B' " +
             "   WHEN SUM(CONVERT(INT, ObtainedMarks)) / COUNT(*) >= 50 THEN 'C' " +
             "   WHEN SUM(CONVERT(INT, ObtainedMarks)) / COUNT(*) >= 40 THEN 'D' " +
             "   ELSE 'Fail' " +
             " END AS Grade " +
             " FROM [dbo].[tblExamination] " +
             " WHERE (EnrollmentNo like '%" + txtEnrollmentNo.Text + "%') AND (Class like '%" + cmbClass.Text + "%') AND (Section like '%" + cmbSection.Text + "%') AND " +
             " (Examtype like '%" + type + "%') GROUP BY EnrollmentNo, FullName, ExamType";

            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvExamReport.DataSource = dt;
        }
    }
}
