using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaz
{
    public partial class Validacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ErrorMensaje"] != null)
            {
                lblValidacion.Text = Session["ErrorMensaje"].ToString();
                Session.Remove("ErrorMensaje"); // Limpiar si ya no lo necesitás
            }
           
        }

        protected void btVolverInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx",false);
        }
    }
}