using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class Guerrero : Personaje
    {
        public Guerrero(decimal id, string nombre) : base(id, nombre)
        {
            this.AplicarBeneficioDeClase();
        }

        public Guerrero(decimal id, string nombre, short nivel) : base(id, nombre, nivel)
        {
            this.AplicarBeneficioDeClase();
        }

        public Guerrero(decimal id, string nombre, short nivel, string titulo = "")
           : this(id, nombre, nivel)
        { }

        protected override void AplicarBeneficioDeClase()
        {
            this.PuntosDeDefensa += (int)(this.PuntosDeDefensa * 0.1m);
        }
    }
}
