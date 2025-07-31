using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace interfaz
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Inicio", "inicio", "~/Default.aspx");
            routes.MapPageRoute("Login", "login", "~/MenuUsuario.aspx");
            // Podés agregar más rutas como esta:
            // routes.MapPageRoute("Contacto", "contacto", "~/Contacto.aspx");
        }
    }
}