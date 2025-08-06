using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listarMarcas()
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            List<Marca> listaMarca = new List<Marca>();

            try
            {
                accesoDatos.setearConsulta("select Id, Descripcion from MARCAS");
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Marca marca = new Marca();

                    marca.Id = (int)accesoDatos.Lector["Id"];
                    marca.DescripcionMarca = (string)accesoDatos.Lector["Descripcion"];

                    listaMarca.Add(marca);

                }
                return listaMarca;
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
