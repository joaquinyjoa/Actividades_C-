using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        // Moto
        Moto moto = new Moto(2, 0, Colores.Rojo, 150);
        Console.WriteLine("Moto creada.");

        // Automovil
        Automovil auto = new Automovil(4, 4, Colores.Azul, 5, 5);
        Console.WriteLine("Automóvil creado.");

        // Camión
        Camion camion = new Camion(6, 2, Colores.Gris, 12, 15000);
        Console.WriteLine("Camión creado.");

        Console.WriteLine("Vehículos creados correctamente.");
    }
}