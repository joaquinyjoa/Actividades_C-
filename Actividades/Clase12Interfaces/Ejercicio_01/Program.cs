using Cartuchera;
internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor colorOriginal = Console.ForegroundColor;

        Lapiz miLapiz = new Lapiz(10);
        Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

        EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
        
        try 
        { 
            ((IAcciones)miLapiz).Color = ConsoleColor.Red;  
        }catch(Exception ex) 
        { 
            Console.WriteLine("No se puede cambiar de color el lapiz"); 
        }

        Console.ForegroundColor = ((IAcciones)miLapiz).Color;
        Console.WriteLine(eLapiz.texto);
        Console.ForegroundColor = colorOriginal;
        Console.WriteLine(miLapiz);

        Console.WriteLine($"Unidad total del lapiz: {((IAcciones)miLapiz).UnidadesDeEscritura}");

        EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
        Console.ForegroundColor = eBoligrafo.color;
        Console.WriteLine(eBoligrafo.texto);
        Console.ForegroundColor = colorOriginal;
        Console.WriteLine(miBoligrafo);

        Console.WriteLine($"Unidad total del boligrafo: {miBoligrafo.UnidadesDeEscritura}");

        //RECARGA
        Console.WriteLine($"Recarga del boligrafo {miBoligrafo.Recargar(10)}");
        Console.WriteLine($"Recarga del lapiz {((IAcciones)miLapiz).Recargar(10)}");

        //TOTAL DE RECARGA
        Console.WriteLine($"Unidad total del lapiz recargado: {((IAcciones)miLapiz).UnidadesDeEscritura}");
        Console.WriteLine($"Unidad total del boligrafo recargado: {miBoligrafo.UnidadesDeEscritura}");

        //RECARGA
        Console.WriteLine($"Recarga del boligrafo {miBoligrafo.Recargar(-1)}");
        try
        {
            Console.WriteLine($"Recarga del lapiz {((IAcciones)miLapiz).Recargar(-10)}");
        }
        catch (NotImplementedException) 
        {
            Console.WriteLine("No se pueden recargar la lapicera");
        }

        // 1. Crear objeto CartucheraSimple y cargar listas
        CartucheraSimple cartucheraSimple = new CartucheraSimple()
        {
            boligrafos = new List<Boligrafo>()
            {
                new Boligrafo(5, ConsoleColor.Blue),
                new Boligrafo(10, ConsoleColor.Red)
            },
            lapizs = new List<Lapiz>()
            {
                new Lapiz(7),
                new Lapiz(3)
            }
        };

        // 2. Crear objeto CartucheraMultiuso y cargar lista
        CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso()
        {
            acciones = new List<IAcciones>()
            {
                new Boligrafo(5, ConsoleColor.Green),
                new Lapiz(8)
            }
        };

        // 3. Llamar a RecorrerElementos hasta que alguno retorne false
        bool simpleContinua, multiusoContinua;
        int iteracion = 1;

        do
        {
            Console.WriteLine($"Iteración {iteracion}:");

            simpleContinua = cartucheraSimple.RecorrerElementos();
            multiusoContinua = cartucheraMultiuso.RecorrerElementos();

            Console.WriteLine($"CartucheraSimple continúa? {simpleContinua}");
            Console.WriteLine($"CartucheraMultiuso continúa? {multiusoContinua}");
            Console.WriteLine();

            iteracion++;

        } while (simpleContinua && multiusoContinua);

        Console.WriteLine("Alguna cartuchera ya no puede gastar más unidades.");
    }

    Console.ReadKey();
    }
}