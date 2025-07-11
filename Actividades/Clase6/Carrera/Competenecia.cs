using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine($"Competidores: ");

            foreach (AutoF1 competidor in this.competidores)
            {
                sb.AppendLine($"{competidor.MostrarDatos()}");
            }

            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a) 
        {
            bool agregar = true;
            
            for (int i = 0; i < c.competidores.Count; i++)
            {
                if (c.competidores[i] == a)
                {
                    agregar = false;
                    break;
                }
            }

            if (c.competidores.Count >= c.cantidadCompetidores)
            {
                agregar = false;
            }
            else
            {
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                Random random = new Random();

                a.SetCantidadCombustible(random.Next(15, 100));
                c.competidores.Add(a);
            }

            return agregar;
        }

    }
}
