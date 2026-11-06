/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Solicita datos personales y muestra una ficha
 *              con el año en que la persona cumplirá 30 años.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita el nombre (string)
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        // Solicita la edad (int)
        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        // Solicita la estatura (double)
        Console.Write("Estatura (m): ");
        double estatura = double.Parse(Console.ReadLine());

        // Solicita si trabaja (bool)
        Console.Write("¿Trabajas? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine());

        // Calcula el año en que cumplirá 30 años
        const int ANIO_ACTUAL = 2026;
        int aniosParaTreinta = 30 - edad;
        int anioCumple30 = ANIO_ACTUAL + aniosParaTreinta;

        // Muestra la ficha con interpolación
        Console.WriteLine($"--- Ficha Personal ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura}m");
        Console.WriteLine($"¿Trabaja?: {trabaja}");
        Console.WriteLine($"Cumplirá 30 años en el {anioCumple30}.");
    }
}