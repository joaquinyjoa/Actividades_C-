using ExcepcionesClases;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            OtraClase otraClase = new OtraClase();
            otraClase.MetodoDeInstancia();
        }
        catch (MiExcepcion ex)
        {
            // Mostramos el mensaje principal
            Console.WriteLine($"Excepción capturada: {ex.Message}");

            // Recorremos todas las InnerExceptions
            Exception inner = ex.InnerException;
            while (inner != null)
            {
                Console.WriteLine($"InnerException: {inner.Message}");
                inner = inner.InnerException;
            }

        }
    }
}