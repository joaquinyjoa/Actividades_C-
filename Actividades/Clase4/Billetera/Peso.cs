using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    public class Peso
    {
        private double cantidad;
        private double cotzRespectoDolar;

        private Peso():this(0, 0) 
        { }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
            this.cotzRespectoDolar = 102.95;
        }

        public Peso(double cantidad, double cotzRespectoDolar)
        {
            this.cantidad = cantidad;
            this.cotzRespectoDolar = cotzRespectoDolar;
        }

        public static explicit operator Dolar(Peso p) 
        {
            return new Dolar(p.cantidad / p.cotzRespectoDolar);
        }

        public static explicit operator Euro(Peso p)
        {
            return new Euro(p.cantidad / p.cotzRespectoDolar);
        }
    }
}
