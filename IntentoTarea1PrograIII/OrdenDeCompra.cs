using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntentoTarea1PrograIII
{
    internal class OrdenDeCompra
    {
        public int IdOrden { get; set; }
        public string FechaDeOrden { get; set; }
        public Proveedor Proveedor { get; set; }

     public OrdenDeCompra (int idOrden, string fechaDeOrden, Proveedor proveedor)
        {
            IdOrden = idOrden;
            FechaDeOrden = fechaDeOrden;
            Proveedor = proveedor;
        }

    }
}
