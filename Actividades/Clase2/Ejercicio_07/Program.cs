using Ejercicio_07;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro.07";

        /*
         Ejercicio I08 - El tiempo pasa...

        Consigna
        Crear un método estático que reciba una fecha y calcule el número de días que pasaron
        desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.
        Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el
        número de días vividos por esa persona hasta la fecha actual utilizando el método
        desarrollado anteriormente.
        Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
         */

        int dia;
        int mes;
        int año;
        DateTime fechaDeNacimiento;

        Console.Write("Ingrese su dia de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su dia de nacimiento: ");
        año = Convert.ToInt32(Console.ReadLine());

        fechaDeNacimiento = new DateTime(año, mes, dia);

        Console.Write(CalculadoraDeDiasVividos.calcularDiasVivido(fechaDeNacimiento));
    }
}