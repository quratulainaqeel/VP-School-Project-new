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
    public partial class frmStudentEducationalDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        string admissionID;
        public frmStudentEducationalDetails()
        {
            InitializeComponent();
        }

        private void frmStudentEducationalDetails_Load(object sender, EventArgs e)
        {
            string QRY = "Select * from tblStudentEducationalDetails";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvEducationalDetail.DataSource = dt;

            txtfullname.Enabled = false;
            txtFatherName.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Check if the enrollment number already exists in the table
            SqlCommand checkEnrollmentNo = new SqlCommand("SELECT COUNT(*) FROM tblStudentEducationalDetails WHERE EnrollmentNo = @EnrollmentNo", con);
            checkEnrollmentNo.Parameters.AddWithValue("@EnrollmentNo",txtenrollmentnumber.Text);
            con.Open();
            int enrollmentNoCount = (int)checkEnrollmentNo.ExecuteScalar();
            con.Close();

            if (enrollmentNoCount > 0)
            {
                // The enrollment number already exists, show a message or handle the situation accordingly
                MessageBox.Show("EnrollmentNo already exists in the table. Data not inserted.");
            }
            else
            {
                string QRY = "Insert into tblStudentEducationalDetails (EnrollmentNo, FullName, FatherName, AdmissionDate, Class, Section) Values('" + txtenrollmentnumber.Text + "','" + txtfullname.Text + "','" + txtFatherName.Text + "','" + dtpAdmissionDate.Text + "','" + cmbClass.Text + "','" + cmbSection.Text + "')";
                SqlCommand cmd = new SqlCommand(QRY, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtenrollmentnumber.Text = "";
                txtfullname.Text = "";
                txtFatherName.Text = "";
                dtpAdmissionDate.Text = "";
                cmbClass.Text = "";
                cmbSection.Text = "";

                txtfullname.Enabled = false;
                txtFatherName.Enabled = false;

                SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentEducationalDetails order by EnrollmentNo desc", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvEducationalDetail.DataSource = dt;

                MessageBox.Show("Data Inserted Sucessfully");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string QRY = "Update tblStudentEducationalDetails set EnrollmentNo  = '"+txtenrollmentnumber.Text+"', AdmissionDate = '"+dtpAdmissionDate.Text+"' , Class = '"+cmbClass.Text+"' , Section = '"+cmbSection.Text+"' where AdmissionID = " + admissionID;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtenrollmentnumber.Text = "";
            txtfullname.Text = "";
            txtFatherName.Text = "";
            dtpAdmissionDate.Value = DateTime.Today;
            cmbClass.Text = "";
            cmbSection.Text = "";

            txtfullname.Enabled = false;
            txtFatherName.Enabled = false;


            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentEducationalDetails order by EnrollmentNo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvEducationalDetail.DataSource = dt;

            MessageBox.Show("Data Updated Sucessfully");
        }

        private void gvEducationalDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            admissionID = gvEducationalDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            string EnrollmentNumber = gvEducationalDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            string fullname = gvEducationalDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            string fathername = gvEducationalDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            string admissiondate = gvEducationalDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            string stuclass = gvEducationalDetail.Rows[e.RowIndex].Cells[5].Value.ToString();
            string section = gvEducationalDetail.Rows[e.RowIndex].Cells[6].Value.ToString();

            txtenrollmentnumber.Text = EnrollmentNumber;
            txtfullname.Text = fullname;
            txtFatherName.Text = fathername;
            dtpAdmissionDate.Text = admissiondate;
            cmbClass.Text = stuclass;
            cmbSection.Text = section;

            txtfullname.Enabled = false;
            txtFatherName.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string QRY = "Delete from tblStudentEducationalDetails where  AdmissionID = " + admissionID;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentEducationalDetails order by EnrollmentNo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvEducationalDetail.DataSource = dt;

            txtenrollmentnumber.Text = "";
            txtfullname.Text = "";
            txtFatherName.Text = "";
            dtpAdmissionDate.Text = "";
            cmbClass.Text = "";
            cmbSection.Text = "";

            txtfullname.Enabled = false;
            txtFatherName.Enabled = false;

            MessageBox.Show("Data Deleted Sucessfully");
        }

        private void txtenrollmentnumber_TextChanged(object sender, EventArgs e)
        {
            string QRY = "SELECT * FROM tblStudentPersonalDetails WHERE EnrollmentNo = @EnrollmentNo";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);

            // Add the parameter to the SqlDataAdapter
            da.SelectCommand.Parameters.AddWithValue("@EnrollmentNo", txtenrollmentnumber.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            txtfullname.Enabled = false;
            txtFatherName.Enabled = false;

            if (dt.Rows.Count > 0)
            {
                txtfullname.Text = dt.Rows[0]["FullName"].ToString();
                txtFatherName.Text = dt.Rows[0]["FatherName"].ToString();
            }
            else
            {
                txtfullname.Text = string.Empty;
                txtFatherName.Text = string.Empty;                
            }
        }
    }
}
