using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    public class CalculadoraDeDiasVividos
    {
        public static string calcularDiasVivido(DateTime fechaDeNacimiento) 
        {
            DateTime fechaActual = DateTime.Today;
            StringBuilder mensaje = new StringBuilder();

            if (DateTime.IsLeapYear(fechaDeNacimiento.Year))
            {
                mensaje.AppendLine("Su año de nacimiento es bisiesto");
            }
            else
            {
                mensaje.AppendLine("Su año de nacimiento no es bisiesto");
            }

            TimeSpan diferencia = fechaActual - fechaDeNacimiento;

            int diasTranscurridos = diferencia.Days;

            mensaje.Append($"Has vivido {diasTranscurridos} días.");

            return mensaje.ToString();
        }
    }
}
