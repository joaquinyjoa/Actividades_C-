using System;
using Puntos;

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        private float area;
        private float perimetro;

        private bool areaCalculada = false;
        private bool perimetroCalculado = false;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            int baseRect = Math.Abs(vertice3.GetX() - vertice1.GetX());
            int altura = Math.Abs(vertice3.GetY() - vertice1.GetY());

            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }

        public float GetArea()
        {
            if (!areaCalculada)
            {
                int baseRect = Math.Abs(vertice2.GetX() - vertice1.GetX());
                int altura = Math.Abs(vertice4.GetY() - vertice1.GetY());
                area = baseRect * altura;
                areaCalculada = true;
            }
            return area;
        }

        public float GetPerimetro()
        {
            if (!perimetroCalculado)
            {
                int baseRect = Math.Abs(vertice2.GetX() - vertice1.GetX());
                int altura = Math.Abs(vertice4.GetY() - vertice1.GetY());
                perimetro = 2 * (baseRect + altura);
                perimetroCalculado = true;
            }
            return perimetro;
        }

        public Punto GetVertice1() => vertice1;
        public Punto GetVertice2() => vertice2;
        public Punto GetVertice3() => vertice3;
        public Punto GetVertice4() => vertice4;
    }
}
