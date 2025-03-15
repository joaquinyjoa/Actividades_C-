using Ejercicio_01;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio I01 - Validador de rangos
        Console.Title = "Ejercicio Nro 1";

        int numero;
        int minimo = -100;
        int maximo = 100;
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

            validar = Validador.Validar(numero, minimo, maximo);

            if (validar == false)
            {
                suma -= numero;
                i--;
            }

            suma += numero;
        }
        
        promedio = suma / numerosIngresados;


        Console.Write($"Promedio: {promedio}");
    }
}