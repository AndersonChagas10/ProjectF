using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebView
{
    public partial class ListarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ctx = new Data.DBContext();

            ctx.Database.Log = message => Show_Logs(message);

            //gvClientes.DataSource = ctx.Clientes.ToList();
            //gvClientes.DataSource = ctx.Clientes.Where(c => c.categoria.id.Equals(1)).ToList();
            //gvClientes.DataSource = ctx.Clientes.Where(c => c.nome.StartsWith("r")).ToList();

            /* var consulta = from c in ctx.Clientes.ToList()
                            where c.nome.Contains("a")
                            select c;*/

            gvClientes.DataSource = ctx.Clientes.Where(c => c.nome.StartsWith("r")).ToList();
            gvClientes.DataBind();
        }


        private void Show_Logs(string message)
        {
            Response.Write(message + "<br><br>");
        }
    }
}