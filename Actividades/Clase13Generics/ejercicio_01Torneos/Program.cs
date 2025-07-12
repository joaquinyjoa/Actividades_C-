using BibliotecaTorneo;
internal class Program
{
    private static void Main(string[] args)
    {
        // Crear torneos
        Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo Nacional de Fútbol");
        Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo Nacional de Basquet");

        // Crear equipos de fútbol
        EquipoFutbol river = new EquipoFutbol("River Plate", new DateTime(1901, 5, 25));
        EquipoFutbol boca = new EquipoFutbol("Boca Juniors", new DateTime(1905, 4, 3));
        EquipoFutbol independiente = new EquipoFutbol("Independiente", new DateTime(1905, 8, 4));

        // Crear equipos de básquet
        EquipoBasquet sanLorenzo = new EquipoBasquet("San Lorenzo", new DateTime(1930, 10, 25));
        EquipoBasquet pebete = new EquipoBasquet("Pebete", new DateTime(1975, 12, 1));
        EquipoBasquet locos = new EquipoBasquet("Locos del Basket", new DateTime(2000, 1, 5));

        // Agregar equipos a torneos
        // Agregar equipos de fútbol
        if (torneoFutbol + river)
            Console.WriteLine($"Agregado: {river.Ficha()}");
        else
            Console.WriteLine($"No se agregó: {river.Ficha()}");

        if (torneoFutbol + boca)
            Console.WriteLine($"Agregado: {boca.Ficha()}");
        else
            Console.WriteLine($"No se agregó: {boca.Ficha()}");

        if (torneoFutbol + independiente)
            Console.WriteLine($"Agregado: {independiente.Ficha()}");
        else
            Console.WriteLine($"No se agregó: {independiente.Ficha()}");

        Console.WriteLine();

        // Agregar equipos de básquet
        if (torneoBasquet + sanLorenzo)
            Console.WriteLine($"Agregado: {sanLorenzo.Ficha()}");
        else
            Console.WriteLine($"No se agregó: {sanLorenzo.Ficha()}");

        if (torneoBasquet + pebete)
            Console.WriteLine($"Agregado: {pebete.Ficha()}");
        else
            Console.WriteLine($"No se agregó: {pebete.Ficha()}");

        if (torneoBasquet + locos)
            Console.WriteLine($"Agregado: {locos.Ficha()}");
        else
            Console.WriteLine($"No se agregó: {locos.Ficha()}");

        Console.WriteLine();

        // Mostrar los torneos
        Console.WriteLine(torneoFutbol.Mostrar());
        Console.WriteLine();
        Console.WriteLine(torneoBasquet.Mostrar());
        Console.WriteLine();

        // Jugar partidos de fútbol
        Console.WriteLine("FÚTBOL:");
        Console.WriteLine(torneoFutbol.JugarPartido);
        Console.WriteLine(torneoFutbol.JugarPartido);
        Console.WriteLine(torneoFutbol.JugarPartido);

        Console.WriteLine();

        // Jugar partidos de básquet
        Console.WriteLine("BÁSQUET:");
        Console.WriteLine(torneoBasquet.JugarPartido);
        Console.WriteLine(torneoBasquet.JugarPartido);
        Console.WriteLine(torneoBasquet.JugarPartido);
    }
}