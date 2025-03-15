internal class Program
{
    private static void Main(string[] args)
    {
        //[A.02] Potencias
        Console.Title = "Ejercicio Nro 02";

        double numero;
        double cubo;
        double cuadrado;

        Console.Write("Ingrese el numero para mostrar el cubo y el cuadrado: ");
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("ERROR.¡Reingresar número!: ");
        }

        cubo = Math.Pow(numero,2);
        cuadrado = Math.Pow(numero,3);

        Console.WriteLine($"el cubo del numero es {cubo:#,###.00}");
        Console.WriteLine($"el cuadrado del numero es {cuadrado:#,###.00}");

    }
}