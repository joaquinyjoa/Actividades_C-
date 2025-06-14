using System;
using Geometria;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear puntos
        Punto p1 = new Punto(2, 3);
        Punto p3 = new Punto(8, 10);

        // Crear rectángulo
        Rectangulo rectangulo = new Rectangulo(p1, p3);

        // Mostrar los datos
        MostrarDatos(rectangulo);
    }

    static void MostrarDatos(Rectangulo rect)
    {
        Console.WriteLine("Datos del Rectángulo:");
        Console.WriteLine($"Vértice 1: ({rect.GetVertice1().GetX()}, {rect.GetVertice1().GetY()})");
        Console.WriteLine($"Vértice 2: ({rect.GetVertice2().GetX()}, {rect.GetVertice2().GetY()})");
        Console.WriteLine($"Vértice 3: ({rect.GetVertice3().GetX()}, {rect.GetVertice3().GetY()})");
        Console.WriteLine($"Vértice 4: ({rect.GetVertice4().GetX()}, {rect.GetVertice4().GetY()})");
        Console.WriteLine($"Área: {rect.GetArea()}");
        Console.WriteLine($"Perímetro: {rect.GetPerimetro()}");
    }
}
