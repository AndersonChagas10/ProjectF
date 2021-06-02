using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebView
{
    public partial class Apagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ID"]))
            {
                int ID = int.Parse(Request.QueryString["ID"]);
                lblMsg.Text = "Deseja apagar o Cliente com ID = " + ID.ToString();
            }
            else
            {
                btnSIM.Enabled = false;
                btnNAO.Enabled = false;
                lblMsg.Enabled = false;
            }
        }

        protected void btnSIM_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ID"]))
            {
                int ID = int.Parse(Request.QueryString["ID"]);
                var ctx = new Data.DBContext();
                ctx.Clientes.Remove(ctx.Clientes.Find(ID));

                if (ctx.SaveChanges() > 0)
                {
                    Response.Redirect("ListarClientes.aspx");
                }
            }
        }

        protected void btnSIM0_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarClientes.aspx");
        }
    }
}