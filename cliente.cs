using System;

// Clase de la tienda
class Cliente
{
    //Variables para el uso de informacion del cliente
    public int ID { get; set; } 
    public string Nombre { get; set; } 
    public string Direccion { get; set; } 
    public string Telefono { get; set; }

    // Constructor para el cliente
    public Cliente(int id, string nombre, string direccion, string telefono)
    {
        ID = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
    }

    // Metodo para mostrar la información del cliente en consola
    public void MostrarCliente()
    {
        Console.WriteLine($"ID: {ID} | Nombre: {Nombre} | Dirección: {Direccion} | Teléfono: {Telefono}");
    }
}
