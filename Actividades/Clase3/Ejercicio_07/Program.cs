using Veterinaria;

internal class Program
{
    private static void Main(string[] args)
    {
        //1
        DateTime fechaPerro = new DateTime(2004, 09, 12);

        Cliente clienteUno = new Cliente("calle 103", "Jose", "lolo", 11124212341, 1);
        Mascota perro = new Mascota("perro", "jojo", fechaPerro.Date, 0);

        Mascota[] clientePerro = { perro };

        clienteUno.AgregarMascota(clientePerro, 0);

        Console.WriteLine(clienteUno.ToString());

        Console.WriteLine();

        //2
        DateTime fechaGatoVacuna = new DateTime(2004, 08, 12);

        Cliente clientedos = new Cliente("calle 104", "Jose", "lolo", 4545646545, 1);
        Mascota gatoVacuna = new Mascota("Gato", "jeje", fechaGatoVacuna.Date, 1);

        Mascota[] clienteGato = { gatoVacuna };

        gatoVacuna.AgregarVacuna("Triple Felina", 0);
        clientedos.AgregarMascota(clienteGato, 0);

        Console.WriteLine(clientedos.ToString());

        Console.WriteLine();

        //3
        DateTime fechaGato = new DateTime(2004, 08, 12);
        DateTime fechaPerroVacuna = new DateTime(2004, 09, 12);

        Cliente clienteTres = new Cliente("calle 104", "Joa", "lolo", 4454214, 2);
        Mascota gato = new Mascota("Gato", "YU", fechaGato.Date, 0);
        Mascota perroVacuna = new Mascota("Perro", "GI", fechaPerroVacuna.Date, 1);

        perroVacuna.AgregarVacuna("Rabia", 0);

        Mascota[] clienteVarios = { gato, perroVacuna};
        int ancho = clienteTres.ObtenerAnchoArray() - 1;

        clienteTres.AgregarMascota(clienteVarios, ancho);
        

        Console.WriteLine(clienteTres.ToString());
    }
}