using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using IntentoTarea1PrograIII;

List<Producto> productos = new List<Producto>();
List<Proveedor> proveedores = new List<Proveedor>();
List<OrdenDeCompra> ordenesDeCompra = new List<OrdenDeCompra>();
int opcion;
do
{
    Console.WriteLine("Menu de opciones:");
    Console.WriteLine("1. Agregar Producto");
    Console.WriteLine("2. Agregar Proveedor");
    Console.WriteLine("3. Crear Orden de Compra");
    Console.WriteLine("4. Mostrar Ordenes de Compra");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("Ingrese la descripcion del producto: ");
            string descripcion = Console.ReadLine();
            Console.Write("Ingrese el precio por unidad: ");
            decimal precioUnidad = decimal.Parse(Console.ReadLine());
            Producto nuevoProducto = new Producto(nombreProducto, descripcion, precioUnidad);
            productos.Add(nuevoProducto);
            Console.WriteLine("Producto agregado exitosamente.");
            break;

        case 2:
            Console.Write("Ingrese el nombre del proveedor: ");
            string nombreProveedor = Console.ReadLine();
            Console.Write("Ingrese el contacto del proveedor: ");
            string contacto = Console.ReadLine();
            Console.Write("Ingrese el ID del proveedor: ");
            int idProveedor = int.Parse(Console.ReadLine());
            Proveedor nuevoProveedor = new Proveedor(nombreProveedor, contacto, idProveedor);
            proveedores.Add(nuevoProveedor);
            Console.WriteLine("Proveedor agregado exitosamente.");
            break;

        case 3:
            if (proveedores.Count == 0)
            {
                Console.WriteLine("No hay proveedores disponibles. Agregue un proveedor primero.");
                break;
            }
            Console.Write("Ingrese el ID de la orden: ");
            int idOrden = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la fecha de la orden (dd/mm/yyyy): ");
            string fechaDeOrden = Console.ReadLine();
            Console.WriteLine("Seleccione un proveedor:");
            for (int i = 0; i < proveedores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {proveedores[i].NombreProveedor} (ID: {proveedores[i].IdProveedor})");
            }
            int seleccionProveedor = int.Parse(Console.ReadLine()) - 1;
            if (seleccionProveedor < 0 || seleccionProveedor >= proveedores.Count)
            {
                Console.WriteLine("Seleccion invalida.");
                break;
            }
            Proveedor proveedorSeleccionado
                = proveedores[seleccionProveedor];
            OrdenDeCompra nuevaOrden = new OrdenDeCompra(idOrden, fechaDeOrden, proveedorSeleccionado);
            ordenesDeCompra.Add(nuevaOrden);
            Console.WriteLine("Orden de compra creada exitosamente.");
            break;

            case 4:
            if (ordenesDeCompra.Count == 0)
            {
                Console.WriteLine("No hay ordenes de compra disponibles.");
                break;
            }
            Console.WriteLine("Ordenes de Compra:");
            foreach (var orden in ordenesDeCompra)
            {
                Console.WriteLine($"ID Orden: {orden.IdOrden}, Fecha: {orden.FechaDeOrden}, Proveedor: {orden.Proveedor.NombreProveedor}");
            }
            break;
            case 5:
            Console.WriteLine("Saliendo del programa.");
            break;
            default:
            Console.WriteLine("Opcion invalida. Intente de nuevo.");
            break;
    }
    Console.WriteLine();
    } while (opcion != 5);
Console.WriteLine(
    "Gracias por usar el sistema de gestion de ordenes de compra.");


