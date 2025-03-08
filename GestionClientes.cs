using System;
using System.Collections.Generic;

class GestionClientes
{
    public static List<Cliente> clientes = new List<Cliente>(); // Lista de clientes

    // Registra un nuevo cliente
    public static void RegistrarCliente()
    {
        Console.Write("Ingrese el ID del cliente: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Nombre del cliente: ");
        string nombre = Console.ReadLine();
        Console.Write("Dirección: ");
        string direccion = Console.ReadLine();
        Console.Write("Número de teléfono: ");
        string telefono = Console.ReadLine();

        clientes.Add(new Cliente(id, nombre, direccion, telefono));
        Console.WriteLine("Cliente registrado con éxito.");
    }
}
