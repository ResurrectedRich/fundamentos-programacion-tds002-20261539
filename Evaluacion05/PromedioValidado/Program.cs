/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 15/11/2026
 * Descripción: Pide notas válidas (0-100) hasta que el usuario
 *              escriba -1. Valida cada entrada con TryParse y
 *              un do-while, y al final muestra el promedio,
 *              la nota mayor y la menor.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        double suma = 0;          // acumulador de notas
        int cantidadNotas = 0;    // contador de notas ingresadas
        double notaMayor = double.MinValue; // empieza bajísimo para que cualquier nota la supere
        double notaMenor = double.MaxValue; // empieza altísimo para que cualquier nota sea menor

        Console.WriteLine("Ingresa notas entre 0 y 100. Escribe -1 para terminar.");

        double nota;
        bool entradaValida;

        do
        {
            Console.Write("Nota: ");
            string entrada = Console.ReadLine();
            entradaValida = double.TryParse(entrada, out nota);

            if (!entradaValida)
            {
                Console.WriteLine("Entrada no válida, ingresa un número.");
                continue; // vuelve a pedir sin procesar nada más
            }

            if (nota == -1)
            {
                break; // termina el ciclo sin contar esta nota
            }

            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota fuera de rango (0-100), intenta de nuevo.");
                continue;
            }

            // Acumula y actualiza mayor/menor
            suma += nota;
            cantidadNotas++;

            if (nota > notaMayor) notaMayor = nota;
            if (nota < notaMenor) notaMenor = nota;
        }
        while (nota != -1);

        // Muestra los resultados, solo si se ingresó al menos una nota válida
        if (cantidadNotas > 0)
        {
            double promedio = suma / cantidadNotas;
            Console.WriteLine($"Promedio: {promedio:N2}");
            Console.WriteLine($"Nota mayor: {notaMayor}");
            Console.WriteLine($"Nota menor: {notaMenor}");
        }
        else
        {
            Console.WriteLine("No se ingresó ninguna nota válida.");
        }
    }
}