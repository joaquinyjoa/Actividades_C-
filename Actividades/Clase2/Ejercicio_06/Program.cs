using Ejercicio_06;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro.06";
        /*
         Ejercicio I07 - Pitágoras estaría orgulloso
        Consigna
        Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un
        triángulo en centímetros.
        El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de
        pitágoras y
        Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
        Mostrar el resultado en la consola.
         */
        double basee;
        double altura;

        Console.Write("Ingrese la base del triangulo: ");
        basee = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del triangulo: ");
        altura = double.Parse(Console.ReadLine());

        Console.Write($"{calculadoraPitagoras.CalcularHipotenusa(basee, altura)}");
    }
}