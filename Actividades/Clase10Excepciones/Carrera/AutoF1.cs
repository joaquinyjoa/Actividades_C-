using System.Text;

namespace Carrera
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza 
        {
            get {  return this.caballosDeFuerza; } 
            set { this.caballosDeFuerza = value; }
        }

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
            
        }

        public AutoF1 (short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            CaballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"Caballos de fuerza: {CaballosDeFuerza}");

            return sb.ToString();
        }

        public static bool operator == (AutoF1 a, AutoF1 b) 
        {
            return (a.Numero == b.Numero) && (a.Escuderia == b.Escuderia);
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return (a.Numero != b.Numero) && 
                (a.Escuderia != b.Escuderia) &&
                (a.CaballosDeFuerza == b.CaballosDeFuerza);
        }
    }
}
