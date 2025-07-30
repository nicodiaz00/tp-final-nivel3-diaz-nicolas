using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public abstract class Helper
    {
        public static string userNoregistrado()
        {
            string mensaje = " No estas registrado";
            return mensaje;
        }

        public static  Usuario crearUsuario(string email,string pass, string nombre, string apellido,string urlPerfil)
        {
            
                Usuario usuario = new Usuario();
                
                usuario.Email = email;
                usuario.Pass = pass;
                usuario.Nombre = nombre;
                usuario.Apellido = apellido;
                usuario.UrlImagen = urlPerfil;
                usuario.TipoUsuario = TipoUsuario.NORMAL;

                return usuario;         
        }
    }


}
