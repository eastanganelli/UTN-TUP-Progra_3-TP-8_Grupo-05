using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP8_GRUPO_05 {
    public class AccesoDatos {
        //Propiedades
        private static string rutaBaseDeDatos = "Data Source=152.53.91.65,1433;Initial Catalog=BDSucursales;Persist Security Info=True;User ID=sa;Password=UTN_Progra3_2026!;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";

        //Metodos
        public AccesoDatos() { }
        public SqlConnection ObtenerConexion() {
            SqlConnection sqlConnection = new SqlConnection(rutaBaseDeDatos);
            try {
                sqlConnection.Open();
                return sqlConnection;
            }

            catch (Exception exception) {
                return new Exception("No se pudo conectar a la base de datos!");
            }
        }
    }
}