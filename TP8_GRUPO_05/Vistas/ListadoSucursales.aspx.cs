using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbAgregarSucursal_Click(object sender, EventArgs e)
        {
            Server.Transfer("AgregarSucursal.aspx");
        }

        protected void lbEliminarSucursal0_Click(object sender, EventArgs e)
        {
            Server.Transfer("EliminarSucursales.aspx");
        }
    }
}