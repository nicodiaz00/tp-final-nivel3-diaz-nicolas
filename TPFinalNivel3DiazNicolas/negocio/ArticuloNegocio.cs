using dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        
        public List<Articulo> listarArticulo()
        {   
            
            List<Articulo> listaArticulo= new List<Articulo>();
            AccesoDatos accesodatos = new AccesoDatos();
            try
            {
                accesodatos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion,A.IdMarca,A.IdCategoria, A.ImagenUrl, A.Precio, C.Descripcion as 'Categoria', M.Descripcion as 'Marca' from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                accesodatos.ejecutarLectura();

                while (accesodatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesodatos.Lector["Id"];
                    articulo.Codigo = (string)accesodatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesodatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesodatos.Lector["Descripcion"];
                    articulo.Precio = Math.Round((decimal)accesodatos.Lector["Precio"],2);
                    articulo.ImagenUrl = (string)accesodatos.Lector["ImagenUrl"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesodatos.Lector["IdMarca"];
                    articulo.Marca.DescripcionMarca = (string)accesodatos.Lector["Marca"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesodatos.Lector["IdCategoria"];
                    articulo.Categoria.DescripcionCategoria = (string)accesodatos.Lector["Categoria"];

                    listaArticulo.Add(articulo);
                    

                }
                return listaArticulo;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                accesodatos.cerrarConexion();
            }
            
        }
        public List<Articulo>filtrarArticulo(string campo,string criterio,string filtro)
        {
            List<Articulo>listaArticulos = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                string consulta = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion as Marca, C.Descripcion as Categoria, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id and ";
                if (campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza":
                            consulta += "A.Codigo like'" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "A.Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Codigo like '%" + filtro + "%'";
                            break;
                    }


                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {

                        case "Empieza":
                            consulta += "A.Nombre like'" + filtro + "%'";
                            break;
                        case "Termina":
                            consulta += "A.Nombre like'%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "A.Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "A.Precio < " + filtro;
                            break;
                        case "Igual a":
                            consulta += "A.Precio = " + filtro;
                            break;
                    }
                }
                accesoDatos.setearConsulta(consulta);
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Articulo articuloAuxiliar = new Articulo();
                    articuloAuxiliar.Id = (int)accesoDatos.Lector["Id"];
                    articuloAuxiliar.Codigo = (string)accesoDatos.Lector["Codigo"];
                    articuloAuxiliar.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articuloAuxiliar.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                    {
                        articuloAuxiliar.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    }
                    decimal precio = (decimal)accesoDatos.Lector["Precio"];
                    decimal precioRedondeado = (Math.Round(precio, 0));
                    articuloAuxiliar.Precio = precioRedondeado;
                    articuloAuxiliar.Marca = new Marca();
                    articuloAuxiliar.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    articuloAuxiliar.Marca.DescripcionMarca = (string)accesoDatos.Lector["Marca"];

                    articuloAuxiliar.Categoria = new Categoria();
                    articuloAuxiliar.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    articuloAuxiliar.Categoria.DescripcionCategoria = (string)accesoDatos.Lector["Categoria"];


                    listaArticulos.Add(articuloAuxiliar);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ;
            }
        }
        public Articulo seleccionarArticulo(string id)
        {
            Articulo articulo = null;

            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion as Marca, C.Descripcion as Categoria, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id and A.Id= @id");
                accesoDatos.setearParametro("@id", id);
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                     articulo = new Articulo();


                    
                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.Codigo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                    {
                        articulo.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    }
                    decimal precio = (decimal)accesoDatos.Lector["Precio"];
                    decimal precioRedondeado = (Math.Round(precio, 0));
                    articulo.Precio = precioRedondeado;
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    articulo.Marca.DescripcionMarca = (string)accesoDatos.Lector["Marca"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    articulo.Categoria.DescripcionCategoria = (string)accesoDatos.Lector["Categoria"];

                    
                }

                return articulo;
            }

            catch (Exception ex)
            {
                throw;
                
            }

        }
    }
}
