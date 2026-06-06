using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    internal class AccesoDatos
    {
        private static string rutaBaseDeDatos = "Data Source=152.53.91.65,1433;Initial Catalog=BDSucursales;Persist Security Info=True;User ID=sa;Password=UTN_Progra3_2026!;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";
        //private static string rutaBaseDeDatos = "Data Source=localhost\\\\sqlexpress; Initial\r\nCatalog=BDSucursales;Integrated Security=True;";
        public AccesoDatos() { }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection sqlConnection = new SqlConnection(rutaBaseDeDatos);
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }

            catch (Exception exception)
            {
                return null;
            }
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }
        public DataTable ObtenerTabla(string consulta, string nombreTabla)
        {
            SqlConnection conexion = new SqlConnection(rutaBaseDeDatos);
            conexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataSet setDatos = new DataSet();
            adaptador.Fill(setDatos, nombreTabla);
            conexion.Close();
            return setDatos.Tables[nombreTabla];
        }
        public int EjecutarConsulta(string consulta)
        {
            SqlConnection conexion = new SqlConnection(rutaBaseDeDatos);
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }
    }
}
