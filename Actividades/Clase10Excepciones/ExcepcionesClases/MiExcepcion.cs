using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesClases
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }
    }
}
