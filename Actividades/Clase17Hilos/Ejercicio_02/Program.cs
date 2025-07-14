using Clientes;
internal class Program
{
    private static void Main(string[] args)
    {
        // Instancia delegado (como te mostré antes)
        Caja.DelegadoClienteAtendido delegado = (caja, cliente) =>
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja.");
        };

        Caja caja1 = new Caja("Caja 01", delegado);
        Caja caja2 = new Caja("Caja 02", delegado);

        List<Caja> cajas = new List<Caja> { caja1, caja2 };
        Negocio negocio = new Negocio(cajas);

        Console.WriteLine("Asignando cajas...");
        List<Task> tareas = negocio.ComenzarAtencion();

        Task.WaitAll(tareas.ToArray()); // esperamos que terminen
    }
}