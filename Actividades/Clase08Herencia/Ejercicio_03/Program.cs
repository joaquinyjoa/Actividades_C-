using Carrera;
using System;

class Program
{
    static void Main()
    {
        // Creo una competencia de MotoCross con 5 competidores y 10 vueltas
        Competencia competenciaMoto = new Competencia(5, 10, TipoCompetencia.MotoCross);

        // Creo algunos vehículos MotoCross
        MotoCross moto1 = new MotoCross(1, "Escuderia A", 250);
        MotoCross moto2 = new MotoCross(2, "Escuderia B", 300);

        // Intento agregar motos a la competencia
        bool agregado1 = competenciaMoto + moto1;
        bool agregado2 = competenciaMoto + moto2;

        Console.WriteLine($"Moto 1 agregado: {agregado1}");
        Console.WriteLine($"Moto 2 agregado: {agregado2}");

        // Creo una competencia de F1 con 3 competidores y 20 vueltas
        Competencia competenciaF1 = new Competencia(3, 20, TipoCompetencia.F1);

        // Creo autos F1
        AutoF1 auto1 = new AutoF1(10, "Escuderia F1", 900);
        AutoF1 auto2 = new AutoF1(11, "Escuderia F2", 920);

        // Intento agregar autos a la competencia F1
        bool autoAgregado1 = competenciaF1 + auto1;
        bool autoAgregado2 = competenciaF1 + auto2;

        Console.WriteLine($"Auto 1 agregado: {autoAgregado1}");
        Console.WriteLine($"Auto 2 agregado: {autoAgregado2}");

        // Mostrar datos de competencia MotoCross
        Console.WriteLine("\nDatos competencia MotoCross:");
        Console.WriteLine(competenciaMoto.MostrarDatos());

        // Mostrar datos de competencia F1
        Console.WriteLine("\nDatos competencia F1:");
        Console.WriteLine(competenciaF1.MostrarDatos());

        // Intentar agregar un AutoF1 a la competencia MotoCross (debería fallar)
        bool intentoFallido = competenciaMoto + auto1;
        Console.WriteLine($"Intento de agregar AutoF1 a MotoCross: {intentoFallido}");

        // Intentar agregar una MotoCross a la competencia F1 (debería fallar)
        bool intentoFallido2 = competenciaF1 + moto1;
        Console.WriteLine($"Intento de agregar MotoCross a F1: {intentoFallido2}");
    }
}
