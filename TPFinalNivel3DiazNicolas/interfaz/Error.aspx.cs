﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaz
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string mensaje = Request.QueryString["mensaje"];

                if(mensaje == "-1")
                {
                    lblError.Text = "Debes iniciar Sesion para agregar articulos a tus favoritos.";
                }
                if (Session["error"] != null)
                {
                    lblError.Text = Session["error"].ToString();
                }
            }
            
        }
    }
}