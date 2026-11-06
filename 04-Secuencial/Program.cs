/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Conversor de unidades. Convierte un peso en libras
 *              a kilogramos, y una temperatura en grados Fahrenheit
 *              a grados Celsius.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante de conversión: 1 libra equivale a 0.453592 kg
        const double LB_A_KG = 0.453592;

        // Solicita el peso en libras
        Console.Write("Ingresa el peso en libras: ");
        double libras = double.Parse(Console.ReadLine());

        // Solicita la temperatura en grados Fahrenheit
        Console.Write("Ingresa la temperatura en °F: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        // Convierte el peso de libras a kilogramos
        double kilogramos = libras * LB_A_KG;

        // Convierte la temperatura de Fahrenheit a Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Muestra los resultados redondeados a 2 decimales
        Console.WriteLine($"{libras} lb equivalen a {Math.Round(kilogramos, 2)} kg.");
        Console.WriteLine($"{fahrenheit}°F equivalen a {celsius:F2}°C.");
    }
}