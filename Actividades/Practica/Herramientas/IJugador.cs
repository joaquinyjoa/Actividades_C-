using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public interface IJugador
    {
        short Nivel { get; }
        int PuntosDeVida { get;  }

        public int Atacar();
        public void RecibirAtaque(int ataque);
    }
}
