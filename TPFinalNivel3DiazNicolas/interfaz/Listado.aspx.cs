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
                btnBuscar.Enabled = false;
                btnBuscar.CssClass = "btn-busqueda-desactivada";
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
                FiltroAvanzado = checkBoxBusquedaAvanzada.Checked;
                txtBusqueda.Enabled = !FiltroAvanzado;
                ddlCampo.Enabled = true;
                ddlCriterio.Enabled = true;
                txtFiltro.Enabled = true;
                btnBuscar.Enabled = true;
                btnBuscar.CssClass = "btn-buscar-avanzado";
            }
            else
            {
                ddlCampo.Enabled = false;
                ddlCriterio.Enabled = false;
                txtFiltro.Enabled = false;
                btnBuscar.Enabled = false;
                btnBuscar.CssClass = "btn-busqueda-desactivada";
                
                
            }/*
            FiltroAvanzado = checkBoxBusquedaAvanzada.Checked;
            txtBusqueda.Enabled = !FiltroAvanzado;
            */
            
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterio.Items.Clear();   
            if (ddlCampo.SelectedItem.ToString() == "Codigo" || ddlCampo.SelectedItem.ToString() == "Nombre")
            {
                ddlCriterio.Items.Add("Empieza");
                ddlCriterio.Items.Add("Contiene");
                ddlCriterio.Items.Add("Termina");
            }
            else
            {
                ddlCriterio.Items.Add("Igual a");
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("Menor a");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                dgvArticulos.DataSource = articuloNegocio.filtrarArticulo(ddlCampo.SelectedItem.ToString(), ddlCriterio.SelectedItem.ToString(), txtFiltro.Text);
                dgvArticulos.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
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