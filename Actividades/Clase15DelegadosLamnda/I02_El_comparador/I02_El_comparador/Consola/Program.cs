using System;
using System.Collections.Generic;
using System.Linq;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // textos fijos
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";

            // para usar entrada por consola, descomenta estas líneas
            /*
            Console.WriteLine("Ingrese el primer texto:");
            primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            segundoTexto = Console.ReadLine();
            */

            // 1) Comparar por cantidad de caracteres
            Console.WriteLine("1era Comparación - Texto con más caracteres:");
            Comparar(primerTexto, segundoTexto, (t1, t2) => t1.Length.CompareTo(t2.Length));

            // 2) Comparar por cantidad de palabras (separar por espacios o saltos de línea)
            Console.WriteLine("2da Comparación - Texto con más palabras:");
            Comparar(primerTexto, segundoTexto, (t1, t2) =>
            {
                int palabras1 = t1.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int palabras2 = t2.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                return palabras1.CompareTo(palabras2);
            });

            // 3) Comparar por cantidad de vocales usando el método ContarVocales
            Console.WriteLine("3era Comparación - Texto con más vocales:");
            Comparar(primerTexto, segundoTexto, (t1, t2) => ContarVocales(t1).CompareTo(ContarVocales(t2)));

            // 4) Comparar por cantidad de signos de puntuación usando el método ContarSignosPuntuacion
            Console.WriteLine("4ta Comparación - Texto con más signos de puntuación:");
            Comparar(primerTexto, segundoTexto, (t1, t2) => ContarSignosPuntuacion(t1).CompareTo(ContarSignosPuntuacion(t2)));
        }

        public static void Comparar(string txt1, string txt2, DelegadoComparacion delegado)
        {
            int resultado = delegado(txt1, txt2);

            if (resultado > 0)
                Console.WriteLine("El primer texto es mayor.");
            else if (resultado < 0)
                Console.WriteLine("El segundo texto es mayor.");
            else
                Console.WriteLine("Ambos textos son iguales.");
        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }
    }
}
