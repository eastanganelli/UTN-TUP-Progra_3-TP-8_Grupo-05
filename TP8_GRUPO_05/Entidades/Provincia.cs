using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {

        private int id_Provincia;
        private string descripcionProvincia;


        public Provincia() { }

        public Provincia(int id_Provincia, string descripcionProvincia)
        {
            Id_Provincia = id_Provincia;
            DescripcionProvincia = descripcionProvincia;
        }

        public int Id_Provincia
        {
            get => id_Provincia;
            set => id_Provincia = value;
        }
        public string DescripcionProvincia
        {
            get => descripcionProvincia;
            set => descripcionProvincia = value;
        }
    }

}
