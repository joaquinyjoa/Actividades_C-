using Cuentas;
internal class Program
{
    private static void Main(string[] args)
    {
        string nombre;
        decimal monto;
        bool continuar = true;
        int seleccion;
        int ingreso;
        int retiro;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su monto: ");
        monto = Convert.ToDecimal(Console.ReadLine());

        Cuenta cuenta = new Cuenta(nombre, monto);

        while (continuar)
        {
            Console.WriteLine("1 - Mostrar detalle de la cuenta");
            Console.WriteLine("2 - Ingresar monto");
            Console.WriteLine("3 - Retirar monto");
            Console.WriteLine("4 - Salir");
            Console.Write("Seleccione una de las opciones: ");
            seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion) 
            {
                case 1:
                    Console.WriteLine(cuenta.Mostrar());
                    break;
                case 2:
                    Console.Write("Ingrese monto: ");
                    ingreso = Convert.ToInt32(Console.ReadLine());
                    cuenta.Ingresar(ingreso);
                    Console.WriteLine(cuenta.Mostrar());
                    break;
                case 3:
                    Console.Write("Retire monto: ");
                    retiro = Convert.ToInt32(Console.ReadLine());
                    cuenta.Retirar(retiro);
                    Console.WriteLine(cuenta.Mostrar());
                    break;
                case 4:
                    continuar = false;
                    break;
            }
            
        }
    }
}