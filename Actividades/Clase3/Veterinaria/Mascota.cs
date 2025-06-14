using System.Text;

namespace Veterinaria
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string[] vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento, int cantidadVacunas)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.vacunas = new string [cantidadVacunas];
        }

        public void AgregarVacuna(string vacuna, int indice)
        {
            vacunas[indice] = vacuna;
        }

        public string ToString() 
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Nombre de la mascota: {this.nombre}");
            mensaje.AppendLine($"Especie de la mascota: {this.especie}");
            mensaje.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToShortDateString()}");

            if (vacunas.Length > 0)
            {
                mensaje.Append("La mascota tiene esta/s vacunas: ");
                foreach (string vacuna in vacunas)
                {
                    mensaje.Append($"- {vacuna} ");
                }
                mensaje.AppendLine();
            }
            else 
            {
                mensaje.AppendLine("La mascota no tiene vacunas");
            }

            return mensaje.ToString();
        }
    }
}
