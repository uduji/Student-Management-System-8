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
    public partial class CoursePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButCourse_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Course] (CourseName,CourseFee,CourseDuration) values(@CourseName,@CourseFee,@CourseDuration)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@CourseName", TxtCourseName.Text);
            sqlcomm.Parameters.AddWithValue("@CourseFee", TxtCourseFee.Text);
            sqlcomm.Parameters.AddWithValue("@CourseDuration", DropDownList1.Text);
            sqlcomm.ExecuteNonQuery();
            Response.Write("<script>alert('Course Information Added Successfully.!!');</script>");
            TxtCourseName.Text = "";
            TxtCourseFee.Text = "";
            DropDownList1.Items.Clear();
            sqlconn.Close();
        }
    }
}