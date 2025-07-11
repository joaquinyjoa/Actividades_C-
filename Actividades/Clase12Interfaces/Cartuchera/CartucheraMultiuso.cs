using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> acciones;
        

        public bool RecorrerElementos() 
        {
            bool seGastoAlgo = false;

            for (int i = 0; i < acciones.Count; i++)
            {
                if (acciones[i].UnidadesDeEscritura > 0)
                {
                    acciones[i].UnidadesDeEscritura -= 1;
                    seGastoAlgo = true;
                }
                else
                {
                    acciones[i].Recargar(20);
                }
            }
            
            return seGastoAlgo;
        }
    }
}
