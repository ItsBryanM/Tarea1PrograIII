using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntentoTarea1PrograIII
{
    internal class Producto
    {
        private decimal precioUnidad;

        public string NombreProducto { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioUnidad { get; set; }

        public Producto(string nombreProducto, string descripcion, decimal precioUnidad)
        {
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            PrecioUnidad = precioUnidad;
          
        }

    }
}
