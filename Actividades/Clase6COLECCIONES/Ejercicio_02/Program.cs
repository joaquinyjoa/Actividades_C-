internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        List<int> lista = new List<int>();
        Stack<int> pila = new Stack<int>();
        Queue<int> cola = new Queue<int>();
        List<int> listaPositivos = new List<int>();
        List<int> listaNegativos = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            int numero;
            do
            {
                numero = random.Next(-100, 101); // Genera entre -100 y 100 inclusive
            } while (numero == 0); // Repite si sale 0

            lista.Add(numero);
            pila.Push(numero);
            cola.Enqueue(numero);

            Console.Write($"{lista[i]} ");

            if (lista[i] > 0)
            {
                listaPositivos.Add(lista[i]);
            }

            if (lista[i] < 0)
            {
                listaNegativos.Add(lista[i]);
            }
        }
        Console.WriteLine();

        foreach (var item in pila)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();

        foreach (var item in cola)
        {
            Console.Write($"{item} ");
        }

        for (int i = 0; i < listaPositivos.Count - 1; i++)
        {
            for (int j = i + 1; j <= listaPositivos.Count - 1; j++)
            {
                if (listaPositivos[j] > listaPositivos[i])
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