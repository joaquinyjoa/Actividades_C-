using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public interface IJugador
    {
        string Nombre { get; }
        short Nivel { get; }
        int PuntosDeVida { get; }

        int Atacar();
        void RecibirAtaque(int puntosDeAtaque);
    }
}
