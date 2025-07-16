using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class Hechicero : Personaje
    {
        public Hechicero(decimal id, string nombre, string titulo) : base(id, nombre, titulo)
        {
            this.AplicarBeneficiosDeClase();
        }

        public Hechicero(decimal id, string nombre, string titulo, short nivel)
            : base(id, nombre, titulo, nivel)
        {
            this.AplicarBeneficiosDeClase();
        }

        public override void AplicarBeneficiosDeClase()
        {
            base.PuntosDePoder += base.PuntosDePoder * 10 / 100;
        }
    }
}
