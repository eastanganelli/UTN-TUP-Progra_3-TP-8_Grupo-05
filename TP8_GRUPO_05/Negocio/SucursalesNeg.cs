using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class SucursalesNeg
    {
        Sucursales sucursal = new Sucursales();

        public DataTable getProvincias()
        {
            return sucursal.getTablaProvincias();
        }   

        public DataTable filtrarPorId(string input)
        {
            if (int.TryParse(input, out int id))
            {
                return sucursal.getSucursalPorId(id);
            }
            return null;
        }

        public int eliminarSucursal(string input)
        {
            if (!int.TryParse(input, out int id))
                return 2;

            Sucursales suc = new Sucursales();
            Sucursal s = new Sucursal();

            s.IdSucursal = id;

            return suc.EliminarSucursal(s) == 1 ? 1 : 0;
        }

        public bool AgregarSucursal(Sucursal sucursal)
        {
            int cantFilas = 0;

            Sucursales suc = new Sucursales();
            cantFilas = suc.agregarSucursal(sucursal);

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool verificarExistencia(string nombre, string direccion)
        {
            return sucursal.existeSucursal(nombre, direccion);
        }

        

        public DataTable listarPorProvincia(int idProvincia)
        {

            return sucursal.getSucursalesPorProvincia(idProvincia);
        }

    }

}
