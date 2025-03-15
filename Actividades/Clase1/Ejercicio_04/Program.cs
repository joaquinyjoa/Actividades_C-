internal class Program
{
    private static void Main(string[] args)
    {
        //[A.04] Números perfectos
        Console.Title = "Ejercicio Nro 04";
        int encontrados = 0; // Contador de números perfectos encontrados
        int numero = 1; // Comenzamos a buscar desde el número 1

        Console.WriteLine("Los primeros 4 números perfectos son:");

        while (encontrados < 4) // Queremos encontrar 4 números perfectos
        {
            int sumaDivisores = 0;

            for (int i = 1; i < numero; i++) // Encontrar divisores de 'numero'
            {
                if (numero % i == 0) // Si 'i' es divisor de 'numero'
                {
                    sumaDivisores += i;
                }
            }

            if (sumaDivisores == numero) // Si la suma de los divisores es igual al número, es perfecto
            {
                Console.WriteLine(numero);
                encontrados++; // Aumentamos el contador de números perfectos encontrados
            }

            numero++; // Probamos con el siguiente número
        }
    }
}