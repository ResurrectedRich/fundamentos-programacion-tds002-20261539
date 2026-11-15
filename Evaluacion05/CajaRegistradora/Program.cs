/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 15/11/2026
 * Descripción: Simula una caja registradora. Lee precios de productos
 *              hasta que el usuario escriba 0, y calcula el subtotal,
 *              ITBIS y total de la compra.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        const double ITBIS = 0.18;

        double precio;
        double subtotal = 0;  // acumulador de precios
        int cantidadProductos = 0;  // contador de productos leídos

        // Lee precios hasta que el usuario escriba 0
        do
        {
            Console.Write("Ingresa el precio del producto (0 para terminar): ");
            precio = double.Parse(Console.ReadLine());

            if (precio != 0)
            {
                subtotal += precio;       // acumula el precio
                cantidadProductos++;      // cuenta un producto más
            }
        }
        while (precio != 0);

        // Calcula el ITBIS y el total de la compra
        double montoItbis = subtotal * ITBIS;
        double total = subtotal + montoItbis;

        // Muestra el resumen de la compra
        Console.WriteLine("--- Resumen de compra ---");
        Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
        Console.WriteLine($"Subtotal: {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%): {montoItbis:N2}");
        Console.WriteLine($"Total: {total:N2}");
    }
}