using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaz
{
    public partial class Salida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Session.Clear();
                Session.Abandon();
                
            }
        }

        protected void btnVolverInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx",false); // Redirigir al login
        }
    }
}