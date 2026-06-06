using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    internal class DatosSucursal
    {
        AccesoDatos acceso = new AccesoDatos();

        public int agregarSucursal(Sucursal sucursal)
        {
            sucursal.IdSucursal = acceso.ObtenerMaximo("SELECT max(idSucursal) FROM Sucursales") + 1;
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, sucursal);
            return acceso.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.IdSucursal;
            SqlParametros = Comando.Parameters.Add("@NOMBRESUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.Nombre_Sucursal;
        }

    }
}
