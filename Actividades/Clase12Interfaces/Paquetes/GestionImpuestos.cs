using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paquetes
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAfip = new List<IAfip>();
            this.impuestosAduana = new List<IAduana>();
        }

        public decimal CalcularTotalImpuestosAduana() 
        {
            decimal suma = 0;
            foreach (Paquete paquete  in impuestosAduana)
            {
                suma += paquete.AplicarImpuestos();
            }

            return suma;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal suma = 0;

            foreach (Paquete paquete in impuestosAfip)
            {
                suma += paquete.AplicarImpuestos();
            }

            return suma;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes) 
        {
            foreach (Paquete paquete in paquetes)
            {
                RegistrarImpuestos(paquete);
            }
        }

        public void RegistrarImpuestos(Paquete paquete) 
        {
            if (paquete is IAduana)
            {
                this.impuestosAduana.Add(paquete);
            }
            else if (paquete is IAfip afip) 
            {
                this.impuestosAfip.Add(afip);
            }
            
        }
    }
}
