using Ejercicio_02;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio I04 - La calculadora
        Console.Title = "Ejercicio Nro 02";

        int primerOpérador;
        int segundoOperador;
        double resultado;
        string opeacionMatematica;
        bool seleccion = true;

        while (seleccion)
        {
            Console.Write("Ingrese primer operador: ");
            while (!Int32.TryParse(Console.ReadLine(), out primerOpérador))
            {
                Console.Write("Error. Ingrese un numero: ");
            }

            Console.Write("Ingrese segundo operador: ");
            while (!Int32.TryParse(Console.ReadLine(), out segundoOperador))
            {
                Console.Write("Error. Ingrese un numero: ");
            }

            Console.Write("Ingrese el operador matematico (+ * /): ");
            opeacionMatematica = Console.ReadLine();


            resultado = Calculadora.Calcular(primerOpérador, segundoOperador, opeacionMatematica);


            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}