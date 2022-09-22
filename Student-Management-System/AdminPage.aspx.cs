using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Student_Management_System
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from " + DropDownList1.SelectedItem.Text;
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(DropDownList1.SelectedItem.Text == "Course")
            {
                GdCourse.Visible = true;
                GdStudent.Visible = false;
                GdTeacher.Visible = false;
                GdCourse.DataSource = dt;
                GdCourse.DataBind();
            }
            else if(DropDownList1.SelectedItem.Text == "student")
            {
                GdStudent.Visible = true;
                GdCourse.Visible = false;
                GdTeacher.Visible = false;
                GdStudent.DataSource = dt;
                GdStudent.DataBind();
            }
            else
            {
                GdTeacher.Visible = true;
                GdCourse.Visible = false;
                GdCourse.Visible = false;
                GdTeacher.DataSource = dt;
                GdTeacher.DataBind();
            }
            sqlconn.Close();
        }
        protected void GdCourse_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GdCourse.EditIndex = -1;
        }

        protected void GdCourse_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GdCourse.Rows[e.RowIndex];

            int courseID = Convert.ToInt32(GdCourse.DataKeys[e.RowIndex].Values[0]);
            string CourseName = (row.Cells[2].Controls[0] as TextBox).Text;
            string CourseFee = (row.Cells[3].Controls[0] as TextBox).Text;
            string CourseDuration = (row.Cells[4].Controls[0] as TextBox).Text;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update Course set CourseName=@CourseName,CourseFee=@CourseFee,CourseDuration=@CourseDuration where courseID=@courseID"; 
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@courseID", courseID);
            sqlcomm.Parameters.AddWithValue("@CourseName", CourseName);
            sqlcomm.Parameters.AddWithValue("@CourseFee", CourseFee);
            sqlcomm.Parameters.AddWithValue("@CourseDuration", CourseDuration);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdCourse_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GdCourse.EditIndex = e.NewEditIndex;
        }

        protected void GdCourse_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int courseID = Convert.ToInt32(GdCourse.DataKeys[e.RowIndex].Values[0]);
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from Course where courseID=@courseID";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@courseID", courseID);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();

        }

        protected void GdStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GdStudent.EditIndex = -1;
        }

        protected void GdStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GdStudent.Rows[e.RowIndex];

            int StudentID = Convert.ToInt32(GdStudent.DataKeys[e.RowIndex].Values[0]);
            string Firstname = (row.Cells[2].Controls[0] as TextBox).Text;
            string Middlename = (row.Cells[3].Controls[0] as TextBox).Text;
            string Surname = (row.Cells[4].Controls[0] as TextBox).Text;
            string Address = (row.Cells[5].Controls[0] as TextBox).Text;
            string Email = (row.Cells[6].Controls[0] as TextBox).Text;
            string PhoneNumber = (row.Cells[7].Controls[0] as TextBox).Text;
            string Pincode = (row.Cells[8].Controls[0] as TextBox).Text;
            string College = (row.Cells[9].Controls[0] as TextBox).Text;
            string TeacherName = (row.Cells[10].Controls[0] as TextBox).Text;
            string CourseName = (row.Cells[11].Controls[0] as TextBox).Text;
            string CourseFee = (row.Cells[12].Controls[0] as TextBox).Text;
            string PaidFees = (row.Cells[13].Controls[0] as TextBox).Text;
            string RemFees = (row.Cells[14].Controls[0] as TextBox).Text;
            string StartDate = (row.Cells[15].Controls[0] as TextBox).Text;
            string EndDate = (row.Cells[16].Controls[0] as TextBox).Text;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update student set Firstname=@Firstname,Middlename=@Middlename,Surname=@Surname,Address=@Address,Email=@Email,PhoneNumber=@PhoneNumber,Pincode=@Pincode,College=@College,TeacherName=@TeacherName,CourseName=@CourseName,CourseFee=@CourseFee,PaidFees=@PaidFees,RemFees=@RemFees,StartDate=@StartDate,EndDate=@EndDate where StudentID=@StudentID";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@StudentID", StudentID);
            sqlcomm.Parameters.AddWithValue("@Firstname", Firstname);
            sqlcomm.Parameters.AddWithValue("@Middlename", Middlename);
            sqlcomm.Parameters.AddWithValue("@Surname", Surname);
            sqlcomm.Parameters.AddWithValue("@Address", Address);
            sqlcomm.Parameters.AddWithValue("@Email", Email);
            sqlcomm.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            sqlcomm.Parameters.AddWithValue("@Pincode", Pincode);
            sqlcomm.Parameters.AddWithValue("@College", College);
            sqlcomm.Parameters.AddWithValue("@TeacherName", TeacherName);
            sqlcomm.Parameters.AddWithValue("@CourseName", CourseName);
            sqlcomm.Parameters.AddWithValue("@CourseFee", CourseFee);
            sqlcomm.Parameters.AddWithValue("@PaidFees", PaidFees);
            sqlcomm.Parameters.AddWithValue("@RemFees", RemFees);
            sqlcomm.Parameters.AddWithValue("@StartDate", StartDate);
            sqlcomm.Parameters.AddWithValue("@EndDate", EndDate);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StudentID = Convert.ToInt32(GdStudent.DataKeys[e.RowIndex].Values[0]);
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from student where StudentID=@StudentID";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@StudentID", StudentID);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GdStudent.EditIndex = e.NewEditIndex;
        }

        protected void GdTeacher_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GdTeacher.EditIndex = -1;
        }

        protected void GdTeacher_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GdTeacher.Rows[e.RowIndex];

            int TeacherID = Convert.ToInt32(GdTeacher.DataKeys[e.RowIndex].Values[0]);
            string TeacherName = (row.Cells[2].Controls[0] as TextBox).Text;
            string Qualification = (row.Cells[3].Controls[0] as TextBox).Text;
            string CourseDetail = (row.Cells[4].Controls[0] as TextBox).Text;
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update Teacher set TeacherName=@TeacherName,Qualification=@Qualification,CourseDetail=@CourseDetail where TeacherID=@TeacherID";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@TeacherID", TeacherID);
            sqlcomm.Parameters.AddWithValue("@TeacherName", TeacherName);
            sqlcomm.Parameters.AddWithValue("@Qualification", Qualification);
            sqlcomm.Parameters.AddWithValue("@CourseDetail", CourseDetail);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdTeacher_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int TeacherID = Convert.ToInt32(GdTeacher.DataKeys[e.RowIndex].Values[0]);
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from Teacher where TeacherID=@TeacherID";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@TeacherID", TeacherID);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdTeacher_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GdTeacher.EditIndex = e.NewEditIndex;
        }
    }
}