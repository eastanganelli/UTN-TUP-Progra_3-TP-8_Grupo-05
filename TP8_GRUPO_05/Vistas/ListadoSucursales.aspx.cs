using Negocio;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarSucursales();
                CargarProvinciasFiltro();
            }
        }

        public void CargarSucursales()
        {
            Sucursales mis_sucursales = new Sucursales();
            gvSucursal0.DataSource = mis_sucursales.getSucursales();
            gvSucursal0.DataBind();

            lblContador.Text = "Se encontraron " + gvSucursal0.Rows.Count + " sucursales en total.";
        }

        private void CargarProvinciasFiltro()
        {

            SucursalesNeg biz = new SucursalesNeg();

            DataTable dt = biz.getProvincias();
            ddlProvinciaFiltro.DataSource = dt;
            ddlProvinciaFiltro.DataTextField = "DescripcionProvincia";
            ddlProvinciaFiltro.DataValueField = "Id_Provincia";
            ddlProvinciaFiltro.DataBind();

            ddlProvinciaFiltro.Items.Insert(0, new ListItem("--Todas las Provincias--", "0"));
        }

        protected void ddlProvinciaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            int idSeleccionado = Convert.ToInt32(ddlProvinciaFiltro.SelectedValue);

            if (idSeleccionado == 0)
            {
                CargarSucursales();
            }
            else
            {

                SucursalesNeg biz = new SucursalesNeg();

                DataTable resultado = biz.listarPorProvincia(idSeleccionado);
                gvSucursal0.DataSource = resultado;
                gvSucursal0.DataBind();

                lblContador.Text = "Se encontraron " + resultado.Rows.Count + " sucursales en esta provincia.";

                if (resultado.Rows.Count == 0)
                {
                    lblMensaje.Text = "No existen sucursales registradas en la provincia seleccionada.";
                }
            }
        }

        protected void lbAgregarSucursal_Click(object sender, EventArgs e)
        {
            Server.Transfer("AgregarSucursal.aspx");
        }

        protected void lbEliminarSucursal0_Click(object sender, EventArgs e)
        {
            Server.Transfer("EliminarSucursales.aspx");
        }

        protected void btnMostrarTodos0_Click(object sender, EventArgs e)
        {
            CargarSucursales();
            ddlProvinciaFiltro.SelectedIndex = 0;
            txtIdSucursal0.Text = "";
        }

        protected void btnFiltrar0_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            SucursalesNeg sucursalesNeg = new SucursalesNeg();

            DataTable resultado = sucursalesNeg.filtrarPorId(txtIdSucursal0.Text);
            if (resultado == null)
            {
                CargarSucursales();
                lblMensaje.Text = "Debe ingresar un valor numérico.";
            }
            else if (resultado.Rows.Count == 0)
            {
                CargarSucursales();
                lblMensaje.Text = "No existe una sucursal con ese ID.";
            }
            else
            {
                gvSucursal0.DataSource = resultado;
                gvSucursal0.DataBind();
            }

            txtIdSucursal0.Text = "";

        }
    }
}