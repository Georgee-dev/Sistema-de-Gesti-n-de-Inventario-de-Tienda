using System;
using System.Collections.Generic;

class GestionVentas
{
    public static Dictionary<int, Venta> ventas = new Dictionary<int, Venta>(); // Diccionario de ventas

    // Realiza una venta
    public static void RealizarVenta()
    {
        Console.Write("Ingrese el ID del cliente: ");
        int idCliente = int.Parse(Console.ReadLine());

        Cliente cliente = GestionClientes.clientes.Find(c => c.ID == idCliente);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            return;
        }

        int idVenta = ventas.Count + 1;
        Venta nuevaVenta = new Venta(idVenta, cliente);

        while (true)
        {
            Console.Write("Ingrese el ID del producto a comprar (0 para finalizar): ");
            int idProducto = int.Parse(Console.ReadLine());

            if (idProducto == 0)
                break;

            Console.Write("Ingrese la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            Producto producto = null;
            foreach (var p in Inventario.stockProductos)
            {
                if (p != null && p.ID == idProducto)
                {
                    producto = p;
                    break;
                }
            }

            if (producto != null)
                nuevaVenta.AgregarProducto(producto, cantidad);
            else
                Console.WriteLine("Producto no encontrado.");
        }

        ventas[idVenta] = nuevaVenta;
        Console.WriteLine("Venta realizada con éxito.");
    }

    // Consulta ventas registradas
    public static void ConsultarVentas()
    {
        Console.WriteLine("\n--- Ventas Realizadas ---");
        foreach (var venta in ventas.Values)
        {
            venta.MostrarVenta();
        }
    }

    // Elimina una venta y devuelve los productos al stock
    public static void EliminarVenta()
    {
        Console.Write("Ingrese el ID de la venta a eliminar: ");
        int idVenta = int.Parse(Console.ReadLine());

        if (ventas.ContainsKey(idVenta))
        {
            Venta venta = ventas[idVenta];

            foreach (var item in venta.ProductosComprados)
            {
                foreach (var p in Inventario.stockProductos)
                {
                    if (p != null && p.ID == item.Key)
                    {
                        p.CantidadEnStock += item.Value;
                        break;
                    }
                }
            }

            ventas.Remove(idVenta);
            Console.WriteLine("Venta eliminada y productos devueltos al stock.");
        }
        else
        {
            Console.WriteLine("Venta no encontrada.");
        }
    }
}
