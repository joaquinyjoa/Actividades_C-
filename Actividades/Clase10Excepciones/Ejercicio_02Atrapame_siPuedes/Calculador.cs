using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02Atrapame_siPuedes
{
    public class Calculador
    {
        public static double Calcular(int a, int b) 
        {
            double resultado;
            try 
            {
                resultado = (double)a / b;

            }catch (DivideByZeroException ex)
            {
                resultado = 0;
            }

            return resultado;
        }
    }
}
