/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Convierte un monto en pesos dominicanos a dólares
 *              usando una tasa de cambio constante.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Tasa de cambio del día (constante, no puede cambiar en el programa)
        const double TASA_USD = 60.50;

        // Solicita el monto en pesos (double)
        Console.Write("Monto en pesos (RD$): ");
        double montoPesos = double.Parse(Console.ReadLine());

        // Calcula el equivalente en dólares
        double montoDolares = montoPesos / TASA_USD;

        // Muestra el resultado con interpolación
        Console.WriteLine($"RD${montoPesos} equivalen a ${montoDolares:F2} USD " +
                           $"(tasa: {TASA_USD} RD$ por USD).");
    }
}