using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubes
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        { }

        public DirectorTecnico(string nombre,DateTime fechaDeNacimiento) : this (nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public DateTime FechaDeNacimiento 
        {
            get {  return fechaDeNacimiento.Date; } 
            set { this.fechaDeNacimiento = value; }
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento}");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico a, DirectorTecnico b) 
        {
            return a.Nombre == b.Nombre && a.fechaDeNacimiento == b.fechaDeNacimiento;
        }

        public static bool operator !=(DirectorTecnico a, DirectorTecnico b)
        {
            return a.Nombre != b.Nombre && a.FechaDeNacimiento != b.FechaDeNacimiento;
        }
    }
}
