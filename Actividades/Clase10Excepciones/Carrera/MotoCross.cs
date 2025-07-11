using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada 
        {
            get { return this.cilindrada; } 
            set { this.cilindrada = value; }
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        { }

        public MotoCross(short numero, string escuderia, short cilindrada): this(numero, escuderia)
        {
            Cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Caballos de fuerza: {Cilindrada}");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross a, MotoCross b)
        {
            return (a.Numero == b.Numero) && 
                (a.Escuderia == b.Escuderia) &&
                (a.Cilindrada == b.Cilindrada);
        }

        public static bool operator !=(MotoCross a, MotoCross b)
        {
            return (a.Numero != b.Numero) &&
                (a.Escuderia != b.Escuderia) &&
                (a.cilindrada != b.cilindrada);
        }
    }
}
