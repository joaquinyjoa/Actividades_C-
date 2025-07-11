using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubes
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador() 
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre): this() 
        {
            this.dni = dni;
            this.nombre = nombre;
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
            get 
            {
                return this.totalGoles;
            }
        }

        //ESRITURA Y LECTURA
        public string Nombre 
        {
            get 
            {
                return nombre;
            }
            set 
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string MostrarDatos() 
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DNI: {Dni}");
            mensaje.AppendLine($"NOMBRE: {Nombre}");
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
