using System.Drawing;
using System.Text;

namespace Cartuchera
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            Color = color;
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
                        UnidadesDeEscritura -= 0.3f;
                        
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
            }
            else
            {
                UnidadesDeEscritura += unidades;
            }
            
            if(UnidadesDeEscritura >= 100) 
            {
                UnidadesDeEscritura = 100;
                recargar = false;
            }

            return recargar;
        }
    }
}
