using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;


namespace interfaz
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> Listado { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && Request.Url.AbsolutePath.ToLower().Contains("default.aspx"))
            {
                Response.Redirect("~/inicio");
            }
            if (!IsPostBack)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Listado = negocio.listarArticulo();
                Session.Add("listadoArticulo", Listado);
                
                repArticulo.DataSource = Listado;
                repArticulo.DataBind();
            }
            
        }

        protected void btnIdArticulo_Click(object sender, EventArgs e)
        {
            string idArticulo = ((Button)sender).CommandArgument;
        }
    }
}