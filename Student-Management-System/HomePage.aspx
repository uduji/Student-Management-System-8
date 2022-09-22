<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Student_Management_System.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 95px;
            width: 249px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>STUDENT MANAGEMENT SYSTEM</h1>
                <hr />
                <div style="background-color: aqua; " class="auto-style1">
                <table border="1">
                    <tr>
                        <td>Admin</td>
                        <td>
                            <asp:TextBox ID="TxtAdminId" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>password</td>
                        <td>
                            <asp:TextBox ID="TxtPwdAdmin" runat="server" TextMode="Password" Width="117px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="ButLogin" runat="server" Text="Login" OnClick="ButLogin_Click" /></td>
                        <td>
                            <asp:Label ID="Labmsg" runat="server" Text="" ForeColor="Red"></asp:Label></td>
                    </tr>
                </table>
                    </div>
        </div>
    </form>
</body>
</html>
