using Sobrescrito;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Sobre-Sobrescrito";
        SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();

        Console.WriteLine(objetoSobrescrito.ToString());

        string objeto = "¡Este es mi método ToString sobrescrito!";

        Console.WriteLine("----------------------------------------------");
        Console.Write("Comparación Sobrecargas con String: ");
        Console.WriteLine(objetoSobrescrito.Equals(objeto));

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine(objetoSobrescrito.GetHashCode());

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine(objetoSobrescrito.MiMetodo());

        Console.ReadKey();
    }
}