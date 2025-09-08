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
            System.Web.UI.ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new System.Web.UI.ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-1.10.2.js",
                DebugPath = "~/Scripts/jquery-1.10.2.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.js"
            });
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