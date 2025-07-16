namespace Billetera
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Euro():this(0, 0) 
        { }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = 1.75;
        }

        public Euro(double cantidad, double cotizacion) 
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
        public static bool operator ==(Euro e, Dolar d) 
        {
            return e.GetCantidad() == d.GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e.GetCantidad() == d.GetCantidad());
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() == p.GetCantidad();
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e.GetCantidad() == p.GetCantidad());
        }
    
        public static bool operator ==(Euro e1 , Euro e2) 
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1.GetCantidad() == e2.GetCantidad());
        }

        //Implementacion de manera implicita
        public static implicit operator Euro(double d) 
        {
            return new Euro(d);
        }

        /*
         Para la conversion se hace:
            Peso destino = cant dolar * (cotizacion peso destino / cotizacion en dolar)
         */

        //Implementacion explicita Euro a Dolar
        public static explicit operator Dolar(Euro e)
        {
            double cantidad = e.GetCantidad() * (Dolar.GetCotizacion() / Euro.cotzRespectoDolar);
            return new Dolar(cantidad);
        }

        // Euro a Peso
        public static explicit operator Peso(Euro e)
        {
            double cantidad = e.GetCantidad() * (Peso.GetCotizacion() / Euro.cotzRespectoDolar);
            return new Peso(cantidad);
        }

        //Suma entre dos objetos distintos
        public static Euro operator +(Euro e, Dolar d)
        {
            //Converir explicitamente al obj Dolar en Euro
            Euro e2 = (Euro)d;

            //Sumar sus cantidades
            Euro resultado = e.GetCantidad() + e2.GetCantidad();

            return resultado;
        }

        public static Euro operator +(Euro e, Peso p)
        {
            Euro e2 = (Euro)p;
            Euro resultado = e.GetCantidad() + e2.GetCantidad();

            return resultado;
        }


        //Resta entre dos objetos distintos
    
        public static Euro operator -(Euro e, Dolar d) 
        {
            Euro e2 = (Euro)d;
            Euro resultado = e.GetCantidad() - e2.GetCantidad();

            return resultado;
        }

        public static Euro operator -(Euro e, Peso p)
        {
            Euro e2 = (Euro)p;
            Euro resultado = e.GetCantidad() - e2.GetCantidad();

            return resultado;
        }

    }
}
