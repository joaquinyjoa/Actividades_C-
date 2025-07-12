using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaContabilidad
{
    public class Factura : Documento
    {
        public Factura() : base(0) 
        { }
        public Factura(int numero): base(numero) 
        { }
    }
}
