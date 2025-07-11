using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paquetes
{
    public class PaqueteFragil : Paquete
    {
        /// <summary>
        /// Tienen prioridad los paquetes fragiles
        /// </summary>
        public override bool TienePrioridad { get { return true; } }

        public PaqueteFragil(string codigoSeguimiento, decimal costoEnvio, string destino,
            string origen, double pesoKG) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKG) 
        { }

        public override decimal AplicarImpuestos()
        {
            decimal total = this.costoEnvio + base.Impuestos;

            return total;
        }
    }
}
