using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaz
{
	public partial class Registro1 : System.Web.UI.Page
	{
        public  Usuario usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                usuario = null;
            }
		}

        protected void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            if (IsPostBack)
            {
                usuario = usuarioNegocio.loguearse(txtEmailUsuario.Text, txtContrasenaUsuario.Text);
                if (usuario != null)
                {
                    Session["usuario"] = usuario;
                    Response.Redirect("MenuUsuario.aspx", false);
                }
                else
                {
                    lblLogueado.Text = Helper.Helper.userNoregistrado();

                }
            }
            
            
                
            
        }
    }
}