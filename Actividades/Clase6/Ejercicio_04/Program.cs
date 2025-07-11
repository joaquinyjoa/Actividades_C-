using Clubes;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creo un equipo con capacidad máxima 3 jugadores y nombre "Tiburones"
        Equipo equipo = new Equipo(3, "Tiburones");

        // Creo jugadores
        Jugador jugador1 = new Jugador(123, "Lionel Messi", 100, 0.75f, 75);
        Jugador jugador2 = new Jugador(456, "Cristiano Ronaldo", 120, 0.8f, 96);
        Jugador jugador3 = new Jugador(789, "Neymar Jr.", 80, 0.6f, 48);
        Jugador jugador4 = new Jugador(123, "Lionel Messi", 150, 1.1f, 165); // Mismo DNI que jugador1, no debería agregarse

        // Intento agregar jugadores
        Console.WriteLine("Agregando jugadores al equipo...\n");

        if (equipo + jugador1)
            Console.WriteLine($"Jugador {jugador1.MostrarDatos()} agregado correctamente.");
        else
            Console.WriteLine("No se pudo agregar a Messi.");

        if (equipo + jugador2)
            Console.WriteLine($"Jugador {jugador2.MostrarDatos()} agregado correctamente.");
        else
            Console.WriteLine("No se pudo agregar a Cristiano Ronaldo.");

        if (equipo + jugador3)
            Console.WriteLine($"Jugador {jugador3.MostrarDatos()} agregado correctamente.");
        else
            Console.WriteLine("No se pudo agregar a Neymar Jr.");

        Console.WriteLine("Intentando agregar nuevamente a Messi con el mismo DNI...\n");

        if (equipo + jugador4)
            Console.WriteLine($"Jugador {jugador4.MostrarDatos()} agregado correctamente."); // Esto NO debería suceder
        else
            Console.WriteLine("No se pudo agregar a Messi nuevamente (jugador repetido o sin espacio).\n");

        // Intento agregar un cuarto jugador cuando ya está lleno
        Jugador jugadorExtra = new Jugador(999, "Mbappé", 70, 0.65f, 46);

        Console.WriteLine("Intentando agregar a Mbappé con el equipo lleno...\n");

        if (equipo + jugadorExtra)
            Console.WriteLine($"Jugador {jugadorExtra.MostrarDatos()} agregado correctamente."); // Esto NO debería suceder
        else
            Console.WriteLine("No se pudo agregar a Mbappé (equipo lleno).\n");

        Console.WriteLine("Prueba finalizada.");
    }
}
