using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebView
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var ctx = new Data.DBContext();
                ddl.DataSource = ctx.Categoria.ToList();
                ddl.DataBind();
            }
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            var ctx = new Data.DBContext();

            Cliente cli = new Cliente();
            cli.nome = txtNome.Text;
            cli.email = txtEmail.Text;
            cli.categoria = ctx.Categoria.Find(int.Parse(ddl.SelectedValue));

            Cliente c = ctx.Clientes.Add(cli);

            int result = ctx.SaveChanges();

            if (result > 0)
            {
                //Response.Write("Cadastro realizado com sucesso - ID = " + c.id.ToString());
                Response.Redirect("ListarClientes.aspx");
            }
        }
    }
}