using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaz
{
    public partial class masterDefault : System.Web.UI.MasterPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["usuario"] != null)
            {
                btnMenuUser.Text = "Cerrar Sesion";
                btnMenuUser.CssClass = "btn-cerrar-sesion";
                btnRegistrarse.Text = "Mi cuenta";
                btnRegistrarse.CssClass = "btn-mi-cuenta";


            }
        }








        protected void btnMenuUser_Click(object sender, EventArgs e)
        {
            if (btnMenuUser.Text == "Inicia Sesion")
            {
                Response.Redirect("MenuUsuario.aspx", false);
            } else
            {
                Session["usuario"] = null;
                Response.Redirect("error.aspx");
                
            }
            
            
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if(btnRegistrarse.Text == "Registrarse")
            {
                Response.Redirect("Registro.aspx", false);
            }
            else
            {
                Response.Redirect("MenuUsuario.aspx", false);
            }
        }
    }
}