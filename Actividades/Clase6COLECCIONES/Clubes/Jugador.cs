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
        private int paridosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador() 
        {
            this.dni = 0;
            this.nombre = "";
            this.paridosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre): this() 
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int paridosJugados, float promedioGoles, int totalGoles) : this(dni, nombre)
        {
            this.paridosJugados = paridosJugados;
            this.promedioGoles = promedioGoles;
            this.totalGoles = totalGoles;
        }

        public float getPromedioGoles() {  return promedioGoles; }

        public string MostrarDatos() 
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"DNI: {dni}");
            mensaje.AppendLine($"NOMBRE: {nombre}");
            mensaje.AppendLine($"Partidos jugados: {paridosJugados}");
            mensaje.AppendLine($"Promedio goles: {this.getPromedioGoles()}");
            mensaje.AppendLine($"Total de goles: {totalGoles}");

            return mensaje.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2) 
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.dni != j2.dni;
        }
    }
}
