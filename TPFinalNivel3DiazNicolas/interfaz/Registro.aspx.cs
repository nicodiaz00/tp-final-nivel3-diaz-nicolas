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

        public string urlPerfil = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQl_3sn9SlQEcL6AhZ1ASxPzR7mu6Xzf9Hacw&s";
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                usuario = null;              
            }
		}
        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                if (!usuarioNegocio.usuarioRegistrado(txtEmail.Text))
                {
                    Usuario nuevoUsuario = Helper.Helper.crearUsuario(txtEmail.Text, txtContrasena.Text, txtNombre.Text, txtApellido.Text, urlPerfil);

                    usuarioNegocio.registrarUsuario(nuevoUsuario);
                }
                else{
                    lblRegistrado.Text = "Ya te registraste ";
                }
                              
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}