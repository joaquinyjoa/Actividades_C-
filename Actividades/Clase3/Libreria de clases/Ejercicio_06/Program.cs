using Conductores;

internal class Program
{
    private static void Main(string[] args)
    {
        Conductor conductorUno = new Conductor("Jose", "1", "2", "3", "4", "5", "6", "80");
        Conductor conductorDos = new Conductor("Juan", "1", "200", "3", "4", "56", "6", "7");
        Conductor conductorTres = new Conductor("Jorge", "1", "2", "3", "4", "5", "6", "7");

        // Inicializo el array con un tamaño fijo (3 posiciones)
        Conductor[] arrayConductores = new Conductor[3];
        // Asigno instancias de Conductor a cada posición del array
        arrayConductores[0] = conductorUno;
        arrayConductores[1] = conductorDos;
        arrayConductores[2] = conductorTres;

        // Inicialización e instanciación directa con elementos
        // (el compilador infiere el tamaño del array)
        //Conductor[] arrayConductores = { conductorUno, conductorDos, conductorTres };

        arrayConductores[0].TieneFranco(4);
        arrayConductores[1].TieneFranco(2);

        for (int i = 0; i < arrayConductores.Length; i++)
        {
            Console.WriteLine(arrayConductores[i].Mostrar());
        }

        int sumaConductorUno = arrayConductores[0].SumarKilometrosSemana();
        int sumaConductorDos = arrayConductores[1].SumarKilometrosSemana();
        int sumaConductorTres = arrayConductores[2].SumarKilometrosSemana();

        if (sumaConductorUno > sumaConductorDos && sumaConductorUno > sumaConductorTres)
        {
            Console.WriteLine($"El conductor {arrayConductores[0].GetNombre()} hizo {sumaConductorUno} KM");
        }
        else if (sumaConductorDos > sumaConductorUno && sumaConductorDos > sumaConductorTres)
        {
            Console.WriteLine($"El conductor {arrayConductores[1].GetNombre()} hizo {sumaConductorDos} KM");
        }
        else if (sumaConductorTres > sumaConductorDos && sumaConductorTres > sumaConductorUno)
        {
            Console.WriteLine($"El conductor {arrayConductores[2].GetNombre()} hizo {sumaConductorTres} KM");
        }

        Console.WriteLine($"Con más km en Día 3: {arrayConductores.MaxBy(c => c.ObtenerKilometrosPorDia(3))?.GetNombre()}");
        Console.WriteLine($"Con más km en Día 5: {arrayConductores.MaxBy(c => c.ObtenerKilometrosPorDia(5))?.GetNombre()}");
    }
}