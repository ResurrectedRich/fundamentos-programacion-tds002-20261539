/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 15/11/2026
 * Descripción: El programa genera un número secreto entre 1 y 100.
 *              El usuario intenta adivinarlo y recibe pistas de
 *              "mayor" o "menor" hasta acertar. Al final muestra
 *              cuántos intentos le tomó.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Genera el número secreto entre 1 y 100
        int numeroSecreto = Random.Shared.Next(1, 101);

        int intento;
        int contadorIntentos = 0; // cuenta cuántas veces ha intentado

        Console.WriteLine("Adivina el número secreto (entre 1 y 100).");

        // Repite hasta que el usuario acierte
        do
        {
            Console.Write("Tu intento: ");
            intento = int.Parse(Console.ReadLine());
            contadorIntentos++; // suma un intento más

            if (intento > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
        }
        while (intento != numeroSecreto);

        // Muestra el resultado final
        Console.WriteLine($"¡Correcto! Adivinaste en {contadorIntentos} intentos.");
    }
}