using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
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
            SucursalesNeg sucursalesNeg = new SucursalesNeg();
            int confir = sucursalesNeg.eliminarSucursal(txtIngresarId.Text);
            if (confir == 1)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con éxito";
            }
            else if (confir == 2)
            {
                lblMensaje.Text = "El ID ingresado no es válido";
            }
            else if (confir == 0)
            {
                lblMensaje.Text = "Error al eliminar la sucursal";
            }


        }
    }
}