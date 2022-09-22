<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="Teacher.aspx.cs" Inherits="Student_Management_System.TeacherPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Teacher Page</h1>
        <div style ="background-color: aqua; height: 126px; width: 242px;">
        <table>
            <tr>
                <td>Teacher Name:</td>
                <td>
                    <asp:TextBox ID="TxtTeacherName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Subject:</td>
                <td>
                    <asp:TextBox ID="TxtCourseDetail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Qualification:</td>
                <td>
                    <asp:TextBox ID="TxtQualification" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="ButTeacher" runat="server" Text="Save" OnClick="ButTeacher_Click" />
                </tr>
        </table>
    </div>

</asp:Content>
