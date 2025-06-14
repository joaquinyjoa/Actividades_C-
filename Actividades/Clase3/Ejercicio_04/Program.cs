using Boligrafos;

internal class Program
{
    private static void Main(string[] args)
    {
        Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
        Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
        string dibujo;

        //obtener color
        Console.WriteLine($"El color de la lapicera es: {azul.GetColor()}");
        Console.WriteLine($"El color de la lapicera es: {rojo.GetColor()}");

        //obtener las cantidades
        Console.WriteLine($"La cantidad de la lapicera {azul.GetColor()} es: {azul.GetTinta()}");
        Console.WriteLine($"La cantidad de la lapicera {rojo.GetColor()} es: {rojo.GetTinta()}");

        Console.WriteLine(azul.Pintar(-110,out dibujo));
        Console.WriteLine(rojo.Pintar(-10, out dibujo));

        //obtener las cantidades
        Console.WriteLine($"La cantidad de la lapicera {azul.GetColor()} es: {azul.GetTinta()}");
        Console.WriteLine($"La cantidad de la lapicera {rojo.GetColor()} es: {rojo.GetTinta()}");

        azul.Recargar();
        rojo.Recargar();

        //obtener las cantidades
        Console.WriteLine($"La cantidad de la lapicera {azul.GetColor()} recargada: {azul.GetTinta()}");
        Console.WriteLine($"La cantidad de la lapicera {rojo.GetColor()} recargada: {rojo.GetTinta()}");

        Console.WriteLine(azul.Pintar(0, out dibujo));
        Console.WriteLine(rojo.Pintar(-90, out dibujo));

        //obtener las cantidades
        Console.WriteLine($"La cantidad de la lapicera {azul.GetColor()} es: {azul.GetTinta()}");
        Console.WriteLine($"La cantidad de la lapicera {rojo.GetColor()} es: {rojo.GetTinta()}");
    }
}