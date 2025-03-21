using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class Calculadora
    {
        public static double Calcular(int primerOperador, int segundoOperador, string operacionMatematica) 
        {
            double resultado = 0;
            bool validar = Calculadora.Validar(segundoOperador);
            switch (operacionMatematica) 
            {
                case "+":
                    resultado = primerOperador + segundoOperador;
                    break;
                case "-":
                    resultado = primerOperador - segundoOperador;
                    break;
                case "*":
                    resultado = primerOperador * segundoOperador;
                    break;
                case "/":
                    if (validar)
                    {
                        resultado = primerOperador / segundoOperador;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }

                    break;
            }
            return resultado;
        }

        private static bool Validar(int segundoOperador) 
        {
            bool validado = false;
            if (segundoOperador != 0)
            {
                validado = true;
            }
            return validado;
        }

    }
}
