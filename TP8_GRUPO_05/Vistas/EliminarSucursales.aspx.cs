using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbAgregarSucursal_Click(object sender, EventArgs e)
        {
            Server.Transfer("AgregarSucursal.aspx");
        }

        protected void lbListadoDeSucursales_Click(object sender, EventArgs e)
        {
            Server.Transfer("ListadoSucursales.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            panelConfirmacion.Visible = false; 

            if (string.IsNullOrWhiteSpace(txtIngresarId.Text))
            {
                lblMensaje.Text = "Debe ingresar un valor numérico.";
                return;
            }

            
            SucursalesNeg sucursalNeg = new SucursalesNeg();
            DataTable dt = sucursalNeg.filtrarPorId(txtIngresarId.Text);

            if (dt == null)
            {
                lblMensaje.Text = "El ID ingresado no es válido.";
            }
            else if (dt.Rows.Count == 0)
            {
                lblMensaje.Text = "No existe una sucursal con ese ID.";
            }
            else
            {
                
                lblNombre.Text = dt.Rows[0]["Nombre"].ToString();
                lblDescripcion.Text = dt.Rows[0]["Descripción"].ToString();
                lblDireccion.Text = dt.Rows[0]["Dirección"].ToString();

                
                panelConfirmacion.Visible = true;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            SucursalesNeg sucursalesNeg = new SucursalesNeg();

           
            int confir = sucursalesNeg.eliminarSucursal(txtIngresarId.Text);

            if (confir == 1)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con éxito.";
            }
            else
            {
                lblMensaje.Text = "Error al intentar eliminar la sucursal.";
            }

            panelConfirmacion.Visible = false;
            txtIngresarId.Text = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            panelConfirmacion.Visible = false;
            txtIngresarId.Text = "";
            lblMensaje.Text = "Eliminación cancelada.";
        }

    }
}