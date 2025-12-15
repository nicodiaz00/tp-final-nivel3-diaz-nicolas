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
    public partial class Listado : System.Web.UI.Page
    {
        public bool FiltroAvanzado {  get; set; }

        private void CargarCampos()
        {
            ddlCampo.Items.Clear();
            ddlCampo.Items.Add(new ListItem("Codigo", "Codigo"));
            ddlCampo.Items.Add(new ListItem("Nombre", "Nombre"));
            ddlCampo.Items.Add(new ListItem("Precio", "Precio"));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FiltroAvanzado = false;
                dgvArticulos.DataSource = Session["listadoArticulo"];
                dgvArticulos.DataBind();
                ddlCampo.Enabled = false;
                ddlCriterio.Enabled = false;
                txtFiltro.Enabled = false;
                /*btnBuscar.Enabled = false;
                btnBuscar.CssClass = "btn-busqueda-desactivada";*/
            }         
        }
        protected void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = (List<Articulo>)Session["listadoArticulo"];
            List<Articulo> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper()));
            dgvArticulos.DataSource= listaFiltrada;
            dgvArticulos.DataBind();
        }

        protected void checkBoxBusquedaAvanzada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBusquedaAvanzada.Checked)
            {

                dgvArticulos.DataSource = Session["listadoArticulo"];
                dgvArticulos.DataBind();
                FiltroAvanzado = checkBoxBusquedaAvanzada.Checked;
                txtBusqueda.Text = "";
                txtBusqueda.Enabled = !FiltroAvanzado;
                //ddlCampo.Items.Clear();
                ddlCampo.Enabled = true;
                ddlCriterio.Enabled = true;
                txtFiltro.Enabled = true;
                btnBuscar.Enabled = true;
                btnBuscar.CssClass = "btn-buscar-avanzado";
                CargarCampos();
            }
            else
            {
                dgvArticulos.DataSource = Session["listadoArticulo"];
                dgvArticulos.DataBind();
                ddlCampo.Items.Clear();
                ddlCriterio.Items.Clear();
                ddlCampo.Enabled = false;
                ddlCriterio.Enabled = false;
                txtFiltro.Enabled = false;
                btnBuscar.Enabled = false;
                txtBusqueda.Enabled = !FiltroAvanzado;
                txtFiltro.Text = "";
            }         
        }
        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterio.Items.Clear();
            txtBusqueda.Text = "";
            txtFiltro.Text = "";
            if (ddlCampo.SelectedItem.Text == "Codigo" || ddlCampo.SelectedItem.Text == "Nombre")
            {
                txtFiltro.TextMode = System.Web.UI.WebControls.TextBoxMode.SingleLine;
                regexValidator.ValidationExpression = ".*";
                regexValidator.IsValid = true;

                ddlCriterio.Items.Add("Empieza");
                ddlCriterio.Items.Add("Contiene");
                ddlCriterio.Items.Add("Termina");
            }
            else
            {
                txtFiltro.TextMode = System.Web.UI.WebControls.TextBoxMode.Number;
                regexValidator.ValidationExpression = "^[0-9]+(\\.[0-9]+)?$";
                regexValidator.ErrorMessage = "Solo se permiten números y puntos.";

                ddlCriterio.Items.Add("Igual a");
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("Menor a");
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {           
            if (!checkBoxBusquedaAvanzada.Checked)
            {
                List<Articulo> lista = (List<Articulo>)Session["listadoArticulo"];
                List<Articulo> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper()));
                dgvArticulos.DataSource = listaFiltrada;
                dgvArticulos.DataBind();          
            }
            else
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                try
                {
                    dgvArticulos.DataSource = articuloNegocio.filtrarArticulo(ddlCampo.SelectedItem.ToString(), ddlCriterio.SelectedItem.ToString(), txtFiltro.Text.ToString());
                    dgvArticulos.DataBind();
                }
                catch (Exception ex)
                {
                    Session.Add("error", ex);
                    throw;
                }
            }     
        }
        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {            
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                string idArticulo = dgvArticulos.SelectedDataKey.Value.ToString();

                if(articuloNegocio.seleccionarArticulo(idArticulo) != null) {
                    Session["articuloEditar"] =(Articulo)articuloNegocio.seleccionarArticulo(idArticulo);
                    Response.Redirect("Editar.aspx");
                }               
            }
            catch (Exception)
            {
                throw;
            }        
        }
        protected void dgvArticulos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvArticulos.PageIndex = e.NewPageIndex;

            if (Session["listadoArticulo"] != null)
            {
                dgvArticulos.DataSource = Session["listadoArticulo"];
                dgvArticulos.DataBind();
            }
        }
    }
}