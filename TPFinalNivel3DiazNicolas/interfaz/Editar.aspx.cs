using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace interfaz
{
    public partial class Editar : System.Web.UI.Page
    {
        private List<Marca> listadoMarca { get; set; }
        private List<Categoria> listadoCategoria { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               if(!IsPostBack) {
                    Articulo articulo = (Articulo)Session["articuloEditar"];
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    
                    listadoMarca = new List<Marca>();
                    listadoMarca = marcaNegocio.listarMarcas();

                    listadoCategoria = categoriaNegocio.listarCategoria();

                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    ddlMarca.DataSource = listadoMarca;
                    ddlMarca.DataTextField = "DescripcionMarca";
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataBind();
                    ddlMarca.SelectedValue = articulo.Marca.Id.ToString();

                    ddlCategoria.DataSource = listadoCategoria;
                    ddlCategoria.DataSource = listadoCategoria;
                    ddlCategoria.DataTextField = "DescripcionCategoria";
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataBind();
                    ddlCategoria.SelectedValue = articulo.Categoria.Id.ToString();  



                    txtUrlImagen.Text = articulo.ImagenUrl;
                    txtPrecio.Text = articulo.Precio.ToString();
                    aspImageEditarArticulo.ImageUrl = articulo.ImagenUrl;
                }
            }
            catch (Exception)
            {

                throw;
            }
            


        }

        protected void btnGuardarEdicion_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelarEdicion_Click(object sender, EventArgs e)
        {

        }

        protected void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            aspImageEditarArticulo.ImageUrl = txtUrlImagen.Text.Trim();
        }
    }
}