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
    public partial class frmDefultarstudent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");

        public frmDefultarstudent()
        {
            InitializeComponent();
        }

        private void frmDefultarstudent_Load(object sender, EventArgs e)
        {
            string QRY = "SELECT tblStudentEducationalDetails.EnrollmentNo, tblStudentEducationalDetails.FullName, tblStudentEducationalDetails.Class, tblStudentEducationalDetails.Section, Month, Date FROM [dbo].[tblStudentEducationalDetails] LEFT JOIN [dbo].[tblStudentFeePayment] ON tblStudentEducationalDetails.EnrollmentNo = tblStudentFeePayment.EnrollmentNo ORDER BY tblStudentEducationalDetails.EnrollmentNo, tblStudentFeePayment.Month";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDefaulterStudent.DataSource = dt;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
             string QRY = "SELECT ted.EnrollmentNo, ted.FullName, ted.Class, ted.Section, tfp.Month AS PaymentMonth, tfp.[Date] " +
             "FROM [dbo].[tblStudentEducationalDetails] ted " +
             "LEFT JOIN [dbo].[tblStudentFeePayment] tfp ON ted.EnrollmentNo = tfp.EnrollmentNo " +
             "WHERE (ted.EnrollmentNo LIKE '%" + txtSearch.Text + "%' OR ted.FullName LIKE '%" + txtSearch.Text + "%' OR tfp.Month LIKE '%" + txtSearch.Text + "' OR tfp.Date LIKE '%" + txtSearch.Text + "%') " +
             "AND ted.Class LIKE '%" + cmbClass.Text + "%' " +
             "AND ted.Section LIKE '%" + cmbSection.Text + "%' " +
             (string.IsNullOrEmpty(cmbMonth.Text) ? "" : "AND tfp.Month LIKE '%" + cmbMonth.Text + "%'") +
             "ORDER BY ted.EnrollmentNo, tfp.Month";

            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDefaulterStudent.DataSource = dt;
        }

        
    }
}
