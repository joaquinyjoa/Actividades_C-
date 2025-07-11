using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paquetes
{
    public class PaquetePesado : Paquete, IAfip
    {
        /// <summary>
        /// No tiene prioridad los paquetes pesados
        /// </summary>
        public override bool TienePrioridad { get { return false; } }

        public new decimal Impuestos { get { return this.costoEnvio * 0.25M; } }

        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino,
            string origen, double pesoKG) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKG)
        { }

        public override decimal AplicarImpuestos()
        {
            decimal totalDescuento = Impuestos + base.Impuestos;
            decimal total = this.costoEnvio + totalDescuento;

            return total;
        }
    }
}
