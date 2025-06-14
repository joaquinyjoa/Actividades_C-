using Personas;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime fechaUno = new DateTime(2004, 12, 9);
        DateTime fechaDos = new DateTime(2005, 4, 10);
        DateTime fechaTres = new DateTime(2009, 5, 8);

        Persona personaUno = new Persona("Juan", fechaUno.Date, 46013501);
        Persona personaDos = new Persona("KIKI", fechaDos.Date, 850001);
        Persona personaTres = new Persona("Lucy", fechaTres.Date, 495004);

        Console.WriteLine(personaUno.Mostrar());
        Console.WriteLine(personaDos.Mostrar());
        Console.WriteLine(personaTres.Mostrar());

        Persona[] personas = { personaUno, personaDos, personaTres };

        foreach (var persona in personas)
        {
            Console.WriteLine($"{persona.Nombre} {persona.EsMayorDeEdad()}");
        }
    }
}