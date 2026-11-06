/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Lee dos números enteros y muestra las operaciones
 *              básicas entre ellos: suma, resta, producto, división
 *              real, división entera, residuo y si el primero es par.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita el primer número entero
        Console.Write("Ingresa el primer número (x): ");
        int x = int.Parse(Console.ReadLine());

        // Solicita el segundo número entero
        Console.Write("Ingresa el segundo número (y): ");
        int y = int.Parse(Console.ReadLine());

        // Realiza las operaciones básicas
        int suma = x + y;
        int resta = x - y;
        int producto = x * y;
        double divisionReal = (double)x / y;   // casting para que no sea división entera
        int divisionEntera = x / y;
        int residuo = x % y;
        bool esPar = x % 2 == 0;               // true si el residuo de x/2 es 0

        // Muestra los resultados con interpolación
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"División real: {divisionReal}");
        Console.WriteLine($"División entera: {divisionEntera}");
        Console.WriteLine($"Residuo: {residuo}");
        Console.WriteLine($"¿x es par?: {esPar}");

        /*
         * Prueba de escritorio (x = 10, y = 3):
         * suma          = 10 + 3  = 13
         * resta         = 10 - 3  = 7
         * producto      = 10 * 3  = 30
         * divisionReal  = 10 / 3  = 3.333333...
         * divisionEntera= 10 / 3  = 3
         * residuo       = 10 % 3  = 1
         * esPar         = 10 % 2 == 0  -> true
         */
    }
}