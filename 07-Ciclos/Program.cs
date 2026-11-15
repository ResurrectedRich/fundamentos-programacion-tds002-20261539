/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 15/11/2026
 * Descripción: Pide un número entre 1 y 12 (validado con do-while),
 *              muestra su tabla de multiplicar con while, y al final
 *              muestra la suma acumulada de todos los resultados.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        // Repite hasta que el usuario ingrese un número válido (1-12)
        do
        {
            Console.Write("Ingresa un número entre 1 y 12: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > 12)
            {
                Console.WriteLine("Número inválido, intenta de nuevo.");
            }
        }
        while (numero < 1 || numero > 12);

        // Muestra la tabla de multiplicar usando while y un contador
        Console.WriteLine($"--- Tabla del {numero} ---");

        int contador = 1;
        int suma = 0; // acumulador de todos los resultados

        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            suma += resultado; // acumula el resultado
            contador++;        // avanza el contador
        }

        // Muestra la suma total de todos los resultados de la tabla
        Console.WriteLine($"Suma de todos los resultados: {suma}");
    }
}