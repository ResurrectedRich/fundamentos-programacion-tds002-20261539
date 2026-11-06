/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Programa que solicita nombre, edad y estatura al usuario,
 *              calcula el año de nacimiento usando una constante,
 *              y muestra los datos con interpolación de cadenas.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante que representa el año actual
        const int ANIO_ACTUAL = 2026;

        // Solicita el nombre (tipo string)
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // Solicita la edad (tipo int)
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        // Solicita la estatura (tipo double)
        Console.Write("Ingresa tu estatura (en metros): ");
        double estatura = double.Parse(Console.ReadLine());

        // Calcula el año de nacimiento aproximado usando la constante
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Muestra todos los datos usando interpolación de cadenas
        Console.WriteLine($"Hola {nombre}, tienes {edad} años, mides {estatura}m " +
                           $"y naciste aproximadamente en el {anioNacimiento}.");
    }
}