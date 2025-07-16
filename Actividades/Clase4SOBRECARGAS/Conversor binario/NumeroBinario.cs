using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_binario
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string cadena) 
        {
            this.numero = cadena;
        }

        public string Numero 
        {
            get { return numero; }
        }

        public static int BinarioDecimal(string valorRecibido)
        {
            int resultado = 0;
            int cantidadCaracteres = valorRecibido.Length;

            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }

            return resultado;
        }


        public static string operator +(NumeroBinario binario, NumeroDecimal deecimal) 
        {
            return deecimal.DecimalBinario()
        }

    }
}
