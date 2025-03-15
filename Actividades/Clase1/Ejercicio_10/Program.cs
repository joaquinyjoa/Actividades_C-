internal class Program
{
    private static void Main(string[] args)
    {
        //[A.10] Dibujando un triángulo equilátero
        Console.Title = "Ejercicio Nro 10";

        int numero;

        Console.Write("Ingrese numero de filas para el triangulo rectangulo: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numero; i++)
        {
            for (int j = 0; j < numero - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2*i-1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}