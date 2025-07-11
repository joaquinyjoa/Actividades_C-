using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class VehiculoDeCarrera
    {
        private short cantidadConbustible;
        private bool enCompeticion;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadConbustible
        {
            get {  return this.cantidadConbustible; }
            set {  this.cantidadConbustible = value; }
        }

        public bool EnCompeticion 
        {
            get { return this.enCompeticion; }
            set {  this.enCompeticion = value; }
        }

        public string Escuderia 
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }

        public short Numero 
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public short VueltasRestantes 
        {
            get { return this.vueltasRestantes; }
            set {  this.vueltasRestantes = value; }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de combustible: {CantidadConbustible}");
            sb.AppendLine($"¿Está compitiendo? {EnCompeticion}");
            sb.AppendLine($"Escuderia: {Escuderia}");
            sb.AppendLine($"Numero: {Numero}");
            sb.AppendLine($"Vueltas restantes: {VueltasRestantes}");

            return sb.ToString(); 
        }
    }
}
