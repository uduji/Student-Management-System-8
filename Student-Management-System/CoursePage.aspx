<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="CoursePage.aspx.cs" Inherits="Student_Management_System.CoursePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Course Page</h1>
    <div style ="background-color:aqua; width: 292px; margin-left: 0px;">
    <table>
        <tr>
            <td>Course Name:</td>
            <td>
                <asp:TextBox ID="TxtCourseName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Course Fee:</td>
            <td>
                <asp:TextBox ID="TxtCourseFee" runat="server" ></asp:TextBox></td>
            </tr>
        <tr>
            <td>Course Duration:</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="-- SELECT --" Value="select" Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="3 Months" Value="3 Months"></asp:ListItem>  
                            <asp:ListItem Text="6 Months" Value="6 Months"></asp:ListItem>  
                            <asp:ListItem Text="9 Months" Value="9 Months"></asp:ListItem> 
                            <asp:ListItem Text="1 Year" Value="1 Year"></asp:ListItem>
                            <asp:ListItem Text="2 Years" Value="2 Years"></asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="ButCourse" runat="server" Text="Save" OnClick="ButCourse_Click" /></td>
            <td>
       </tr>
        </table>
   </div>
</asp:Content>
