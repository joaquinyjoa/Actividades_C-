using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    public class calculadorDelArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double area = Math.Pow(longitudLado, 2);
            return area;
        }
        public static double CalcularAreaTriangulo(double basee, double altura) 
        {
            double area = (basee * altura) / 2;
            return area;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
