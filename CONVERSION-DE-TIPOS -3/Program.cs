using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("EJERCICIO 3!");

class Programa
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un número decimal
        Console.Write("Ingrese un número decimal: ");

        // Leer la entrada del usuario y convertirla a double
        if (double.TryParse(Console.ReadLine(), out double valorOriginal))
        {
            // Truncar el valor eliminando los decimales
            int valorTruncado = (int)valorOriginal;

            // Mostrar los valores
            Console.WriteLine($"Valor original: {valorOriginal}");
            Console.WriteLine($"Valor truncado: {valorTruncado}");
            Console.WriteLine("El número ha sido truncado sin redondear.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Asegúrese de ingresar un número decimal.");
        }
    }
}
