using System;
using System.IO;

namespace Herramientas
{
    public class Logger
    {
        private string ruta;

        public Logger(string ruta)
        {
            this.ruta = ruta;
        }

        public void GuardarLog(string texto)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true)) // true: append al archivo
                {
                    writer.WriteLine($"{DateTime.Now} {texto}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el log: {ex.Message}");
            }
        }
    }
}
