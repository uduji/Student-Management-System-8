﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SMS.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Student_Management_System.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Page</h1>
    <hr />
    <asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem>Course</asp:ListItem>
    <asp:ListItem>student</asp:ListItem>
    <asp:ListItem>Teacher</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="ButSubmit" runat="server" Text="Submit" OnClick="ButSubmit_Click" />
    <asp:GridView ID="GdCourse" runat="server" DataKeyNames="courseID" AutoGenerateEditButton ="true" AutoGenerateDeleteButton ="true" OnRowCancelingEdit="GdCourse_RowCancelingEdit" OnRowDeleting="GdCourse_RowDeleting" OnRowEditing="GdCourse_RowEditing" OnRowUpdating="GdCourse_RowUpdating"></asp:GridView>
    <asp:GridView ID="GdStudent" runat="server" DataKeyNames="StudentID" AutoGenerateEditButton ="true" AutoGenerateDeleteButton ="true" OnRowCancelingEdit="GdStudent_RowCancelingEdit" OnRowDeleting="GdStudent_RowDeleting" OnRowEditing="GdStudent_RowEditing" OnRowUpdating="GdStudent_RowUpdating"></asp:GridView>
    <asp:GridView ID="GdTeacher" runat="server"  DataKeyNames ="TeacherID" AutoGenerateEditButton ="true" AutoGenerateDeleteButton ="true" OnRowCancelingEdit="GdTeacher_RowCancelingEdit" OnRowDeleting="GdTeacher_RowDeleting" OnRowEditing="GdTeacher_RowEditing" OnRowUpdating="GdTeacher_RowUpdating"></asp:GridView>
</asp:Content>