using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    public class Euro
    {
        private double cantidad;
        private double cotzRespectoDolar;

        private Euro():this(0, 0) 
        { }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
            this.cotzRespectoDolar = 1.75;
        }

        public Euro(double cantidad, double cotizacion) 
        {
            this.cantidad = cantidad;
            this.cotzRespectoDolar = cotizacion;
        }

        public double getCantidad() 
        { 
            return cantidad; 
        }

        public double GetCotizacion() 
        {
            return cotzRespectoDolar;
        }
            
        //Asi se hace la conversion Dolar a Euro
        public static explicit operator Dolar(Euro euro) 
        {
            double resultado = euro.cotzRespectoDolar / euro.cantidad;
            return new Dolar(resultado);
        }

        public static explicit operator Peso(Euro euro)
        {
            double cotizacionEuroEnPesos = euro.cotzRespectoDolar * 102.95; // Ejemplo
            double cantidadEnPesos = euro.cantidad * cotizacionEuroEnPesos;
            return new Peso(cantidadEnPesos, 102.95);
        }
    }
}
