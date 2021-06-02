<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="WebView.Editar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            ID:
            <asp:Label ID="lblID" runat="server"></asp:Label>
            <br />
            <br />
            Nome:<br />
            <asp:TextBox ID="txtNome" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            E-mail:<br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnAtualizar" runat="server" OnClick="BtnCadastrar_Click" Text="Alterar Dados" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
