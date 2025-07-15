using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public static class Aleatorio
    {
        private static readonly Random random = new Random();

        public static string TirarUnaMoneda() 
        {
            int moneda = random.Next(0, 2);
            LadosMoneda tipo = (LadosMoneda)moneda;
            return tipo.ToString();
        }
    }
}
