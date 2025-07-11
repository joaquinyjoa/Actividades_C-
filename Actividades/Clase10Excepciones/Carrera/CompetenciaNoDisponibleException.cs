using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo 
        {
            get { return this.nombreMetodo;}
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase,
            string metodo) : base (mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase,
            string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Excepción en el método {NombreMetodo} de la clase {NombreClase}:");
            stringBuilder.AppendLine($"{Message}");
            stringBuilder.AppendLine($"{InnerException}\t");

            return stringBuilder.ToString();
        }
    }
}
