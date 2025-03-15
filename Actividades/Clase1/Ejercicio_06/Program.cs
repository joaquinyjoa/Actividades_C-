internal class Program
{
    private static void Main(string[] args)
    {
        //[A.06] Bis sextus dies ante calendas martii
        Console.Title = "Ejercicio Nro 06";

        int inicio;
        int fin;

        Console.Write("Ingrese un año de inicio: ");
        while (!int.TryParse(Console.ReadLine(), out inicio))
        {
            Console.Write("ERROR.¡Reingresar número!: ");
        }

        if (inicio >= 0)
        {
            Console.Write("Ingrese un año de fin: ");
            while (!int.TryParse(Console.ReadLine(), out fin))
            {
                Console.Write("ERROR.¡Reingresar número!: ");
            }

            while (fin < inicio)
            {
                Console.Write("Ingrese un año de fin: ");
                while (!int.TryParse(Console.ReadLine(), out fin))
                {
                    Console.Write("ERROR.¡Reingresar número!: ");
                }
            }

            for (int i = inicio; i <= fin; i++)
            {
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    Console.WriteLine(i);
                }
            }

        }
        else
        {
            Console.Write("No pude ser un numero menor que cero");
        }

    }
}