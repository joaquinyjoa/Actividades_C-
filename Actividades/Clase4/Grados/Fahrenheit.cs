namespace Grados
{
    public class Fahrenheit
    {
        private double temperatura;

        public Fahrenheit()
        {
            this.temperatura = 0;
        }

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.GetTemperatura() == f2.GetTemperatura();
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            double conversion = k.GetTemperatura() * 9 / 5 - 459.67;
            return new Fahrenheit(conversion);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            double conversion = c.GetTemperatura() * 9 / 5 + 32;
            return new Fahrenheit(conversion);
        }
    }
}
