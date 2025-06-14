using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_binario
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero) 
        {
            this.numero = numero;
        }
        public double Numero 
        {
            get { return numero; }
        }

        public static string DecimalBinario(double numero)
        {
            string valorBinario = string.Empty;
            int resultDiv = (int)numero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (restoDiv > 0);
            }

            return valorBinario;
        }

       

    }
}
