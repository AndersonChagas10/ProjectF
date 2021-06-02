using System;
using Data;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Web
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            var ctx = new Data.DBContext();

            Cliente cli = new Cliente();
            
            cli.nome = txtNome.Text;
            cli.email = txtemail.Text;
            ctx.Clientes.Add(cli);

            ctx.SaveChanges();
        }
    }
}