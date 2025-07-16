using Billetera;
internal class Program
{
    private static void Main(string[] args)
    {
        Peso p1 = new Peso();
        Peso p2 = new Peso(10);
        

        Dolar d1 = new Dolar();
        Dolar d2 = new Dolar(10);
        

        Euro e1 = new Euro();
        Euro e2 = new Euro(20);

        //Sobrecarga implicita
        Dolar d3 = 560;
        Peso p3 = 100;
        Euro e3 = 850;

        //OBJ Peso
        Console.WriteLine(p1.GetCantidad());
        Console.WriteLine(p2.GetCantidad());
        Console.WriteLine(p3.GetCantidad());
        Console.WriteLine();

        //OBJ Dolar
        Console.WriteLine(d1.GetCantidad());
        Console.WriteLine(d2.GetCantidad());
        Console.WriteLine(d3.GetCantidad());
        Console.WriteLine();

        //OBJ Dolar
        Console.WriteLine(e1.GetCantidad());
        Console.WriteLine(e2.GetCantidad());
        Console.WriteLine(e3.GetCantidad());
        Console.WriteLine();

        //Sobrecarga Operadores
        if (p3 == d3)
        {
            Console.WriteLine("Tienen la misma cantidad");
        }
        else
        {
            Console.WriteLine("No tienen la misma cantidad");
        }

        if (p3 == e3)
        {
            Console.WriteLine("Tienen la misma cantidad");
        }
        else
        {
            Console.WriteLine("No tienen la misma cantidad");
        }

        Console.WriteLine();

        //Sobrecarga explicita
        Euro e4 = (Euro)p3;
        Euro e5 = (Euro)d3;

        Dolar d4 = (Dolar)p3;
        Dolar d5 = (Dolar)e3;

        Peso p4 = (Peso)e3;
        Peso p5 = (Peso)d3;

        Console.WriteLine(p4.GetCantidad());
        Console.WriteLine(p5.GetCantidad());
        Console.WriteLine();

        Console.WriteLine(d4.GetCantidad());
        Console.WriteLine(d5.GetCantidad());
        Console.WriteLine();

        Console.WriteLine(e4.GetCantidad());
        Console.WriteLine(e5.GetCantidad());
        Console.WriteLine();

        //sobrecarga operador +
        Dolar suma1 = d4 + e2;
        Console.WriteLine($"Suma Dolar + Euro: {d4.GetCantidad()} + {e2.GetCantidad()} = {suma1.GetCantidad()}");

        Dolar resta1 = d4 - e2;
        Console.WriteLine($"Resta Dolar - Euro: {d4.GetCantidad()} - {e2.GetCantidad()} = {resta1.GetCantidad()}");

        Dolar suma2 = d4 + p2;
        Console.WriteLine($"Suma Dolar + Peso: {d4.GetCantidad()} + {p2.GetCantidad()} = {suma2.GetCantidad()}");

        Dolar resta2 = d4 - p2;
        Console.WriteLine($"Resta Dolar - Peso: {d4.GetCantidad()} - {p2.GetCantidad()} = {resta2.GetCantidad()}");
    }
}