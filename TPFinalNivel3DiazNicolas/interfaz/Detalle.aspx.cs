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
    public partial class Detalle : System.Web.UI.Page
    {
        private Articulo articulo;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string idArticulo = Request.QueryString["idArticulo"];
                if (!string.IsNullOrEmpty(idArticulo))
                {
                    try
                    {   
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                        
                        articulo = articuloNegocio.seleccionarArticulo(idArticulo);

                        if(articulo != null)
                        {
                            detalleArticulo.DataSource = new List<Articulo> { articulo };
                            detalleArticulo.DataBind();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }


        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }
    }
}