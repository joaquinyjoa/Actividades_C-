
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio A01 - Calcular un factorial
        Console.Title = "Ejercicio Nro 03";

        int numero;
        int resultado = 0;

        Console.Write("Ingrese numero para factoriar: ");
        while (!Int32.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Error. Ingrese numero para factoriar: ");
        }

        resultado = CalcularFactorial(numero);

        Console.WriteLine($"resultado del {numero}!: {resultado}");

    }

    public static int CalcularFactorial(int numero) 
    {
        int resultado = numero;
        for (int i = 1; i < numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}