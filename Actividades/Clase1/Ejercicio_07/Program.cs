internal class Program
{
    private static void Main(string[] args)
    {
        //[A.07] ¿Cuántos días viviste?
        Console.Title = "Ejercicio Nro 07";

        int dia;
        int mes;
        int año;
        TimeSpan diasVividos;

        Console.Write("Ingrese dia de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese año de nacimiento: ");
        año = Convert.ToInt32(Console.ReadLine());
        
        DateTime fechaDeNacimiento = new DateTime(año,mes,dia);
        DateTime sistema = DateTime.Now;

        diasVividos = sistema - fechaDeNacimiento;

        if ((año % 400 == 0) || (año % 4 == 0 && año % 100 != 0))
        {
            Console.WriteLine("Este es año es bisiesto");
        }
        else
        {
            Console.WriteLine("Este es año no es bisiesto");
        }

        Console.Write($"Estos son los años que viviste: {diasVividos.Days}");
    }
}