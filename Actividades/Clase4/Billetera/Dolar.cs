namespace Billetera
{
    public class Dolar
    {
        private static double cotzRespectoDolar;
        private double cantidad;

        public Dolar() : this(0)
        { }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = 1;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        //COMPARACION ENTRE LOS OBJS SI TIENEN LA MISMA CANTIDAD 
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad() == e.GetCantidad();
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d.GetCantidad() == e.GetCantidad());
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d.GetCantidad() == p.GetCantidad();
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d.GetCantidad() == p.GetCantidad());
        }

        public static bool operator ==(Dolar d1, Dolar d2) 
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }

        public static bool operator !=(Dolar d1, Dolar d2) 
        {
            return !(d1.GetCantidad() == d2.GetCantidad());
        }
    
        //Implementacion de manera implicita
        public static implicit operator Dolar(double d) 
        {
            return new Dolar(d);
        }
    

        /*
         Para la conversion se hace:
            Peso destino = cant dolar * cotizacion en dolar / cotizacion 
         */
        //Implementacion explicita Dolar a Euro
        public static explicit operator Euro(Dolar d) 
        {
            double cantidad = d.GetCantidad() * (Euro.GetCotizacion() / Dolar.cotzRespectoDolar);
            return new Euro(cantidad);
        }

        //Dolar a Peso
        public static explicit operator Peso(Dolar d)
        {
            double cantidad = d.GetCantidad() * (Peso.GetCotizacion() / Dolar.cotzRespectoDolar);
            return new Peso(cantidad);
        }

        //Suma entre dos objetos distintos
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar d2 = (Dolar)e; // Conversión explícita que ya definiste
            Dolar resultado = d.GetCantidad() + d2.GetCantidad();
            return resultado;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar d2 = (Dolar)p;
            Dolar resultado = d.GetCantidad() + d2.GetCantidad();

            return resultado;
        }

        public static Dolar operator -(Dolar d, Euro e) 
        {
            Dolar d2 = (Dolar)e;
            Dolar resultado = d.GetCantidad() - d2.GetCantidad();
            return resultado;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar d2 = (Dolar)p;
            Dolar resultado = d.GetCantidad() - d2.GetCantidad();
            return resultado;
        }

    }
    }
