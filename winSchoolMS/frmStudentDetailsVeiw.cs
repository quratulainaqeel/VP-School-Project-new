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
    public partial class frmStudentDetailsVeiw : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");

        public frmStudentDetailsVeiw()
        {
            InitializeComponent();
        }

        private void frmStudentDetailsVeiw_Load(object sender, EventArgs e)
        {
            string QRY = "select tblStudentPersonalDetails.EnrollmentNo, tblStudentPersonalDetails.FullName, tblStudentPersonalDetails.FatherName, Contact, EmergencyContact, Email, Address, DateOfBirth, Guardian, Religion, Nationality, Gender, AdmissionDate, Class, Section from [dbo].[tblStudentPersonalDetails] inner join [dbo].[tblStudentEducationalDetails] on tblStudentPersonalDetails.EnrollmentNo = tblStudentEducationalDetails.EnrollmentNo";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentDetailSearch.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string QRY = "select tblStudentPersonalDetails.EnrollmentNo, tblStudentPersonalDetails.FullName, tblStudentPersonalDetails.FatherName, Contact, EmergencyContact, Email, Address, DateOfBirth, Guardian, Religion, Nationality, Gender, AdmissionDate, Class, Section from [dbo].[tblStudentPersonalDetails] inner join [dbo].[tblStudentEducationalDetails] on tblStudentPersonalDetails.EnrollmentNo = tblStudentEducationalDetails.EnrollmentNo where (tblStudentPersonalDetails.FullName like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.email like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.Address like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.Gender like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.Contact like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.Nationality like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.FatherName like  '%" + txtsearch.Text+ "%'OR tblStudentPersonalDetails.EmergencyContact like '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.DateOFBirth like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.Guardian like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.Religion like  '%" + txtsearch.Text+ "%' OR tblStudentEducationalDetails.AdmissionDate like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.EnrollmentNo like  '%" + txtsearch.Text+ "%' OR tblStudentPersonalDetails.Religion like  '%" + txtsearch.Text+ "%')  AND (tblStudentEducationalDetails.Class like '%" + cmbClass.Text+"%') AND (tblStudentEducationalDetails.Section like '%"+cmbSection.Text+"%')";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentDetailSearch.DataSource = dt;
        }
    }
}
