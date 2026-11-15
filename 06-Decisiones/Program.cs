/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 15/11/2026
 * Descripción: Programa con dos partes usando estructuras de decisión:
 *              1) Califica una nota con if/else if/else.
 *              2) Calculadora básica con switch según la opción elegida.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // ----- Parte 1: Calificación -----
        Console.WriteLine("--- Calificación ---");
        Console.Write("Ingresa una nota (0-100): ");
        string entradaNota = Console.ReadLine();

        // Valida que lo ingresado sea un número entero válido
        bool esValida = int.TryParse(entradaNota, out int nota);

        if (!esValida || nota < 0 || nota > 100)
        {
            Console.WriteLine("Nota inválida. Debe ser un número entre 0 y 100.");
        }
        else
        {
            // Determina la letra según el rango de la nota
            string letra;
            if (nota >= 90)
            {
                letra = "A";
            }
            else if (nota >= 80)
            {
                letra = "B";
            }
            else if (nota >= 70)
            {
                letra = "C";
            }
            else
            {
                letra = "F";
            }

            Console.WriteLine($"La nota {nota} corresponde a la letra: {letra}");
        }

        // ----- Parte 2: Calculadora -----
        Console.WriteLine();
        Console.WriteLine("--- Calculadora ---");

        Console.Write("Primer número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Elige una opción: 1) Sumar  2) Restar  3) Multiplicar  4) Dividir");
        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        // Resuelve la operación elegida con switch
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado: {numero1 + numero2}");
                break;

            case 2:
                Console.WriteLine($"Resultado: {numero1 - numero2}");
                break;

            case 3:
                Console.WriteLine($"Resultado: {numero1 * numero2}");
                break;

            case 4:
                // Caso especial: no se puede dividir entre 0
                if (numero2 == 0)
                {
                    Console.WriteLine("Error: no se puede dividir entre 0.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {numero1 / numero2}");
                }
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}