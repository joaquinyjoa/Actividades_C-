using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class Hechizero : Personaje
    {
        public Hechizero(decimal id, string nombre) : base(id, nombre)
        { }

        public Hechizero(decimal id, string nombre, short nivel) : base(id, nombre, nivel)
        { }

        public Hechizero(decimal id, string nombre, short nivel, string titulo = "")
           : this(id, nombre, nivel) 
        { }

        protected override void AplicarBeneficioDeClase()
        {
            int incremento = (int)(base.PuntosDePoder * 0.10M);
            base.PuntosDeDefensa += incremento;
        }
    }
}
