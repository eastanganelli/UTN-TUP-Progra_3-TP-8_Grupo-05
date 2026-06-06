using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        SucursalesNeg neg = new SucursalesNeg();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbListadoDeSucursales_Click(object sender, EventArgs e)
        {
            Server.Transfer("ListadoSucursales.aspx");
        }

        protected void lbEliminarSucursal_Click(object sender, EventArgs e)
        {
            Server.Transfer("EliminarSucursales.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal(txtNombreSucursal.Text, txtDescripción.Text, Convert.ToInt32(ddlProvincia.SelectedValue), txtDirección.Text);
           
            if (neg.AgregarSucursal(sucursal))
            {
                lblConfirmacion.Text = "Sucursal agregada con exito";
            }
            else
            {
                lblConfirmacion.Text = "No se puedo agregar sucursal";
            }
        }
    }
}