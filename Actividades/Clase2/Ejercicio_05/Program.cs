using Ejercicio_05;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro. 05";

        Console.WriteLine(calculadorDelArea.CalcularAreaCirculo(4.5));
        Console.WriteLine(calculadorDelArea.CalcularAreaCuadrado(4));
        Console.WriteLine(calculadorDelArea.CalcularAreaTriangulo(45,5));
    }
}