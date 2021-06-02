<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarClientes.aspx.cs" Inherits="WebView.ListarClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="214px" Width="805px">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="nome" HeaderText="Nome Cliente" />
                    <asp:BoundField DataField="categoria.descricao" HeaderText="Categoria" />
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Apagar.aspx?ID={0}" HeaderText="Apagar" Text="Sim" />
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Editar.aspx?ID={0}" HeaderText="Editar" Text="Editar" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Cadastro.aspx">Novo Cliente</asp:HyperLink>
    </form>
</body>
</html>
