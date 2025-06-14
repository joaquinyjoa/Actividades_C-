namespace Boligrafos
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta() 
        {
            return tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "*";
            int tintaAnterior = 0 - this.tinta;//guardamos el valor de la tinta pero en negativo
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Console.ForegroundColor = this.color;

            if (gasto < 0)
            {
                SetTinta(gasto);

                for (int i = 0; i >= gasto; i--)
                {
                    Console.Write(dibujo);

                    if (i <= tintaAnterior + 1)
                    {
                        break;
                    }
                }

                retorno = true;
            }

            Console.ForegroundColor = colorOriginal; // <-- Restaurar color original
            return retorno;
        }

        /// <summary>
        /// Recarga la tinta a la cantidad maxima
        /// </summary>
        public void Recargar() 
        {
            SetTinta(cantidadTintaMaxima);
        }

        /// <summary>
        /// Modifica la cantidad del boligrafo, lo rellena o lo gasta
        /// </summary>
        /// <param name="tinta">Ingreso positivo para llenar o negativo para gastar</param>
        private void SetTinta(short tinta) 
        {
            //Revisa que la tinta este entre la cantidad maxima y minima
            if (this.tinta >= 0 && this.tinta <= cantidadTintaMaxima)
            {
                //validamos si gastamos o rellenamos la tinta
                if (tinta < 0)
                {
                    this.tinta += tinta;//si la tinta original es positivo resta el gasto(-)
                    //Valida que la tinta original no llegue a numeros negativos
                    if (this.tinta <= 0)
                    {
                        this.tinta = 0;//si llega sera 0
                    }
                }
                else if (tinta > 0)
                {
                    this.tinta += tinta;
                    if (this.tinta >= cantidadTintaMaxima)
                    {
                        this.tinta = cantidadTintaMaxima;
                    }
                }
 
            }
            
        }
    }
}
