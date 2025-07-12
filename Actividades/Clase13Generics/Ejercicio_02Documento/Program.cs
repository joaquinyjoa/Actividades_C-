using BibliotecaContabilidad;
internal class Program
{
    private static void Main(string[] args)
    {
        // Creo la instancia de Contabilidad para Recibo (T) y Factura (U)
        Contabilidad<Recibo, Factura> contabilidad = new Contabilidad<Recibo, Factura>();

        // Creo algunos egresos (Recibos)
        Recibo r1 = new Recibo(101);
        Recibo r2 = new Recibo(102);

        // Creo algunos ingresos (Facturas)
        Factura f1 = new Factura(201);
        Factura f2 = new Factura(202);

        // Agrego los egresos y muestro mensajes
        contabilidad += r1;
        Console.WriteLine($"Agregado egreso: Recibo #{r1.Numero}");
        contabilidad += r2;
        Console.WriteLine($"Agregado egreso: Recibo #{r2.Numero}");

        // Agrego los ingresos y muestro mensajes
        contabilidad += f1;
        Console.WriteLine($"Agregado ingreso: Factura #{f1.Numero}");
        contabilidad += f2;
        Console.WriteLine($"Agregado ingreso: Factura #{f2.Numero}");

    }
}