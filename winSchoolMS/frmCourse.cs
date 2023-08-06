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
    public partial class frmCourse : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP;Initial Catalog=dbSchoolMS;Integrated Security=True");
        string ID;
        public frmCourse()
        {
            InitializeComponent();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            string QRY = "Select * from tblCourses";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourse.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into tblCourses (Class, Course) Values( '" + txtClass.Text+"', '"+txtCourse.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtClass.Text = "";
            txtCourse.Text = "";

            string QRY = "Select * from tblCourses";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourse.DataSource = dt;

            MessageBox.Show("Data Inserted Sucessfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update tblCourses set Class = '" + txtClass.Text + "' , Course = '" + txtCourse.Text + "' where ID =" + ID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtClass.Text = "";
            txtCourse.Text = "";

            string QRY = "Select * from tblCourses order by Class desc";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourse.DataSource = dt;

            MessageBox.Show("Data Updated Sucessfully");
        }

        private void gvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = gvCourse.Rows[e.RowIndex].Cells[0].Value.ToString();
            string classes = gvCourse.Rows[e.RowIndex].Cells[1].Value.ToString();
            string course = gvCourse.Rows[e.RowIndex].Cells[2].Value.ToString();


            txtCourse.Text = course;
            txtClass.Text = classes;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from tblCourses where ID =" + ID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtClass.Text = "";
            txtCourse.Text = "";

            string QRY = "Select * from tblCourses order by Class desc";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourse.DataSource = dt;

            MessageBox.Show("Data Deleted Sucessfully");
        }
    }
}
