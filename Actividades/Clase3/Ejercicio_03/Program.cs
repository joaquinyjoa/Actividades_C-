using Estudiantes;

internal class Program
{
    private static void Main(string[] args)
    {
        //inicializacion de los objetos
        Estudiante estudianteUno = new Estudiante("JAJAJA", 45, "JOse") ;
        Estudiante estudianteDos = new Estudiante("JSJSJSJ", 47, "Juan");
        Estudiante estudianteTres = new Estudiante("JEJEJES", 46, "JOJO");


        //Notas de los estudiantes
        estudianteUno.SetNotaPrimerParcial(6);
        estudianteUno.SetNotaSegundoParcial(6);

        estudianteDos.SetNotaPrimerParcial(10);
        estudianteDos.SetNotaSegundoParcial(8);

        estudianteTres.SetNotaPrimerParcial(2);
        estudianteTres.SetNotaSegundoParcial(2);

        //mostrar los datos de los estudiantes
        Console.WriteLine(estudianteUno.Mostrar());
        Console.WriteLine(estudianteDos.Mostrar());
        Console.WriteLine(estudianteTres.Mostrar());
       
    }
}