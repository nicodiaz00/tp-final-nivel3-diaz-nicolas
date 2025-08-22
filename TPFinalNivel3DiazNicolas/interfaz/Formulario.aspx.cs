using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace interfaz
{
    public partial class Formulario : System.Web.UI.Page
    {
        private List<Marca> listadoMarca { get; set; }
        private List<Categoria> listadoCategoria {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtId.Enabled = false;

                try
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();

                    listadoMarca = new List<Marca>();
                    listadoMarca = marcaNegocio.listarMarcas();

                    ddlMarca.DataSource = listadoMarca;
                    ddlMarca.DataTextField = "DescripcionMarca";
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataBind();

                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    listadoCategoria = new List<Categoria>();
                    listadoCategoria = categoriaNegocio.listarCategoria();

                    ddlCategoria.DataSource = listadoCategoria;
                    ddlCategoria.DataTextField = "DescripcionCategoria";
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataBind();

                }
                catch (Exception)
                {

                    throw;
                }
                






            }
        }

        protected void btnCargarArticulo_Click(object sender, EventArgs e)
        {
            int idMarca = Convert.ToInt32(ddlMarca.SelectedValue);
            int idCategoria = Convert.ToInt32(ddlCategoria.SelectedValue);
            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                articuloNegocio.crearArticulo(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, idMarca, idCategoria, txtImagen.Text, precio);

            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        protected void btnCancelarArticulo_Click(object sender, EventArgs e)
        {

        }

        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = txtImagen.Text.Trim();
        }
    }
}