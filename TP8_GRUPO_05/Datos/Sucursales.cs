using Datos;
using System;
using System.Data;

namespace Negocio {
    public class Sucursales {
        AccesoDatos conexion = new AccesoDatos();
        public DataTable getSucursales() {
            const string consulta = "SELECT"
                                        + "Id_Sucursal,"
                                        + "NombreSucursal AS Nombre,"
                                        + "DescripcionSucursal AS Descripcion,"
                                        + "Provincia.DescripcionProvincia AS Provincia,"
                                        + "DireccionSucursal AS Direccion"
                                        + "FROM Sucursal"
                                    + "INNER JOIN Provincia ON Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
            DataTable tabla = conexion.ObtenerTabla(consulta, "Sucursales");
            return tabla;
        }
        public void eliminarSucursal(int Id_sucursal) {
            string consulta = $"DELETE FROM Sucursal WHERE Id_Sucursal = {Id_sucursal}";
            int resultado = conexion.EjecutarConsulta(consulta);
            if (resultado == 0) 
                throw new Exception($"No se encontró sucursal con ID: {Id_sucursal}");
        }
    }
}
