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
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;
        private static Random random = new Random();

        public short CantidadCompetidores 
        {
            get {  return this.cantidadCompetidores; } 
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas 
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public VehiculoDeCarrera this[int i] 
        {
            get { return this.competidores[i]; }
            set { this.competidores[i] = value; }
        }

        public TipoCompetencia Tipo 
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            CantidadCompetidores = cantidadCompetidores;
            CantidadVueltas = cantidadVueltas;
            Tipo = tipo;
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"cantidad de competidores: {CantidadCompetidores}");
            sb.AppendLine($"cantidad de vueltas: {CantidadVueltas}");
            sb.AppendLine($"Competidores: ");

            // Mostrar motos
            foreach (var competidor in this.competidores)
            {
                if (competidor is MotoCross)
                {
                    sb.AppendLine(competidor.MostrarDatos());
                }
            }

            // Mostrar autos F1
            foreach (var competidor in this.competidores)
            {
                if (competidor is AutoF1)
                {
                    sb.AppendLine(competidor.MostrarDatos());
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a) 
        {
            bool agregar = true;
            short cantConbustible = (short)random.Next(15, 100);
            short cantVueltar = (short)random.Next(0,c.cantidadVueltas);

            if (c.Tipo == TipoCompetencia.MotoCross && a is MotoCross)
            {
                a.EnCompeticion = true;
                a.CantidadConbustible = cantConbustible;
                a.VueltasRestantes = cantVueltar;
                c.competidores.Add(a);
            }
            else if (c.Tipo == TipoCompetencia.F1 && a is AutoF1)
            {
                a.EnCompeticion = true;
                a.CantidadConbustible = cantConbustible;
                a.VueltasRestantes = cantVueltar;
                c.competidores.Add(a);
            }
            else
            {
                agregar = false;
            }
            return agregar;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return c != a;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool agregado = false;

            // Usamos el operador == para validar tipo y compatibilidad
            if (c == a)
            {
                if (c.competidores.Count < c.CantidadCompetidores)
                {
                    a.CantidadConbustible = 100;  // Seteamos combustible al 100%
                    a.EnCompeticion = true;        // Opcional: lo marcamos en competición
                    a.VueltasRestantes = c.CantidadVueltas; // Opcional: vueltas completas

                    c.competidores.Add(a);
                    agregado = true;
                }
            }
            return agregado;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool eliminar = true;

            if (c == a)
            {
                c.competidores.Remove(a);
            }
            else
            {
                eliminar = false;
            }

            return eliminar;
        }

    }
}
