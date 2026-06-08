using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Data;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        SucursalesNeg neg = new SucursalesNeg();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProvincias();
            }
        }
        private void CargarProvincias()
        {
            DataTable dt = neg.getProvincias();
            ddlProvincia.DataSource = dt;

            ddlProvincia.DataTextField = "DescripcionProvincia"; 
            ddlProvincia.DataValueField = "Id_Provincia";       

            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
        }

        private void LimpiarControles()
        {
            txtNombreSucursal.Text = string.Empty;
            txtDescripción.Text = string.Empty;
            txtDirección.Text = string.Empty;
            ddlProvincia.SelectedIndex = 0;
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

            
            if (string.IsNullOrWhiteSpace(txtNombreSucursal.Text) ||
                string.IsNullOrWhiteSpace(txtDescripción.Text) ||
                string.IsNullOrWhiteSpace(txtDirección.Text))
            {
                lblConfirmacion.Text = "Todos los campos son obligatorios.";
                lblConfirmacion.ForeColor = System.Drawing.Color.Red;
                return; 
            }

            if (ddlProvincia.SelectedValue == "0")
            {
                lblConfirmacion.Text = "Debe seleccionar una provincia válida.";
                lblConfirmacion.ForeColor = System.Drawing.Color.Red;
                return;
            }
            
            if (neg.verificarExistencia(txtNombreSucursal.Text, txtDirección.Text))
            {
                lblConfirmacion.Text = "Ya existe una sucursal con ese nombre en esa misma dirección.";
                lblConfirmacion.ForeColor = System.Drawing.Color.Red;
                return; 
            }

           
            Sucursal sucursalObj = new Sucursal(txtNombreSucursal.Text,txtDescripción.Text,
                Convert.ToInt32(ddlProvincia.SelectedValue),txtDirección.Text);

            if (neg.AgregarSucursal(sucursalObj))
            {
                lblConfirmacion.Text = "La sucursal se ha agregado con éxito"; 
                lblConfirmacion.ForeColor = System.Drawing.Color.Green;
                LimpiarControles(); 
            }
            else
            {
                lblConfirmacion.Text = "No se pudo agregar sucursal";
                lblConfirmacion.ForeColor = System.Drawing.Color.Red;
            }

        }

        
    }
}