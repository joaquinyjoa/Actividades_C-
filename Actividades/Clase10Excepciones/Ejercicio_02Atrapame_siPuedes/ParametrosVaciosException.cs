using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02Atrapame_siPuedes
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
