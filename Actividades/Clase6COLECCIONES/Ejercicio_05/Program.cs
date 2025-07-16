using System;
using Carrera;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creo la competencia con máximo 3 autos y 5 vueltas
        Competencia competencia = new Competencia(3, 5);

        // Creo algunos autos
        AutoF1 auto1 = new AutoF1(44, "Mercedes");
        AutoF1 auto2 = new AutoF1(33, "Red Bull");
        AutoF1 auto3 = new AutoF1(16, "Ferrari");
        AutoF1 auto4 = new AutoF1(44, "Mercedes"); // Mismo número y escudería que auto1, no debería agregarse

        // Intento agregar autos a la competencia
        Console.WriteLine("Agregando autos a la competencia...\n");

        Console.WriteLine(competencia + auto1 ? "Auto1 agregado correctamente." : "Auto1 NO pudo ser agregado.");
        Console.WriteLine(competencia + auto2 ? "Auto2 agregado correctamente." : "Auto2 NO pudo ser agregado.");
        Console.WriteLine(competencia + auto3 ? "Auto3 agregado correctamente." : "Auto3 NO pudo ser agregado.");
        Console.WriteLine(competencia + auto4 ? "Auto4 agregado correctamente." : "Auto4 NO pudo ser agregado (duplicado).");

        // Intento agregar un auto extra cuando la competencia ya está llena
        AutoF1 autoExtra = new AutoF1(7, "McLaren");
        Console.WriteLine(competencia + autoExtra ? "AutoExtra agregado correctamente." : "AutoExtra NO pudo ser agregado (competencia llena).");

        Console.WriteLine("\nDatos completos de la competencia:\n");
        Console.WriteLine(competencia.MostrarDatos());

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
