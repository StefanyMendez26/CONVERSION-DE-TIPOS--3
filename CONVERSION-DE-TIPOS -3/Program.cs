using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("EJERCICIO 3!");

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese un número decimal: ");
        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            int truncado = (int)numero; // Conversión con truncamiento
            Console.WriteLine($"Valor original: {numero}");
            Console.WriteLine($"Valor truncado: {truncado}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingrese un número decimal válido.");
        }
    }
}
