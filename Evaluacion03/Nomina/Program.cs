/*
 * Nombre: Richard Eduardo Damaso Batista
 * Fecha: 05/11/2026
 * Descripción: Calcula el salario neto de un empleado a partir
 *              de las horas trabajadas y el pago por hora,
 *              descontando AFP y SFS.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Porcentajes de descuento (constantes)
        const double PORCENTAJE_AFP = 0.0287;
        const double PORCENTAJE_SFS = 0.0304;

        // Solicita los datos del empleado
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine());

        Console.Write("Pago por hora: ");
        double pagoPorHora = double.Parse(Console.ReadLine());

        // Calcula el salario bruto
        double salarioBruto = horasTrabajadas * pagoPorHora;

        // Calcula los descuentos de AFP y SFS
        double descuentoAfp = salarioBruto * PORCENTAJE_AFP;
        double descuentoSfs = salarioBruto * PORCENTAJE_SFS;

        // Calcula el salario neto
        double salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

        // Muestra el resultado con el nombre en mayúsculas
        Console.WriteLine($"--- Nómina de {nombre.ToUpper()} ---");
        Console.WriteLine($"Salario bruto: {salarioBruto:N2}");
        Console.WriteLine($"AFP (2.87%): {descuentoAfp:N2}");
        Console.WriteLine($"SFS (3.04%): {descuentoSfs:N2}");
        Console.WriteLine($"Salario neto: {salarioNeto:N2}");
    }
}