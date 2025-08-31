using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaz
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Articulo articulo = (Articulo)Session["articuloEditar"];
                
                txtNombre.Text = articulo.Nombre;
            }


        }

        protected void btnGuardarEdicion_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelarEdicion_Click(object sender, EventArgs e)
        {

        }
    }
}