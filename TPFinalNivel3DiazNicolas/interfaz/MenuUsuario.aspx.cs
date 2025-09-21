﻿using System;
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
        public Usuario usuarioAux { get; set; }

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
                    contrasena.Text = usuarioAux.Pass;
                    perfilTxt.Text = usuarioAux.UrlImagen.ToString();
                    emailPassTxt.Text = usuarioAux.Pass;
                    aspImagePerfil.ImageUrl = usuarioAux.UrlImagen;
                    usuarioTxt.Enabled = false;
                    apellidoTxt.Enabled = false;
                    emailTxt.Enabled = false;
                    perfilTxt.Enabled = false;
                    contrasena.Enabled = false;

                }
            }
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
       
        protected void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            
            btnEditarPerfil.Enabled = false;
            btnGuardarPerfil.Enabled = true;
            btnEditarPerfil.CssClass = "btn-panel-guardar";
            
            btnGuardarPerfil.CssClass = "button-panel-usuario";
            usuarioTxt.Enabled = true;
            apellidoTxt.Enabled = true;
            
            perfilTxt.Enabled = true;
            contrasena.Enabled = true;
        }
        protected void btnIniciarS_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            if (IsPostBack)
            {
                if(string.IsNullOrEmpty(emailUserTxt.Text)|| string.IsNullOrEmpty(emailPassTxt.Text))
                {
                    string mensaje = "Los campos Usuario/Contraseña no pueden estar vacios.";
                    Response.Redirect("Error.aspx?mensaje=" + mensaje);
                }
                else
                {
                    usuarioAux = usuarioNegocio.loguearse(emailUserTxt.Text, emailPassTxt.Text);
                    if (usuarioAux != null)
                    {
                        Session["usuario"] = usuarioAux;
                        Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        Session["ErrorMensaje"] = "Usuario o contraseña incorrectos";
                        Response.Redirect("Validacion.aspx", false);
                    }
                }               
            }
        }
        protected void btnGuardarPerfil_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            usuarioAux = (Usuario)Session["usuario"];

            try
            {
                usuarioAux.Nombre = usuarioTxt.Text;
                usuarioAux.Apellido = apellidoTxt.Text;
                usuarioAux.Email = emailTxt.Text;
                usuarioAux.Pass = contrasena.Text;
                usuarioAux.UrlImagen = perfilTxt.Text;
                usuarioNegocio.actualizarPerfil(usuarioAux);

                string mensaje = "Perfil actualizado";
                Response.Redirect("Validacion.aspx?mensaje=" + mensaje);


            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void perfilTxt_TextChanged(object sender, EventArgs e)
        {
            aspImagePerfil.ImageUrl = perfilTxt.Text.Trim();
        }
    }
}