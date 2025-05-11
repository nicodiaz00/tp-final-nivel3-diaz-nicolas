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
    public partial class MenuUsuario : System.Web.UI.Page
    {
        public Usuario usuarioAux {  get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    usuarioAux = (Usuario)Session["usuario"];
                    usuarioTxt.Text = usuarioAux.Nombre;
                    apellidoTxt.Text = usuarioAux.Apellido;
                    emailTxt.Text = usuarioAux.Email;
                   perfilTxt.Text = usuarioAux.UrlImagen.ToString();
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void btnGestion_Click(object sender, EventArgs e)
        {
            Response.Redirect("listado.aspx", false);
        }

        protected void btnEditarPerfil_Click(object sender, EventArgs e)
        {
           
        }
    }
}