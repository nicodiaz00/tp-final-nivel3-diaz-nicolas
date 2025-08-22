using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listarCategoria()
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            List<Categoria> listaCategoria = new List<Categoria>();


            try
            {
                accesoDatos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)accesoDatos.Lector["Id"];
                    categoria.DescripcionCategoria = (string)accesoDatos.Lector["Descripcion"];
                    listaCategoria.Add(categoria);

                }
                return listaCategoria;
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
