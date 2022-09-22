<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="Student_Management_System.StudentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Page</h1>
    <div style ="background-color: aqua; width: 319px;">
    <table border="0">
        <tr>
            <td>Firstname:</td>
            <td>
                <asp:TextBox ID="TxtFirstname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Middlename:</td>
            <td>
                <asp:TextBox ID="TxtMiddlename" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Surname:</td>
            <td>
                <asp:TextBox ID="TxtSurname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Address:</td>
            <td>
                <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email:</td>
            <td>
                <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Phone Number:</td>
            <td>
                <asp:TextBox ID="TxtPhonenumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Pincode:</td>
            <td>
                <asp:TextBox ID="TxtPincode" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>College:</td>
            <td>
                <asp:DropDownList ID="DDLCollege" runat="server" AutoPostBack="True" AppendDataBoundItems="true" DataSourceID="SqlDataSource1" DataTextField="College" DataValueField="College"><asp:ListItem  Text="-- Select College --" Value="select"  Selected="True"></asp:ListItem></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString %>" SelectCommand="SELECT [College] FROM [student]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Teacher Name:</td>
            <td>
                <asp:DropDownList ID="DDLTeacherName" runat="server" AutoPostBack="True" AppendDataBoundItems="true" DataSourceID="SqlDataSource2" DataTextField="TeacherName" DataValueField="TeacherName"><asp:ListItem Text="-- Select Teacher --" Value="select" Selected="True"></asp:ListItem></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString2 %>" SelectCommand="SELECT [TeacherName] FROM [Teacher]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Course Name:</td>
            <td>
                <asp:DropDownList ID="DDLCourseName" runat="server" AutoPostBack="True" AppendDataBoundItems="true" DataSourceID="SqlDataSource3" DataTextField="CourseName" DataValueField="CourseName" OnSelectedIndexChanged="DDLCourseName_SelectedIndexChanged"><asp:ListItem Text="-- Select Course --" Value="select"  Selected="True"></asp:ListItem></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:StudentManagementSystemConnectionString3 %>" SelectCommand="SELECT [CourseName] FROM [Course]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Course Fee:</td>
            <td>
                <asp:Label ID="LabCourseFee" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Paid Fees:</td>
            <td>
                <asp:TextBox ID="TxtPaidFees" runat="server" AutoPostBack="True" OnTextChanged="TxtPaidFees_TextChanged"></asp:TextBox></td>
            </tr>
        <tr>
            <td>Remaining Fees:</td>
            <td>
                <asp:Label ID="LabRemFees" runat="server" Text=""></asp:Label></td>
        </tr>

        <tr>
                <td>Start Date:</td>
                <td style="width: 194px">
                    <asp:TextBox ID="TxtStartDate" runat="server" Type ="date" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>End Date:</td>
                <td style="width: 194px">
                    <asp:TextBox ID="TxtEndDate" runat="server" Type ="date" ></asp:TextBox></td>
            </tr>
        <tr>
            <td>
                    &nbsp;</td>
            <td>
                <asp:Button ID="ButStudent" runat="server" Text="Submit" OnClick="ButStudent_Click" /></td>
        </tr>
    </table>
        </div>
</asp:Content>
