using Grados;
internal class Program
{
    private static void Main(string[] args)
    {
        // Instanciar objetos base
        Celsius c = new Celsius(25);           // 25°C
        Fahrenheit f = new Fahrenheit(77);     // 77°F
        Kelvin k = new Kelvin(298.15);         // 298.15 K (aprox 25°C)

        // Mostrar temperaturas iniciales
        Console.WriteLine($"Celsius: {c.GetTemperatura()} °C");
        Console.WriteLine($"Fahrenheit: {f.GetTemperatura()} °F");
        Console.WriteLine($"Kelvin: {k.GetTemperatura()} K");

        // **Conversiones implícitas y explícitas**

        // Celsius -> Fahrenheit (implícito)
        Fahrenheit fFromC = c;
        Console.WriteLine($"Celsius a Fahrenheit (implícito): {fFromC.GetTemperatura()} °F");

        // Celsius -> Kelvin (implícito)
        Kelvin kFromC = c;
        Console.WriteLine($"Celsius a Kelvin (implícito): {kFromC.GetTemperatura()} K");

        // Fahrenheit -> Celsius (explícito)
        Celsius cFromF = (Celsius)f;
        Console.WriteLine($"Fahrenheit a Celsius (explícito): {cFromF.GetTemperatura()} °C");

        // Kelvin -> Celsius (explícito)
        Celsius cFromK = (Celsius)k;
        Console.WriteLine($"Kelvin a Celsius (explícito): {cFromK.GetTemperatura()} °C");

        // Kelvin -> Fahrenheit (explícito)
        Fahrenheit fFromK = (Fahrenheit)k;
        Console.WriteLine($"Kelvin a Fahrenheit (explícito): {fFromK.GetTemperatura()} °F");

        // Fahrenheit -> Kelvin (implícito)
        Kelvin kFromF = f;
        Console.WriteLine($"Fahrenheit a Kelvin (implícito): {kFromF.GetTemperatura()} K");

        // Verificar operadores == y !=

        Celsius c2 = new Celsius(25);
        Console.WriteLine($"c == c2? {c == c2}");  // True

        Fahrenheit f2 = new Fahrenheit(77);
        Console.WriteLine($"f == f2? {f == f2}");  // True

        Kelvin k2 = new Kelvin(298.15);
        Console.WriteLine($"k == k2? {k == k2}");  // True

        // Prueba desigualdad
        Celsius c3 = new Celsius(30);
        Console.WriteLine($"c != c3? {c != c3}");  // True
    }
}