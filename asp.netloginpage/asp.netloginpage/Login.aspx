<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="asp.netloginpage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align:center">Braulio Rivera Login</h1>
    <table style="margin:auto;border:5px solid white">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Label ID="lblErrorMessage" runat="server" Text="Incorrect User Credentials" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    </h1>
    </form>
</body>
</html>
