using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace winSchoolMS
{
    public partial class frmStudentPersonalDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        string studentid;

        public frmStudentPersonalDetails()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Check if the email already exists in the table
            SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM tblStudentPersonalDetails WHERE Email = @Email", con);
            checkEmailCmd.Parameters.AddWithValue("@Email", txtemail.Text);
            con.Open();
            int emailCount = (int)checkEmailCmd.ExecuteScalar();
            con.Close();

            if (emailCount > 0)
            {
                // The email already exists, show a message or handle the situation accordingly
                MessageBox.Show("Email already exists in the table. Data not inserted.");
            }
            else
            {
                string gender = string.Empty;
                if (rdbmale.Checked)
                {
                    gender = "Male";
                }
                if (rdbfemale.Checked)
                {
                    gender = "Female";
                }
                string email = txtemail.Text;


                string QRY = "Insert into tblStudentPersonalDetails (EnrollmentNo, FullName, FatherName, Contact, EmergencyContact, Email, Address, DateOFBirth, Guardian, Religion, Nationality, Gender) Values('" + txtenrollmentnumber.Text + "','" + txtFullName.Text + "','" + txtFatherName.Text + "','" + txtcontact.Text + "','" + txtemergencycontact.Text + "','" + txtemail.Text + "','" + txtAddress.Text + "','" + dtpDateofBirth.Text + "','" + txtgardians.Text + "','" + txtreligon.Text + "','" + txtNationality.Text + "','" + gender + "')";
                SqlCommand cmd = new SqlCommand(QRY, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtenrollmentnumber.Text = "";
                txtFullName.Text = "";              
                txtFatherName.Text = "";
                txtcontact.Text = "";
                txtemergencycontact.Text = "";
                txtemail.Text = "";
                txtAddress.Text = "";
                txtgardians.Text = "";
                txtreligon.Text = "";
                txtNationality.Text = "";
                rdbmale.Checked = false;
                rdbfemale.Checked = false;
                dtpDateofBirth.Value = DateTime.Today;



                SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentPersonalDetails order by StudentID desc", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvStudentPersonalDetails.DataSource = dt;

                MessageBox.Show("Data Inserted Sucessfully");
            }
        }

        private void frmStudentPersonalDetails_Load(object sender, EventArgs e)
        {
            
            string QRY = "Select * from tblStudentPersonalDetails";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentPersonalDetails.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (rdbmale.Checked)
            {
                gender = "Male";
            }
            if (rdbfemale.Checked)
            {
                gender = "Female";
            }

            string QRY = "Update tblStudentPersonalDetails set EnrollmentNo = '" + txtenrollmentnumber.Text + "',FullName = '" + txtFullName.Text + "', FatherName = '" + txtFatherName.Text + "', Contact = '" + txtcontact.Text + "', EmergencyContact = '" + txtemergencycontact.Text + "',  Email = '" + txtemail.Text + "', Address = '" + txtAddress.Text + "', DateOFBirth = '" + dtpDateofBirth.Text + "', Guardian = '" + txtgardians.Text + "', Religion = '" + txtreligon.Text + "', Nationality = '" + txtNationality.Text + "', Gender = '" + gender + "' where StudentID =" + studentid;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtenrollmentnumber.Text = "";
            txtFullName.Text = "";
            txtFatherName.Text = "";
            txtcontact.Text = "";
            txtemergencycontact.Text = "";
            txtemail.Text = "";
            txtAddress.Text = "";
            txtgardians.Text = "";
            txtreligon.Text = "";
            txtNationality.Text = "";
            rdbmale.Checked = false;
            rdbfemale.Checked = false;

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentPersonalDetails order by StudentID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentPersonalDetails.DataSource = dt;

            // btnInsert.Enabled = true;

            MessageBox.Show("Data Updated Sucessfully");
        }

        private void gvStudentPersonalDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            studentid = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            string enrollmentNo = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            string FullName = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            string FatherName = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Contact = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            string EmergencyContact = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
            string Email = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[6].Value.ToString();
            string Address = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[7].Value.ToString();
            string DOB = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[8].Value.ToString();
            string Guardian = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[9].Value.ToString();
            string Religion = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[10].Value.ToString();
            string Nationality = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[11].Value.ToString();
            string Gender = gvStudentPersonalDetails.Rows[e.RowIndex].Cells[12].Value.ToString().Trim().ToLower();

          
            if (Gender == "male")
            {
                rdbmale.Checked = true;
                rdbfemale.Checked = false;
            }
            else if (Gender == "female")
            {
                rdbfemale.Checked = true;
                rdbmale.Checked = false;
            }
            else
            {
                MessageBox.Show("not defined");
            }

            txtenrollmentnumber.Text = enrollmentNo;
            txtFullName.Text = FullName;
            txtFatherName.Text = FatherName;
            txtcontact.Text = Contact;
            txtemergencycontact.Text = EmergencyContact;
            dtpDateofBirth.Text = DOB;
            txtemail.Text = Email;
            txtAddress.Text = Address;
            txtgardians.Text = Guardian;
            txtreligon.Text = Religion;
            txtNationality.Text = Nationality;

           // btnInsert.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            string QRY = "Delete from tblStudentPersonalDetails where StudentID =" + studentid;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtenrollmentnumber.Text = "";
            txtFullName.Text = "";
            txtFatherName.Text = "";
            txtcontact.Text = "";
            txtemergencycontact.Text = "";
            txtemail.Text = "";
            txtAddress.Text = "";
            txtgardians.Text = "";
            txtreligon.Text = "";
            txtNationality.Text = "";
            rdbmale.Checked = false;
            rdbfemale.Checked = false;

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblStudentPersonalDetails order by StudentID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStudentPersonalDetails.DataSource = dt;

           
            MessageBox.Show("Data Deleted Sucessfully");
        }
    }
}
