using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoTerrestre
    {
        private short cantidadDeRuedas;
        private short cantidadDePuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadDeRuedas, short cantidadDePuertas, Colores color) 
        {
            this.color = color;
            this.cantidadDePuertas = cantidadDePuertas;
            this.cantidadDeRuedas = cantidadDeRuedas;
        }
    }
}
