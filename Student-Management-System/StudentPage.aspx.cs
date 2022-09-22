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
    public partial class StudentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButStudent_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[student](Firstname,Middlename,Surname,Address,Email,Phonenumber,Pincode,College,TeacherName,CourseName,CourseFee,PaidFees,RemFees,StartDate,EndDate) Values(@Firstname,@Middlename,@Surname,@Address,@Email,@Phonenumber,@Pincode,@College,@TeacherName,@CourseName,@CourseFee,@PaidFees,@RemFees,@StartDate,@EndDate)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Firstname", TxtFirstname.Text);
            sqlcomm.Parameters.AddWithValue("@Middlename", TxtMiddlename.Text);
            sqlcomm.Parameters.AddWithValue("@Surname", TxtSurname.Text);
            sqlcomm.Parameters.AddWithValue("@Address", TxtAddress.Text);
            sqlcomm.Parameters.AddWithValue("@Email", TxtEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Phonenumber", TxtPhonenumber.Text);
            sqlcomm.Parameters.AddWithValue("@Pincode", TxtPincode.Text);
            sqlcomm.Parameters.AddWithValue("@College", DDLCollege.Text);
            sqlcomm.Parameters.AddWithValue("@TeacherName", DDLTeacherName.Text);
            sqlcomm.Parameters.AddWithValue("@CourseName", DDLCourseName.Text);
            sqlcomm.Parameters.AddWithValue("@CourseFee", LabCourseFee.Text);
            sqlcomm.Parameters.AddWithValue("@PaidFees", TxtPaidFees.Text);
            sqlcomm.Parameters.AddWithValue("@RemFees", LabRemFees.Text);
            sqlcomm.Parameters.AddWithValue("@StartDate", TxtStartDate.Text);
            sqlcomm.Parameters.AddWithValue("@EndDate", TxtEndDate.Text);
            sqlcomm.ExecuteNonQuery();
            Response.Write("<script>alert('Course Information Added Successfully.!!');</script>");
            TxtFirstname.Text = "";
            TxtMiddlename.Text = "";
            TxtSurname.Text = "";
            TxtAddress.Text = "";
            TxtEmail.Text = "";
            TxtPhonenumber.Text = "";
            TxtPincode.Text = "";
            DDLCollege.Items.Clear();
            DDLTeacherName.Items.Clear();
            DDLCourseName.Items.Clear();
            LabCourseFee.Text = "";
            TxtPaidFees.Text = "";
            LabRemFees.Text = "";
            TxtStartDate.Text = "";
            TxtEndDate.Text = "";
            sqlconn.Close();
        }

        protected void DDLCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[course] where CourseName = @CourseName";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@CourseName", DDLCourseName.SelectedItem.Text);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while (sdr.Read())
            {
                LabCourseFee.Text = sdr["CourseFee"].ToString();
            }
            sqlconn.Close();

        }

        protected void TxtPaidFees_TextChanged(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(LabCourseFee.Text) - Convert.ToInt32(TxtPaidFees.Text);
            LabRemFees.Text = balance.ToString();
        }
    }
}