using System;

class Inventario
{
    public static Producto[,] stockProductos = new Producto[5, 10]; // Matriz de productos

    // Inicializa productos en la matriz
    public static void InicializarStock()
    {
        stockProductos[0, 0] = new Producto(1, "Laptop", "Electrónica", 800, 5);
        stockProductos[0, 1] = new Producto(2, "Celular", "Electrónica", 500, 10);
        stockProductos[1, 0] = new Producto(3, "Silla", "Muebles", 120, 7);
        stockProductos[1, 1] = new Producto(4, "Mesa", "Muebles", 300, 3);
    }

    // Registra un nuevo producto
    public static void RegistrarProducto()
    {
        Console.Write("Ingrese el ID del producto: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Categoría: ");
        string categoria = Console.ReadLine();
        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());
        Console.Write("Cantidad en stock: ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (stockProductos[i, j] == null)
                {
                    stockProductos[i, j] = new Producto(id, nombre, categoria, precio, cantidad);
                    Console.WriteLine("Producto registrado con éxito.");
                    return;
                }
            }
        }

        Console.WriteLine("No hay espacio disponible para más productos.");
    }

    // Muestra los productos en stock
    public static void MostrarStock()
    {
        Console.WriteLine("\n--- Stock de Productos ---");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (stockProductos[i, j] != null)
                {
                    stockProductos[i, j].MostrarProducto();
                }
            }
        }
    }
}
