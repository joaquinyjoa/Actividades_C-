using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesClases
{
    public class OtraClase
    {
        public void MetodoDeInstancia()
        {
            try
            {
                // Instancia de MiClase usando el segundo constructor
                MiClase miClase = new MiClase(true);
            }
            catch (Exception ex)
            {
                // Captura UnaExcepcion y lanza MiExcepcion
                throw new MiExcepcion("Error en OtraClase.MetodoDeInstancia", ex);
            }
        }
    }

}
