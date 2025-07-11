using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubes
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        //llamada del constructor base
        public Jugador(long dni, string nombre): base(dni, nombre) 
        {
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        //SOLO LECTURA
        public int PartidosJugados 
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }

        public float PromedioGoles 
        {
            get 
            { 
                float promedioGoles = TotalGoles / PartidosJugados;
                return promedioGoles; 
            } 
        }

        public int TotalGoles 
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value;}
        }

        public string MostrarDatos() 
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Partidos jugados: {PartidosJugados}");
            mensaje.AppendLine($"Promedio goles: {PromedioGoles}");
            mensaje.AppendLine($"Total de goles: {TotalGoles}");

            return mensaje.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2) 
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.Dni != j2.Dni;
        }
    }
}
