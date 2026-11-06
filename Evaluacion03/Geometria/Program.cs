/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Calcula el área y circunferencia de un círculo,
 *              y la hipotenusa de un triángulo rectángulo a partir
 *              de sus catetos, usando la clase Math.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Círculo ---
        Console.Write("Radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        // Área = π * r², usando Math.Pow para elevar al cuadrado
        double areaCirculo = Math.PI * Math.Pow(radio, 2);

        // Circunferencia = 2 * π * r
        double circunferencia = 2 * Math.PI * radio;

        Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");

        // --- Triángulo rectángulo ---
        Console.Write("Cateto 1: ");
        double cateto1 = double.Parse(Console.ReadLine());

        Console.Write("Cateto 2: ");
        double cateto2 = double.Parse(Console.ReadLine());

        // Hipotenusa con el teorema de Pitágoras: raíz de (a² + b²)
        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}