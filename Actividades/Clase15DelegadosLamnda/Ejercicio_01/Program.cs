using Ejercicio_01;

public delegate void DelegadoSaludar();

internal class Program
{
    

    private static void Main(string[] args)
    {
        DelegadoSaludar delegadoSaludar = Saludar;
        Temporizador.Esperar(new Random().Next(1000, 3000), delegadoSaludar);
    }

    static void Saludar() 
    {
        Console.WriteLine("HOLA MUNDO");
    }
}