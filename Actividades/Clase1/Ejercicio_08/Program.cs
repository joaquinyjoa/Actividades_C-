internal class Program
{
    private static void Main(string[] args)
    {
        //[A.08] Recibos de sueldo
        Console.Title = "Ejercicio Nro 08";

        long hora;
        string nombre;
        long antiguedad;
        long valorHorasTrabajadas;
        long empleados;
        double bruto;
        double descuento;
        double sueldoNeto;
        double totalSueldosNeto = 0;

        Console.Write("Ingrese la cantidad de empleados: ");
        while (!Int64.TryParse(Console.ReadLine(), out empleados))
        {
            Console.Write("Entrada inválida. Ingrese la cantidad de empleados: ");
        }

        Console.Write("Ingrese el valor de las horas: ");
        while (!Int64.TryParse(Console.ReadLine(), out valorHorasTrabajadas))
        {
            Console.Write("Entrada inválida. Ingrese la cantidad de empleados: ");
        }

        for (int i = 0; i < empleados; i++)
        {
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la antiguedad del empleado: ");
            while (!Int64.TryParse(Console.ReadLine(), out antiguedad))
            {
                Console.Write("Entrada inválida. Ingrese la antiguedad del empleado: ");
            }

            Console.Write("Ingrese la cantidad de horas del empleado: ");
            while (!Int64.TryParse(Console.ReadLine(), out hora))
            {
                Console.Write("Entrada inválida. Ingrese la cantidad de horas del empleado: ");
            }

            bruto = (valorHorasTrabajadas * hora) + (antiguedad * 15000);
            descuento = bruto * 0.13;
            sueldoNeto = bruto - descuento;
            totalSueldosNeto += sueldoNeto;

            Console.WriteLine($"Empleado: {nombre}");
            Console.WriteLine($"Horas aportadas: {hora}");
            Console.WriteLine($"Antiguedad: {antiguedad}");
            Console.WriteLine($"el total a cobrar en bruto,: {bruto}");
            Console.WriteLine($"total de descuentos : {descuento}");

        }

        Console.Write($"valor neto a cobrar de los empleados: {totalSueldosNeto}");
    }
}