using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class Usuario
    {
        private string apellido;
        private string clave;
        private string correo;
        private int dni;
        private string nombre;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Usuario()
        {
            Apellido = string.Empty;
            Nombre = string.Empty;
            Clave = string.Empty;
            Correo = string.Empty;
            Dni = 0;
        }

        public Usuario(string nombre, string apellido, int dni, string correo) : this()
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Correo = correo;
        }

        public Usuario(string nombre, string apellido, int dni, string correo, string clave)
            : this(nombre, apellido, dni, correo)
        {
            Correo = correo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nombre);
            sb.Append(Apellido);
            sb.Append(Correo);
            sb.Append(Dni);

            return sb.ToString();
        }
    }
}
