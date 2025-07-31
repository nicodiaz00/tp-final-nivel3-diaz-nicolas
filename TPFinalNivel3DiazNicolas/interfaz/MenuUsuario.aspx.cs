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
            if (!Page.IsPostBack && Request.Url.AbsolutePath.ToLower().Contains("MenuUsuario.aspx"))
            {
                Response.Redirect("~/login");
            }
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {

                    usuarioAux = (Usuario)Session["usuario"];
                    usuarioTxt.Text = usuarioAux.Nombre;
                    apellidoTxt.Text = usuarioAux.Apellido;
                    emailTxt.Text = usuarioAux.Email;
                   perfilTxt.Text = usuarioAux.UrlImagen.ToString();

                    usuarioTxt.Enabled = false;
                    apellidoTxt.Enabled= false;
                    emailTxt.Enabled= false;

                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnGestion_Click(object sender, EventArgs e)
        {
            Response.Redirect("listado.aspx", false);
        }

        protected void btnEditarPerfil_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnIniciarS_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            if (IsPostBack)
            {
                usuarioAux = usuarioNegocio.loguearse(emailUserTxt.Text, emailPassTxt.Text);
                if (usuarioAux != null)
                {
                    Session["usuario"] = usuarioAux;
                    Response.Redirect("MenuUsuario.aspx", false);
                }
                else
                {
                    

                }
            }
        }
    }
}