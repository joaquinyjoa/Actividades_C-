using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validado = false;
            if (valor < max || valor > min)
            {
                validado = true;
            }

            return validado;
        }
    }
}
