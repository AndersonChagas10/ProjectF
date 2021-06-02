<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebView.Cadastro" %>

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
            Categoria:<br />
            <asp:DropDownList ID="ddl" runat="server" DataTextField="descricao" DataValueField="id" style="margin-bottom: 0px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="BtnCadastrar" runat="server" OnClick="BtnCadastrar_Click" Text="Cadastrar" />
        </div>
    </form>
</body>
</html>
