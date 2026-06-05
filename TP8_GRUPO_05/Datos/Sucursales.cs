using Datos;
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
    }
}
