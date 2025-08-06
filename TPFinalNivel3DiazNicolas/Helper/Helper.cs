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

        public static Articulo crearArticulo(string codigo, string nombre, string descripcion, string marca, string categoria, decimal precio, string imagen )
        {
            Articulo articulo = new Articulo();
            articulo.Codigo = codigo;
            articulo.Nombre = nombre;
            articulo.Descripcion = descripcion;
            articulo.Marca.DescripcionMarca = marca;
            articulo.Categoria.DescripcionCategoria = categoria;
            articulo.Precio = precio;
            articulo.ImagenUrl = imagen;



            return articulo;

        }
    }


}
