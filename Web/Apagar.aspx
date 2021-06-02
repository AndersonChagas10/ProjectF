<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apagar.aspx.cs" Inherits="WebView.Apagar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMsg" runat="server" EnableTheming="False" Font-Bold="True" Font-Size="Large"></asp:Label>
        </div>
        <br />
        <asp:Button ID="btnSIM" runat="server" OnClick="btnSIM_Click" Text="SIM" Width="122px" />
&nbsp;&nbsp;
        <asp:Button ID="btnNAO" runat="server" OnClick="btnSIM0_Click" Text="NÃO" Width="122px" />
    </form>
</body>
</html>
