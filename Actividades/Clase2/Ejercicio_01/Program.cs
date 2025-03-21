using Ejercicio_01;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio I01 - Validador de rangos
        Console.Title = "Ejercicio Nro 1";

        int numero;
        int valorMinimo = -100;
        int valorMaximo = 100;
        int maximo = 0;
        int minimo = 0;
        bool validar;
        int suma = 0;
        double promedio;
        int numerosIngresados = 10;

        for (int i = 0; i < numerosIngresados; i++)
        {
            Console.Write("Ingrese un numero: ");
            while (!Int32.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Error. Ingrese un numero: ");
            }

            validar = Validador.Validar(numero, valorMinimo, valorMaximo);

            if (validar == false)
            {
                i--;
                Console.WriteLine("Ingrese un numero entre -100 y 100");
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

                suma += numero;
            }
        }
        
        promedio = suma / numerosIngresados;


        Console.Write($"Promedio: {promedio}");
    }
}