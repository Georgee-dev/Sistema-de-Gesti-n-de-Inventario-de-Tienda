using System;

class Program
{
    static void Main()
    {
        Inventario.InicializarStock(); // Inicializa productos en la matriz

        int opcion;
        do
        {
            Console.WriteLine("\n VR-210280 - Sistema de Gestión de Inventario");
            Console.WriteLine("1. Registrar nuevo producto");
            Console.WriteLine("2. Registrar nuevo cliente");
            Console.WriteLine("3. Mostrar stock de productos");
            Console.WriteLine("4. Realizar venta");
            Console.WriteLine("5. Consultar ventas");
            Console.WriteLine("6. Eliminar venta");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Inventario.RegistrarProducto();
                    break;
                case 2:
                    GestionClientes.RegistrarCliente();
                    break;
                case 3:
                    Inventario.MostrarStock();
                    break;
                case 4:
                    GestionVentas.RealizarVenta();
                    break;
                case 5:
                    GestionVentas.ConsultarVentas();
                    break;
                case 6:
                    GestionVentas.EliminarVenta();
                    break;
                case 7:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        } while (opcion != 7);
    }
}
