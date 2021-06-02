using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebView
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ID"]))
            {
                if (!IsPostBack)
                {
                    int ID = int.Parse(Request.QueryString["ID"]);
                    var ctx = new Data.DBContext();

                    Cliente c = ctx.Clientes.Find(ID);

                    lblID.Text = c.id.ToString();


                    txtNome.Text = c.nome;
                    txtEmail.Text = c.email;
                }
            }
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ID"]))
            {
                int ID = int.Parse(Request.QueryString["ID"]);
                var ctx = new Data.DBContext();

                Cliente c = ctx.Clientes.Find(ID);
                //c.nome = txtNome.Text;
                c.email = txtEmail.Text;

                if (ctx.SaveChanges() > 0)
                {
                    Response.Redirect("ListarClientes.aspx");
                }
            }
        }
    }
}