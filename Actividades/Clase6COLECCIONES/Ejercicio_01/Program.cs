internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        int[] listaNumeros = new int[20];
        List<int> listaPositivos = new List<int>();
        List<int> listaNegativos = new List<int>();


        for (int i = 0; i < listaNumeros.Length; i++)
        {
            int numero;
            do
            {
                numero = random.Next(-100, 101); // Genera entre -100 y 100 inclusive
            } while (numero == 0); // Repite si sale 0

            listaNumeros[i] = numero;
            Console.Write($"{listaNumeros[i]} ");

            if (listaNumeros[i] > 0)
            {
                listaPositivos.Add(listaNumeros[i]);
            }

            if (listaNumeros[i] < 0)
            {
                listaNegativos.Add(listaNumeros[i]);
            }
        }

        for (int i = 0; i < listaPositivos.Count - 1; i++)
        {
            for (int j = i + 1; j <= listaPositivos.Count - 1; j++)
            {
                if (listaPositivos[j] < listaPositivos[i])
                {
                    int temp = listaPositivos[i];
                    listaPositivos[i] = listaPositivos[j];
                    listaPositivos[j] = temp;
                }
            }
        }

        Console.WriteLine();

        foreach (int item in listaPositivos)
        {
            Console.Write($"{item}, ");
        }

        for (int i = 0; i < listaNegativos.Count - 1; i++)
        {
            for (int j = i + 1; j <= listaNegativos.Count - 1; j++)
            {
                if (listaNegativos[j] > listaNegativos[i])
                {
                    int temp = listaNegativos[i];
                    listaNegativos[i] = listaNegativos[j];
                    listaNegativos[j] = temp;
                }
            }
        }

        Console.WriteLine();

        foreach (int item in listaNegativos)
        {
            Console.Write($"{item}, ");
        }

    }

}