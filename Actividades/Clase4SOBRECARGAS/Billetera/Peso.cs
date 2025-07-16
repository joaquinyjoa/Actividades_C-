namespace Billetera
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Peso() : this(0, 0)
        { }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = 102.95;
        }

        public Peso(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = cotizacion;
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
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == e.GetCantidad();
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return p.GetCantidad() != e.GetCantidad();
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return p.GetCantidad() != d.GetCantidad();
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1.GetCantidad() == p2.GetCantidad());
        }

        //Implementacion de manera implicita 
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        /*
         Para la conversion se hace:
            Peso destino = cant dolar * (cotizacion peso destino / cotizacion en dolar)
         */

        //Implementacion explicita Peso a Dolar
        public static explicit operator Dolar(Peso p)
        {
            double cantidad = p.GetCantidad() * (Dolar.GetCotizacion() / Peso.cotzRespectoDolar);
            return new Dolar(cantidad);
        }

        //Peso a Euro
        public static explicit operator Euro(Peso p)
        {
            double cantidad = p.GetCantidad() * (Euro.GetCotizacion() / Peso.cotzRespectoDolar);
            return new Euro(cantidad);
        }

        public static Peso operator +(Peso p, Dolar d) 
        {
            Peso p2 = (Peso)d;
            Peso resultado = p.GetCantidad() + p2.GetCantidad();

            return resultado;
        }

        public static Peso operator +(Peso p, Euro e)
        {
            Peso p2 = (Peso)e;
            Peso resultado = p.GetCantidad() + p2.GetCantidad();

            return resultado;
        }

        //Resta entre dos objetos distintos

        public static Peso operator -(Peso p, Dolar d)
        {
            Peso p2 = (Peso)d;
            Peso resultado = p.GetCantidad() - p2.GetCantidad();

            return resultado;
        }

        public static Peso operator -(Peso p, Euro e)
        {
            Peso p2 = (Peso)e;
            Peso resultado = p.GetCantidad() - p2.GetCantidad();

            return resultado;
        }
    }
}
