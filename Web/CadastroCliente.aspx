<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Web.CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome:<br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <br />
            E-mail:<br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
            <br />
        </div>
    </form>
</body>
</html>
