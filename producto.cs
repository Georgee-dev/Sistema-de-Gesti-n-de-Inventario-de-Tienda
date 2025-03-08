using System;

// Clase que representa un producto en la tienda
class Producto
{
    //Creacion de variables para la utilizacion de los productos
    public int ID { get; set; } 
    public string Nombre { get; set; } 
    public string Categoria { get; set; } 
    public double Precio { get; set; } 
    public int CantidadEnStock { get; set; } 

    // Constructor para inicializar un producto
    public Producto(int id, string nombre, string categoria, double precio, int cantidad)
    {
        ID = id;
        Nombre = nombre;
        Categoria = categoria;
        Precio = precio;
        CantidadEnStock = cantidad;
    }

    // Metodo para la información del producto en consola
    public void MostrarProducto()
    {
        Console.WriteLine($"ID: {ID} | Nombre: {Nombre} | Categoría: {Categoria} | Precio: ${Precio} | Stock: {CantidadEnStock}");
    }
}


