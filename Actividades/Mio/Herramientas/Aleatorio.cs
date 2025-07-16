using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public static class Aleatorio
    {
        public static string TirarMoneda() 
        {
            int valor = new Random().Next(0, 3);
            LadosMoneda lado = (LadosMoneda)valor;

            return lado.ToString();
        }
    }
}
