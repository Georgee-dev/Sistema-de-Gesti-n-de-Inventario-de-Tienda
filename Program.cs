using System;
using System.Collections.Generic;

class Program
{
    
    // Matrizes  para almacenar los productos, cliente, ventas y demas datos relevantes. 
    static Producto[,] stockProductos = new Producto[5, 10];
    static List<Cliente> clientes = new List<Cliente>();
    static Dictionary<int, Venta> ventas = new Dictionary<int, Venta>();

    static void Main()
    {
        // Agregar productos de ejemplo a la matriz
        InicializarStock();

        // Agregar clientes de ejemplo a la lista
        clientes.Add(new Cliente(1, "Juan Pérez", "Av. Siempre Viva 123", "123-4567"));
        clientes.Add(new Cliente(2, "María López", "Calle Falsa 456", "987-6543"));

        // Menú principal
        int opcion;
        do
        {
            Console.WriteLine("\n--- Sistema de Gestión de Inventario ---");
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
                    RegistrarProducto();
                    break;
                case 2:
                    RegistrarCliente();
                    break;
                case 3:
                    MostrarStock();
                    break;
                case 4:
                    RealizarVenta();
                    break;
                case 5:
                    ConsultarVentas();
                    break;
                case 6:
                    EliminarVenta();
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
