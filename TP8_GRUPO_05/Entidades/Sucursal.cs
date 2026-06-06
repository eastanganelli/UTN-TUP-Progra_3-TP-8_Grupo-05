using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int Id_sucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int Id_HorarioSucursal;
        private int Id_ProvinciaSucursal;
        private string DireccionSucursal;
        private string URL_Imagen_Sucursal;

        Sucursal() { }

        public Sucursal(string nombreSucursal, string descripcionSucursal, int id_ProvinciaSucursal, string direccionSucursal)
        {
            NombreSucursal = nombreSucursal;
            DescripcionSucursal = descripcionSucursal;
            Id_ProvinciaSucursal = id_ProvinciaSucursal;
            DireccionSucursal = direccionSucursal;
        }

        Sucursal(int id_sucursal, string nombreSucursal, string descripcionSucursal, int id_ProvinciaSucursal, string direccionSucursal)
        {
            Id_sucursal = id_sucursal;
            NombreSucursal = nombreSucursal;
            DescripcionSucursal = descripcionSucursal;
            Id_ProvinciaSucursal = id_ProvinciaSucursal;
            DireccionSucursal = direccionSucursal;
        }

        Sucursal(int id_sucursal, string nombreSucursal, string descripcionSucursal, string direccionSucursal, string uRL_Imagen_Sucursal)
        {
            Id_sucursal = id_sucursal;
            NombreSucursal = nombreSucursal;
            DescripcionSucursal = descripcionSucursal;
            DireccionSucursal = direccionSucursal;
            URL_Imagen_Sucursal = uRL_Imagen_Sucursal;
        }

        Sucursal(int id_sucursal, string nombreSucursal, string descripcionSucursal, int id_HorarioSucursal, int id_ProvinciaSucursal, string direccionSucursal, string uRL_Imagen_Sucursal)
        {
            Id_sucursal = id_sucursal;
            NombreSucursal = nombreSucursal;
            DescripcionSucursal = descripcionSucursal;
            Id_HorarioSucursal = id_HorarioSucursal;
            Id_ProvinciaSucursal = id_ProvinciaSucursal;
            DireccionSucursal = direccionSucursal;
            URL_Imagen_Sucursal = uRL_Imagen_Sucursal;
        }

        public int IdSucursal { get => Id_sucursal; set => Id_sucursal = value; }
        public string Nombre_Sucursal { get => NombreSucursal; set => NombreSucursal = value; }
        public string Descripcion_Sucursal { get => DescripcionSucursal; set => DescripcionSucursal = value; }
        public int Id_Horario_Sucursal { get => Id_HorarioSucursal; set => Id_HorarioSucursal = value; }
        public int Id_Provincia_Sucursal { get => Id_ProvinciaSucursal; set => Id_ProvinciaSucursal = value; }
        public string Direccion_Sucursal { get => DireccionSucursal; set => DireccionSucursal = value; }
        public string URL_Imagen_Sucursal1 { get => URL_Imagen_Sucursal; set => URL_Imagen_Sucursal = value; }
    }
}