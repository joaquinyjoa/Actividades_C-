using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        
        private short cantidadDeMarchas;
        private int pesoCarga;

        public Camion(short cantidadDeRuedas, short cantidadDePuertas, Colores color,
            short cantidadDeMarchas, int pesoCarga) :base(cantidadDeRuedas, cantidadDePuertas, color)
        {
    
            this.cantidadDeMarchas = cantidadDeMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
