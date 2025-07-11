namespace Grados
{
    public class Celsius
    {
        private double temperatura;

        public Celsius()
        {
            this.temperatura = 0;
        }

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.GetTemperatura() == c2.GetTemperatura();
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        public static implicit operator Fahrenheit(Celsius c)
        {
            double conversion = c.GetTemperatura() * 9 / 5 + 32;
            return new Fahrenheit(conversion);
        }

        // SOLO esta conversion implícita para evitar conflicto con Kelvin
        public static implicit operator Kelvin(Celsius c)
        {
            double conversion = c.GetTemperatura() + 273.15;
            return new Kelvin(conversion);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            double conversion = (f.GetTemperatura() - 32) * 5 / 9;
            return new Celsius(conversion);
        }

        // Quitamos la conversión explícita de Kelvin a Celsius en Celsius para evitar duplicidad
    }
}