using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrito
{
    public class SobreSobrescrito : Sobrescrityo
    {


        protected override string MiPropiedad()
        {
            return MiAtributo;
        }

        public override string MiMetodo()
        {
            return MiPropiedad();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
