/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Demuestra casting explícito (double a int) y
 *              casting implícito (int a double) con un número
 *              ingresado por el usuario.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita un número con decimales (double)
        Console.Write("Ingresa un número con decimales: ");
        double numeroDecimal = double.Parse(Console.ReadLine());

        // Casting explícito: convierte double a int (se pierde la parte decimal)
        int parteEntera = (int)numeroDecimal;
        Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");

        // Casting implícito: un int se convierte automáticamente a double
        int numeroEntero = 10;
        double numeroComoDouble = numeroEntero; // no requiere escribir (double)
        Console.WriteLine($"Casting implícito de int a double: {numeroEntero} -> {numeroComoDouble}");
    }
}