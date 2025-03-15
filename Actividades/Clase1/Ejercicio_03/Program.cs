internal class Program
{
    private static void Main(string[] args)
    {
        //[A.03] Números primos
        Console.Title = "Ejercicio Nro 03";

        double numero;

        Console.Write("Ingrese el numero maximo de la tabla: ");
        numero = Convert.ToDouble(Console.ReadLine());

        for (int i = 2; i <= numero; i++) // Recorremos desde 2 hasta el número ingresado
        {
            bool esPrimo = true; // Suponemos que el número es primo

            for (int j = 2; j < i; j++) // Verificamos si tiene divisores (excluyendo 1 y él mismo)
            {
                if (i % j == 0) // Si es divisible por otro número, no es primo
                {
                    esPrimo = false;
                    break; // No necesitamos seguir comprobando
                }
            }

            if (esPrimo)
            {
                Console.Write(i + " ");
            }
        }
    }

}