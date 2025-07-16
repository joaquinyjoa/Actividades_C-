using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class Logger
    {
        private string ruta;
        public Logger(string ruta)
        {
            this.ruta = ruta;
        }

        public void Guardar(string texto) 
        {
            using (StreamWriter sw = new StreamWriter(this.ruta)) 
            {
                sw.WriteLine(texto);

                // Guardar sin sobrescribir (agregar al final del archivo)              
                File.AppendAllText(this.ruta, sw.ToString());
            }
        }
    }
}
