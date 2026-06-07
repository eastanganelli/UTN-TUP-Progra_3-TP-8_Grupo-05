using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class SucursalesNeg
    {
        Sucursales sucursal = new Sucursales();

        public DataTable filtrarPorId(string input)
        {
            if (!int.TryParse(input, out int id))
            {
                return null;
            }
            return sucursal.getSucursalPorId(id);
        }

        public void eliminarSucursal(string input)
        {
            if (int.TryParse(input, out int id))
            {
                sucursal.eliminarSucursal(id);
            }
            else
            {

            }
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

    }

}
