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
                
                try
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    Listado = negocio.listarArticulo();
                    Session.Add("listadoArticulo", Listado);
                    repArticulo.DataSource = Listado;
                    repArticulo.DataBind();                
                }
                catch (Exception ex)
                {
                    Session.Add("error", ex.ToString());
                    Response.Redirect("Error.aspx");                  
                }               
            }           
        }
        protected void btnIdArticulo_Click(object sender, EventArgs e)
        {
            if(Session["usuario"]!= null)
            {
                string idArticulo = ((Button)sender).CommandArgument;
            }
            else
            {
                string mensaje = "Debes iniciar Sesion para agregar articulos a tus favoritos.";
                Response.Redirect("Error.aspx?mensaje=" + mensaje);
            }
            
        }
        protected void btnFavorito_Click(object sender, EventArgs e)
        {
            string idArticulo = ((Button)sender).CommandArgument;

            Response.Redirect("Detalle.aspx?idArticulo=" + idArticulo);
        }
    }
}