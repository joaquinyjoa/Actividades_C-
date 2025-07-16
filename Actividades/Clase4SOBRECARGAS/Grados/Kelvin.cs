namespace Grados
{
    public class Kelvin
    {
        private double temperatura;

        public Kelvin()
        {
            this.temperatura = 0;
        }

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.GetTemperatura() == k2.GetTemperatura();
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            double conversion = k.GetTemperatura() - 273.15;
            return new Celsius(conversion);
        }

        // SOLO esta conversión implícita desde Fahrenheit para evitar duplicidad
        public static implicit operator Kelvin(Fahrenheit f)
        {
            double conversion = (f.GetTemperatura() + 459.67) * 5 / 9;
            return new Kelvin(conversion);
        }
    }
}