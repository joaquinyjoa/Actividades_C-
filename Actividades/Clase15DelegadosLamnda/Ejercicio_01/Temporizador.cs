using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class Temporizador
    {
        public static void Esperar(int miliSegundos, DelegadoSaludar saludar) 
        {
            Thread.Sleep(miliSegundos);
            saludar();
        }
    }
}
