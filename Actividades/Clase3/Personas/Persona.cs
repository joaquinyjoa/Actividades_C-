using System.Text;

namespace Personas
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private double dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, double dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public double Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaDeNacimiento.Year;

            if (fechaDeNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            int edad = CalcularEdad();

            mensaje.AppendLine($"El nombre del usuario es: {Nombre}");
            mensaje.AppendLine($"El dni del usuario es: {Dni}");
            mensaje.AppendLine($"La fecha de nacimiento del usuario es: {FechaDeNacimiento.ToString("dd/MM/yyyy")}");

            if (edad != 1)
            {
                mensaje.AppendLine($"La edad del usuario es: {edad}");
            }
            else
            {
                mensaje.AppendLine($"El año de nacimiento es mayor que la fecha actual");
            }

            return mensaje.ToString();

        }

        public string EsMayorDeEdad()
        {
            StringBuilder mensaje = new StringBuilder();
            int edad = CalcularEdad();

            if (edad >= 18)
            {
                mensaje.AppendLine("es mayor de edad");
            }
            else
            {
                mensaje.AppendLine("es menor de edad");
            }

            return mensaje.ToString();
        }

    }
}
