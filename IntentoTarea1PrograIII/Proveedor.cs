using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntentoTarea1PrograIII
{
    internal class Proveedor
    {
        public int IdProveedor { get; set; }

        public string NombreProveedor { get; set; }

        public string Contacto { get; set; }


        public Proveedor(string nombreProveedor, string contacto, int idProveedor)
        {
            NombreProveedor = nombreProveedor;
            Contacto = contacto;
            IdProveedor = idProveedor;
        }

    }
}
