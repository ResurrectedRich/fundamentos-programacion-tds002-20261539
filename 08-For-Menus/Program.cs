/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 15/11/2026
 * Descripción: Menú con dos opciones: mostrar las tablas de multiplicar
 *              del 1 al 10 en columnas alineadas (ciclos for anidados),
 *              y dibujar un triángulo de asteriscos de N filas.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        // Menú principal: se repite hasta que el usuario elija salir (0)
        do
        {
            Console.WriteLine();
            Console.WriteLine("--- Menú ---");
            Console.WriteLine("1. Tablas de multiplicar");
            Console.WriteLine("2. Triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarTablas();
                    break;

                case 2:
                    DibujarTriangulo();
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        while (opcion != 0);
    }

    // Muestra las tablas del 1 al 10 en columnas alineadas usando ciclos anidados
    static void MostrarTablas()
    {
        // Ciclo externo: recorre cada tabla (1 a 10)
        for (int tabla = 1; tabla <= 10; tabla++)
        {
            // Ciclo interno: recorre cada multiplicador (1 a 10) de esa tabla
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                int resultado = tabla * multiplicador;
                Console.Write($"{resultado,4}"); // columna alineada a 4 espacios
            }
            Console.WriteLine(); // salto de línea al terminar cada fila (tabla)
        }
    }

    // Dibuja un triángulo de asteriscos con N filas, N ingresado por el usuario
    static void DibujarTriangulo()
    {
        Console.Write("¿Cuántas filas quieres? ");
        int filas = int.Parse(Console.ReadLine());

        // Ciclo externo: recorre cada fila del triángulo
        for (int fila = 1; fila <= filas; fila++)
        {
            // Ciclo interno: imprime tantos asteriscos como el número de la fila
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // salto de línea al terminar cada fila
        }
    }
}