internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro 05";

        Console.Write("Ingrese un número límite: ");
        int limite = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Centros numéricos hasta {limite}:");

        for (int candidato = 1; candidato <= limite; candidato++) // Recorremos desde 1 hasta el límite ingresado
        {
            int sumaIzquierda = 0;

            for (int i = 1; i < candidato; i++) // Sumamos los números antes del candidato
            {
                sumaIzquierda += i;
            }

            int sumaDerecha = 0;
            for (int j = candidato + 1; sumaDerecha < sumaIzquierda; j++) // Sumamos los números después del candidato
            {
                sumaDerecha += j;
            }

            if (sumaIzquierda == sumaDerecha) // Si ambas sumas son iguales, encontramos un centro numérico
            {
                Console.WriteLine(candidato);
            }
        }
    }

}