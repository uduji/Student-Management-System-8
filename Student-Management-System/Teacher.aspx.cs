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
    public partial class TeacherPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButTeacher_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Teacher] (TeacherName,Qualification,CourseDetail) values(@TeacherName,@Qualification,@CourseDetail)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@TeacherName", TxtTeacherName.Text);
            sqlcomm.Parameters.AddWithValue("@Qualification", TxtQualification.Text);
            sqlcomm.Parameters.AddWithValue("@CourseDetail", TxtCourseDetail.Text);
            sqlcomm.ExecuteNonQuery();
            Response.Write("<script>alert('Teacher Information Added Successfully.!!');</script>");
            TxtTeacherName.Text = "";
            TxtQualification.Text = "";
            TxtCourseDetail.Text = "";
            sqlconn.Close();
        }
    }
}