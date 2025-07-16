using System.Text;

namespace Carrera
{
    public class AutoF1
    {
        private int cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia) 
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        // Getter y setter para cantidadCombustible
        public int GetCantidadCombustible()
        {
            return cantidadCombustible;
        }

        public void SetCantidadCombustible(int value)
        {
            cantidadCombustible = value;
        }

        // Getter y setter para enCompetencia
        public bool GetEnCompetencia()
        {
            return enCompetencia;
        }

        public void SetEnCompetencia(bool value)
        {
            enCompetencia = value;
        }

        // Getter y setter para vueltasRestantes
        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }

        public void SetVueltasRestantes(short value)
        {
            vueltasRestantes = value;
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Número: {this.numero}");
            mensaje.AppendLine($"Escudería: {this.escuderia}");
            mensaje.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            mensaje.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");
            mensaje.AppendLine($"¿Está en competencia?: {this.enCompetencia}");

            return mensaje.ToString();
        }

        public static bool operator == (AutoF1 a, AutoF1 b) 
        {
            return (a.numero == b.numero) && (a.escuderia == b.escuderia);
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return (a.numero != b.numero) && (a.escuderia != b.escuderia);
        }
    }
}
