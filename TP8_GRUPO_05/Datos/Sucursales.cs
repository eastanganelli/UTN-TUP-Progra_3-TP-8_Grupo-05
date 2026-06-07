using Datos;
using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Negocio {
    public class Sucursales {
        AccesoDatos conexion = new AccesoDatos();
        public DataTable getSucursales()
        {
            const string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, " +
                "DescripcionSucursal AS Descripción, " +
                "Provincia.DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección FROM Sucursal " +
                "INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
            DataTable tabla = conexion.ObtenerTabla(consulta, "Sucursales");
            return tabla;
        }

        public DataTable getSucursalPorId(int id)
        {
            string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripción, Provincia.DescripcionProvincia AS Provincia, DireccionSucursal " +
                "AS Dirección FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia WHERE Id_Sucursal = " + id;
            DataTable tabla = conexion.ObtenerTabla(consulta, "Sucursales");
            return tabla;
        }

      
        public void eliminarSucursal(int Id_sucursal) {
            string consulta = $"DELETE FROM Sucursal WHERE Id_Sucursal = {Id_sucursal}";
            int resultado = conexion.EjecutarConsulta(consulta);
            if (resultado == 0) 
                throw new Exception($"No se encontró sucursal con ID: {Id_sucursal}");
        }

        public int agregarSucursal(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, sucursal);
            return conexion.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter parametro;

            parametro = Comando.Parameters.Add("@NOMBRE", SqlDbType.VarChar);
            parametro.Value = sucursal.Nombre_Sucursal;

            parametro = Comando.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar);
            parametro.Value = sucursal.Descripcion_Sucursal;

            parametro = Comando.Parameters.Add("@PROVINCIA", SqlDbType.Int);
            parametro.Value = sucursal.Id_Provincia_Sucursal;

            parametro = Comando.Parameters.Add("@DIRECCION", SqlDbType.VarChar);
            parametro.Value = sucursal.Direccion_Sucursal;
        }
    }
}
