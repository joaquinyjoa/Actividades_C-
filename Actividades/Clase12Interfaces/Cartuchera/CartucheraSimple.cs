using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapizs;

        public bool RecorrerElementos()
        {
            bool seGastoAlgo = false;

            for (int i = 0; i < boligrafos.Count; i++)
            {
                if (boligrafos[i].UnidadesDeEscritura > 0)
                {
                    boligrafos[i].UnidadesDeEscritura -= 1;
                    seGastoAlgo = true;
                }
                else
                {
                    boligrafos[i].Recargar(20);
                }
            }

            for (int i = 0; i < lapizs.Count; i++)
            {
                if (lapizs[i].UnidadesDeEscritura > 0)
                {
                    lapizs[i].UnidadesDeEscritura -= 1;
                    seGastoAlgo = true;
                }
                else
                {
                    lapizs[i].Recargar(20);
                }
            }

            return seGastoAlgo;
        }
    }
}
