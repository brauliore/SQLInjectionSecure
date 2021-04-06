<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="asp.netloginpage.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; top: 45%; left: 44%; margin-top: -50px; margin-left: -50px; width: 252px; height: 172px;">
        <asp:Label ID="lblUserDetails" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblUserPass" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        <br />
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
        </asp:DataList>
    </div>
    </form>
</body>
</html>
