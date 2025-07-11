using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {

        private short cilindrada;

        public Moto(short cantidadDeRuedas, short cantidadDePuertas,
            Colores color, short cilindrada) : base(cantidadDeRuedas, cantidadDePuertas, color)
        {
            this.cilindrada = cilindrada;
        }
    }
    
}
