using System.Text;

namespace Estudiantes
{
    public class Estudiante
    {
        private string apellido;
        private int legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante() 
        {
            random = new Random();
        }

        public Estudiante(string apellido, int legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public double CalcularNotaFinal() 
        {
            int notaFInal = -1;

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4 )
            {
                notaFInal = random.Next(6,10);
            }

            return notaFInal;
        }

        private float CalcularPromedio() 
        {
            int resultado = notaPrimerParcial + notaSegundoParcial / 2;
            
            return resultado;
        }

        public string Mostrar() 
        { 
            StringBuilder mensaje = new StringBuilder();
            double notaFinal = CalcularNotaFinal();

            mensaje.AppendLine($"Nombre del alumno: {nombre}");
            mensaje.AppendLine($"Apellido del alumno: {apellido}");
            mensaje.AppendLine($"Legajo del alumno: {legajo}");
            mensaje.AppendLine($"Nota primer parcial: {notaPrimerParcial}");
            mensaje.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");
            mensaje.AppendLine($"Promedio: {CalcularPromedio()}");

            if (notaFinal != -1)
            {
                mensaje.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                mensaje.AppendLine($"El alumno {nombre} desaprobo");
            }

            return mensaje.ToString();
        }

        public void SetNotaPrimerParcial(int nota) 
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
    }
}
