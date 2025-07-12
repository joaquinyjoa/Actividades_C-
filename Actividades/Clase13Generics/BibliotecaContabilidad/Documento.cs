using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaContabilidad
{
    public class Documento
    {
        private int numero;

        public int Numero 
        {
            get { return this.numero; }
            set { this.numero = value; } 
        }

        public Documento(int numero) 
        {
            Numero = numero;
        }
    }
}
