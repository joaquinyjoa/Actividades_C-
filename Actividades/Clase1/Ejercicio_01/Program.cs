internal class Program
{
    private static void Main(string[] args)
    {
        //[A.01] Máximos, mínimos y promedios
        Console.Title = "Ejercicio Nro 01";

        int ingreso = 5;
        double numero;
        double maximo = 0;
        double minimo = 0;
        double suma = 0;
        double promedio;

        for (int i = 0; i < ingreso; i++)
        {
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            suma += numero;

            if (i == 0)
            {
                maximo = numero;
                minimo = numero;
            }
            else 
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }
            }
        }

        promedio = suma / ingreso;

        Console.WriteLine($"El numero maximo es {maximo:#,###.00}");
        Console.WriteLine($"El numero minimo es {minimo:#,###.00}");
        Console.WriteLine($"El promedio de todos los numeros es {promedio:#,###.00}");
    }
}