using System.Text;

namespace Biblioteca_de_clases
{
    public class Integrante
    {
        string[] cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Integrante() { }

        public Integrante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais):this()
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.Append($"Curso/s: ");
            foreach (string curso in cursos)
            {
                mensaje.Append($"{curso} ");
            }
            mensaje.AppendLine();
            mensaje.AppendLine($"Direccion: {direccion}");
            mensaje.AppendLine($"Edad: {edad}");
            mensaje.AppendLine($"Genero: {genero}");
            mensaje.AppendLine($"Nombre: {nombre}");
            mensaje.AppendLine($"Pais: {pais}");

            return mensaje.ToString();
        }
    }
}
