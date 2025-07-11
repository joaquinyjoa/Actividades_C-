using System.Text;

namespace Paquetes
{
    public abstract class Paquete : IAduana
    {
        private string codigoDeBarra;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKG;

        public abstract bool TienePrioridad{ get; }

        public decimal Impuestos { get { return this.costoEnvio * 0.35M; } }

        public string ObtenerInformacionDelPaquete() 
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de barra: {this.codigoDeBarra}");
            sb.AppendLine($"Costo del envio: ${this.costoEnvio}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Peso en KG: {this.pesoKG} kg");
            if (TienePrioridad == true)
            {
                sb.AppendLine($"Tiene prioridad");
            }
            else
            {
                sb.AppendLine($"No tiene prioridad");
            }

            return sb.ToString();
        }

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKG) 
        {
            this.codigoDeBarra = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKG = pesoKG;
        }

        public virtual decimal AplicarImpuestos() 
        {
            decimal total = this.costoEnvio + Impuestos;

            return total;
        }

    }
}
