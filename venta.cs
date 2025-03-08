using System;

// Clase que representa una venta realizada en la tienda
class Venta
{
    //Variables
    public int ID { get; set; } 
    public Cliente Cliente { get; set; } 
    public Dictionary<int, int> ProductosComprados { get; set; } 
    public double Total { get; set; }

    // Constructor para inicializar una venta con un cliente
    public Venta(int id, Cliente cliente)
    {
        ID = id;
        Cliente = cliente;
        ProductosComprados = new Dictionary<int, int>();
        Total = 0;
    }

    // Metodo para agregar un producto a la venta
    public void AgregarProducto(Producto producto, int cantidad)
    {
        // Verificar si hay suficiente stock
        if (producto.CantidadEnStock >= cantidad)
        {
            if (ProductosComprados.ContainsKey(producto.ID))
                ProductosComprados[producto.ID] += cantidad;
            else
                ProductosComprados[producto.ID] = cantidad;

            producto.CantidadEnStock -= cantidad; // Reducir stock del producto
            Total += producto.Precio * cantidad; // Calcular el total de la venta
        }
        else
        {
            Console.WriteLine($"Stock insuficiente para {producto.Nombre}.");
        }
    }

    // Metodo para mostrar los detalles de la venta en consola
    public void MostrarVenta()
    {
        Console.WriteLine($"ID Venta: {ID} | Cliente: {Cliente.Nombre} | Total: ${Total}");
        foreach (var item in ProductosComprados)
        {
            Console.WriteLine($" - Producto ID: {item.Key} | Cantidad: {item.Value}");
        }
    }
}