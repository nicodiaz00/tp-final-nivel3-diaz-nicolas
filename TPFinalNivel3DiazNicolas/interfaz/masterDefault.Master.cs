﻿using dominio;
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

            var usuario = Session["usuario"] as dominio.Usuario;

           

            // Menú admin
            menuNavegacion.Visible = (usuario != null && usuario.TipoUsuario == dominio.TipoUsuario.ADMIN);

            // Menu login/cuenta siempre visible
            menuLogin.Visible = true;

            if (usuario != null)
            {
                btnMenuUser.Text = "Cerrar Sesion";
                btnMenuUser.CssClass = "btn-cerrar-sesion";
                btnRegistrarse.Text = "Mi cuenta";
                btnRegistrarse.CssClass = "btn-mi-cuenta";
            }
            else
            {
                btnMenuUser.Text = "Inicia Sesion";
                btnMenuUser.CssClass = "button-a";
                btnRegistrarse.Text = "Registrarse";
                btnRegistrarse.CssClass = "button-a";
            }
        }








        protected void btnMenuUser_Click(object sender, EventArgs e)
        {
            if (btnMenuUser.Text == "Inicia Sesion")
            {
                Response.Redirect("MenuUsuario.aspx", false);
            }
            else
            {
                Session["usuario"] = null;
                Response.Redirect("error.aspx");

            }


        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (btnRegistrarse.Text == "Registrarse")
            {
                Response.Redirect("Registro.aspx", false);
            }
            else
            {
                Response.Redirect(GetRouteUrl("login", null), false);
                /*Response.Redirect("MenuUsuario.aspx", false);*/
            }
        }
    }
}