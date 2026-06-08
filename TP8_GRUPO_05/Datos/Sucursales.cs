using Datos;
using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Negocio {
    public class Sucursales {
        AccesoDatos conexion = new AccesoDatos();


        public DataTable getTablaProvincias()
        {
            string consulta = "SELECT Id_Provincia, DescripcionProvincia FROM Provincia";
            return conexion.ObtenerTabla(consulta, "Provincias");
        }

        public DataTable getSucursales()
        {
            const string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripción, Provincia.DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
            DataTable tabla = conexion.ObtenerTabla(consulta, "Sucursales");
            return tabla;
        }


        public DataTable getSucursalPorId(int id)
        {
            string consulta = "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripción, Provincia.DescripcionProvincia AS Provincia, DireccionSucursal AS Dirección FROM Sucursal INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia WHERE Id_Sucursal = " + id;
            DataTable tabla = conexion.ObtenerTabla(consulta, "Sucursales");
            return tabla;
        }


        public int EliminarSucursal(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, sucursal);
            return conexion.EjecutarProcedimientoAlmacenado(comando, "SP_EliminarSucursal");
        }

        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.IdSucursal;
        }


        public int agregarSucursal(Sucursal sucursal)
        {
            
            string consulta = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) " +
                              $"VALUES ('{sucursal.Nombre_Sucursal}', '{sucursal.Descripcion_Sucursal}', {sucursal.Id_Provincia_Sucursal}, '{sucursal.Direccion_Sucursal}')";

            return conexion.EjecutarConsulta(consulta);
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


        public bool existeSucursal(string nombre, string direccion)
        {
            string consulta = $"SELECT * FROM Sucursal WHERE NombreSucursal = '{nombre}' AND DireccionSucursal = '{direccion}'";
            DataTable tabla = conexion.ObtenerTabla(consulta, "ExisteSucursal");

            return tabla.Rows.Count > 0;
        }

        

        public DataTable getSucursalesPorProvincia(int idProvincia)
        {
            string consulta = "SELECT Id_Sucursal, NombreSucursal AS [Nombre], DescripcionSucursal AS [Descripción], " +
                      "DescripcionProvincia AS [Provincia], DireccionSucursal AS [Dirección] " +
                      "FROM Sucursal " +
                      "INNER JOIN Provincia ON Id_ProvinciaSucursal = Id_Provincia " +
                      $"WHERE Id_ProvinciaSucursal = {idProvincia}";

            return conexion.ObtenerTabla(consulta, "SucursalesPorProvincia");
        }
    }
}
