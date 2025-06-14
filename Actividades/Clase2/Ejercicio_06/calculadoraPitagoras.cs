using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    public class calculadoraPitagoras
    {
        public static double CalcularHipotenusa(double basee, double altura) 
        {
            double hipotenusa = Math.Sqrt((Math.Pow(basee, 2) + Math.Pow(altura, 2)));
            return hipotenusa;
        }
    }
}
