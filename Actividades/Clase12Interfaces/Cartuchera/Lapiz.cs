using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public ConsoleColor Color 
        {
            get { return ConsoleColor.Gray; }
            set {  throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura 
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        public Lapiz(int unidades) 
        { 
            UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto) 
        {
            char[] letras = texto.ToCharArray();
            float resultado = 0;
            StringBuilder nuevoTexto = new StringBuilder();

            if (UnidadesDeEscritura != 0)
            {
                for (int i = 0; i < letras.Length; i++)
                {
                    if (UnidadesDeEscritura == 0)
                    {
                        break;
                    }

                    nuevoTexto.Append(texto[i]);
                    if (letras[i] != ' ')
                    {
                        UnidadesDeEscritura -= 0.1f;

                        if (UnidadesDeEscritura < 0)
                        {
                            UnidadesDeEscritura = 0;
                        }

                    }

                }

            }

            return new EscrituraWrapper(Color, nuevoTexto.ToString());
        }

        public bool Recargar(int unidades)
        {
            bool recargar = true;

            if (unidades <= 0)
            {
                recargar = false;
                throw new NotImplementedException();
            }
            else
            {
                UnidadesDeEscritura += unidades;
            }

            if (UnidadesDeEscritura >= 100)
            {
                UnidadesDeEscritura = 100;
                recargar = false;
                throw new NotImplementedException();
            }

            return recargar;
        }

    }
}
