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

                lblMensaje.Text = "¡El artículo se cargó correctamente!";
                pnlMensaje.Visible = true;

                btnCargarArticulo.Enabled = false;
                btnCargarArticulo.CssClass = "btn-cargar-articulo disabled";
                btnCancelarArticulo.Enabled = false;
                btnCancelarArticulo.CssClass = "btn-cancelar-articulo disabled";
                txtNombre.Enabled = false;
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = false;
                txtPrecio.Enabled = false;
                txtImagen.Enabled = false;
                ddlMarca.Enabled = false;
                ddlCategoria.Enabled = false;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                pnlMensaje.Visible = true;
            }                  
        }
        protected void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtImagen.Text = "";
            ddlMarca.SelectedIndex = 0;
            ddlCategoria.SelectedIndex = 0;
        }
        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = txtImagen.Text.Trim();
        }
        protected void btnAceptarMensaje_Click(object sender, EventArgs e)
        {
            pnlMensaje.Visible = false;
            btnCargarArticulo.Enabled = true;
            btnCargarArticulo.CssClass = "btn-cargar-articulo";
            btnCancelarArticulo.Enabled = true;
            btnCancelarArticulo.CssClass = "btn-cancelar-articulo";
            txtNombre.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtImagen.Enabled = true;
            ddlMarca.Enabled = true;
            ddlCategoria.Enabled = true;

            // Limpiar los campos si querés
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtImagen.Text = "";
            ddlMarca.SelectedIndex = 0;
            ddlCategoria.SelectedIndex = 0;

            Response.Redirect("Default.aspx", false);
        }
    }
}