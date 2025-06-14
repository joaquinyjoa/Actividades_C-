namespace Billetera
{
    public class Dolar
    {
        private double cotzRespectoDolar;
        private double cantidad;

        private Dolar() : this(0) 
        { }

        public Dolar(double cantidad) 
        {
            this.cantidad = cantidad;
            this.cotzRespectoDolar = 1;
        }

        public double GetCantidad() 
        {
            return cantidad;
        }

        public double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d) 
        {
            return new Euro(d.cantidad*d.cotzRespectoDolar);
        }
    }
}
