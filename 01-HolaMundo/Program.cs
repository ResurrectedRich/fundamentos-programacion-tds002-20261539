/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 15/09/2026
 * Descripción: Programa que imprime una tarjeta de presentación
 *              en consola, con marco hecho de caracteres especiales.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Línea 1: Imprime el borde superior de la tarjeta
        Console.WriteLine("*=======================================*");

        // Línea 2: Imprime los datos personales dentro del marco
        Console.WriteLine("| Nombre: Richard Eduardo Damaso Batista |");
        Console.WriteLine("| Matricula: 2026-1539                   |");
        Console.WriteLine("| Carrera: Desarrollo de Software        |");
        Console.WriteLine("| Frase: Apasionado por la tecnologia y  |");
        Console.WriteLine("|        el aprendizaje constante        |");

        // Línea 3: Imprime el borde inferior de la tarjeta
        Console.WriteLine("*=======================================*");
    }
}