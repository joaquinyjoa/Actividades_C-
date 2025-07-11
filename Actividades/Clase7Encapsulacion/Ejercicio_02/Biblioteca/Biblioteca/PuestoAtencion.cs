using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public int NumeroActual
        {
            get { return numeroActual + 1; }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Console.WriteLine("Atendiendo al cliente, espere 2 segundos...");
            Thread.Sleep(2000);
            return true;
        }
    }
}
