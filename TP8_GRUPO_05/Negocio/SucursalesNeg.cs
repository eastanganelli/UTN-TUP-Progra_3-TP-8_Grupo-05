using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SucursalesNeg
    {
        Sucursales sucursal = new Sucursales();

        public DataTable filtrarPorId(string input)
        {
            if (int.TryParse(input, out int id))
            {
                return sucursal.getSucursalPorId(id);
            }
            return null;
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

    }

}
