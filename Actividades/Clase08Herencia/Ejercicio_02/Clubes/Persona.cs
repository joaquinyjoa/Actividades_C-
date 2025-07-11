using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubes
{
    public class Persona
    {
        private long dni;
        private string nombre;

        //CONTRCTORES
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        //LECTURA Y ESCRITURA
        public long Dni 
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"DNI: {Dni}");

            return sb.ToString();
        }
    }
}
