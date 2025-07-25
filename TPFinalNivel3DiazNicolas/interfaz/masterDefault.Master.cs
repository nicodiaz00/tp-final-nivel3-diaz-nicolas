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

            if (Session["usuario"] == null)
            {
                btnMenuUser.Text = "Inicia Sesion";
            }
            else
            {
                btnMenuUser.Text = "Cerrar Sesion";
                btnMenuUser.CssClass = "btn-cerrar-sesion";
            }
        }








        protected void btnMenuUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuUsuario.aspx", false);
        }
            
    }
}