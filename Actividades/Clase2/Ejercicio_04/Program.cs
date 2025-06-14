using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro 04";
        
        int numero;
        string tabla;

        Console.Write("Ingrese un numero para multiplicar: ");
        while (!Int32.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Error. Ingrese numero para factoriar: ");
        }

        tabla = generarTabla(numero);

        Console.WriteLine(tabla);
    }

    public static string generarTabla(int numero)
    {
        StringBuilder mensaje = new StringBuilder();

        mensaje.AppendLine($"Tabla de multiplicar del numero {2}:");

        for (int i = 1; i < 10; i++)
        {
            mensaje.AppendLine($"{numero} X {i} = {numero * i}");       
        }
        return mensaje.ToString();
    }
}