
using System.Text;

namespace Veterinaria
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private double telefono;
        private Mascota[] mascotas;

        public Cliente(string domicilio, string nombre, string apellido, double telefono, int cantMascotas)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotas = new Mascota[cantMascotas];
        }

        public int ObtenerAnchoArray() 
        {
            return this.mascotas.Length;
        }

        public void AgregarMascota(Mascota[] mascotasDos, int indice)
        {
            for (int i = 0; i <= indice; i++)
            {
                mascotas[i] = mascotasDos[i];
            }
        }

        public string ToString()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Nombre del cliente: {this.nombre}");
            mensaje.AppendLine($"Apellido del cliente: {this.apellido}");
            mensaje.AppendLine($"Domicilio del cliente: {this.domicilio}");
            mensaje.AppendLine($"Telefono del cliente: {this.telefono}");

            if (mascotas.Length > 0)
            {
                mensaje.AppendLine("El cliente tiene esta/s mascotas: ");
                foreach (Mascota mascota in mascotas)
                {
                    mensaje.Append($"{mascota.ToString()}");
                }
                mensaje.AppendLine();
            }
            else
            {
                mensaje.AppendLine("El cliente no tiene mascotas");
            }

            return mensaje.ToString();
        }
    }
}
