using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaTorneo
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaDeCreacion;

        public string Nombre { 
            get { return this.nombre; }  
            set { this.nombre = value; }
        }

        public Equipo(string nombre, DateTime fechaDeCreacion) 
        {
            Nombre = nombre;
            this.fechaDeCreacion = fechaDeCreacion;
        }

        public string Ficha() 
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.nombre} fundado el: {fechaDeCreacion.Date.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }

        public static bool operator ==(Equipo a, Equipo b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.nombre == b.nombre && a.fechaDeCreacion.Date.ToString("dd/MM/yyyy") == b.fechaDeCreacion.Date.ToString("dd/MM/yyyy");
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }
    }
}
