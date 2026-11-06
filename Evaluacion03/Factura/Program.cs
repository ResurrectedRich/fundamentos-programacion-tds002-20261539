/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Genera una factura simple a partir de un producto,
 *              su cantidad y precio, calculando ITBIS y total,
 *              con columnas alineadas.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Porcentaje de ITBIS en República Dominicana (constante)
        const double ITBIS = 0.18;

        // Solicita los datos del producto
        Console.Write("Producto: ");
        string producto = Console.ReadLine();

        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Precio unitario: ");
        double precio = double.Parse(Console.ReadLine());

        // Calcula subtotal, ITBIS y total
        double subtotal = cantidad * precio;
        double montoItbis = subtotal * ITBIS;
        double total = subtotal + montoItbis;

        // Muestra la factura en columnas alineadas
        Console.WriteLine("--- Factura ---");
        Console.WriteLine($"{"Producto",-15}{"Cant.",-8}{"Precio",10}");
        Console.WriteLine($"{producto,-15}{cantidad,-8}{precio,10:N2}");
        Console.WriteLine();
        Console.WriteLine($"{"Subtotal:",-15}{subtotal,10:N2}");
        Console.WriteLine($"{"ITBIS (18%):",-15}{montoItbis,10:N2}");
        Console.WriteLine($"{"Total:",-15}{total,10:N2}");
    }
}