using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Persona p = new Persona("Julieta", "Esquialia");

        // Intento serializar (debería fallar por nombre inválido de archivo)
        Persona.Guardar(p);

        // Intento leer (debería fallar también)
        Persona personaLeida = Persona.Leer();

        if (personaLeida != null)
            Console.WriteLine(personaLeida);
        else
            Console.WriteLine("No se pudo leer la persona.");

        Console.ReadLine();
        
    }
}

public class Persona
{
    private string nombre;
    private string apellido;

    public Persona() { }

    public Persona(string nombre, string apellido): this()
    {
        this.nombre = nombre;
        this.apellido = apellido;
    }

    public string Nombre { get; set; }
    public string Apellido { get; set; }


    public static void Guardar(Persona p) 
    {
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(".xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                xmlSerializer.Serialize(streamWriter, p);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de argumento: {ex.Message}");
        }
        catch (InvalidOperationException ex) 
        {
            Console.WriteLine($"Error en la serialización: {ex.Message}");
        }
    }

    public static Persona Leer() 
    {
        try
        {
             using (StreamReader streamReader = new StreamReader(".xml")) 
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                Persona persona = xmlSerializer.Deserialize(streamReader) as Persona;
            
                return persona;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de argumento: {ex.Message}");
        }

        return null;
    }

    public override string ToString() 
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nombre: {nombre}");
        sb.AppendLine($"Apellido: {apellido}");

        return sb.ToString();
    }

    public static void GuardarJson(Persona p) 
    {
        try
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(p, opciones);

            File.WriteAllText(".json", jsonString);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de argumento: {ex.Message}");
        }
    }

    public static Persona LeerJson() 
    {
        try
        {
            string jsonString = File.ReadAllText(".json");

            Persona p = JsonSerializer.Deserialize<Persona>(jsonString);

            return p;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de argumento: {ex.Message}");
        }
        return null;
    }
}