using Biblioteca;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro libro = new Libro();

        // SET: Guardar valores
        libro[0] = "Capítulo 1: El comienzo";
        libro[2] = "Capítulo 3: El regreso";

        // GET: Leer valores y validar
        if (libro[0] == "Capítulo 1: El comienzo")
            Console.WriteLine("OK: Página 0 correcta");
        else
            Console.WriteLine("ERROR: Página 0 incorrecta");

        if (libro[1] == string.Empty)
            Console.WriteLine("OK: Página 1 vacía (no asignada)");
        else
            Console.WriteLine("ERROR: Página 1 debería estar vacía");

        if (libro[2] == "Capítulo 3: El regreso")
            Console.WriteLine("OK: Página 2 correcta");
        else
            Console.WriteLine("ERROR: Página 2 incorrecta");

        if (libro[5] == string.Empty)
            Console.WriteLine("OK: Página 5 vacía (fuera de rango)");
        else
            Console.WriteLine("ERROR: Página 5 debería estar vacía");
    }
}
