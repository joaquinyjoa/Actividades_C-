using Calculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        //Intancia del objeto y se inicializa
        Sumador s1 = new Sumador(1);

        int valor = (int)s1;

        //Punto 1
        Console.WriteLine($"Generar una conversión explícita que retorne cantidadSumas: {valor}");

        //Punto 2
        Sumador s2 = new Sumador(1);

        long resultado = s1 + s2;

        Console.WriteLine($"Resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento: {resultado}");

        //Punto 3
        bool bandera = s1 != s2;
        Console.WriteLine(bandera);
    }
}