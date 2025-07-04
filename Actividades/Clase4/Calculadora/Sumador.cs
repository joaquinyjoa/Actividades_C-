﻿namespace Calculadora
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador() : this(0)
        { }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }


        public long Sumar(long a, long b) 
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
    }
}
