﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class UsuarioNegocio
    {
        private string urlDefault = "https://static.vecteezy.com/system/resources/previews/013/042/571/original/default-avatar-profile-icon-social-media-user-photo-in-flat-style-vector.jpg";
        public Usuario loguearse (string email, string pass)
        {
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setearConsulta("select Id, email, pass, nombre, apellido, urlImagenPerfil, admin from USERS where email = @email and pass = @pass");
                datos.setearParametro("@email", email );
                datos.setearParametro("@pass", pass);


                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuario usuario = new Usuario ();

                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.Email = (string)datos.Lector["email"];
                    usuario.Pass = (string)datos.Lector["pass"];
                    if(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("nombre")))
                    {
                        usuario.Nombre = "";
                    }
                    else
                    {
                        usuario.Nombre = (string)datos.Lector["nombre"];

                    }
                    if(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("apellido")))
                    {
                        usuario.Apellido = "";
                    }
                    else
                    {
                        usuario.Apellido = (string)datos.Lector["apellido"];
                    }
                    if (datos.Lector.IsDBNull(datos.Lector.GetOrdinal("urlImagenPerfil")))
                    {
                        usuario.UrlImagen = urlDefault;
                    }
                    else
                    {
                        usuario.UrlImagen = (string)datos.Lector["urlImagenPerfil"];
                    }

                    
                     ;
                    int userValue = Convert.ToInt32(datos.Lector["admin"]);
                    usuario.TipoUsuario = (TipoUsuario)userValue;
                    
                     
                    return usuario;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void registrarUsuario(Usuario usuarioNuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("insert into USERS (email,pass,nombre, apellido, urlImagenPerfil, admin) values( @email,@pass,@nombre,@apellido,@urlImagenPerfil,@admin)");
                accesoDatos.setearParametro("@email", usuarioNuevo.Email);
                accesoDatos.setearParametro("@pass", usuarioNuevo.Pass);
                accesoDatos.setearParametro("@nombre", usuarioNuevo.Nombre);
                accesoDatos.setearParametro("@apellido", usuarioNuevo.Apellido);
                accesoDatos.setearParametro("@urlImagenPerfil", usuarioNuevo.UrlImagen);
                accesoDatos.setearParametro("@admin", usuarioNuevo.TipoUsuario);

                accesoDatos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public bool usuarioRegistrado(string email)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("select * from USERS where email = @email");
                accesoDatos.setearParametro("@email", email);
                accesoDatos.ejecutarLectura();

                if (accesoDatos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

                

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
