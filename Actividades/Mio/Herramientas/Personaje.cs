using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public abstract class Personaje : IJugador
    {
        public delegate void ManejadorPersonaje (Personaje personaje, int n);

        private decimal id;
        private short nivel;
        private string nombre;
        private string titulo;
        private int puntosDeVida;
        private int puntosDePoder;
        private int puntosDeDefensa;
        private static Random random;
        public event ManejadorPersonaje AtaqueLanzado;
        public event ManejadorPersonaje AtaqueRecibido;


        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public int PuntosDePoder
        {
            get
            {
                return this.puntosDePoder;
            }
            set
            {
                this.puntosDePoder = value;
            }
        }

        public int PuntosDeDefensa
        {
            get
            {
                return this.puntosDeDefensa;
            }
            set
            {
                this.puntosDeDefensa = value;
            }
        }

        public int PuntosDeVida {
            get 
            {
                return this.puntosDeVida;
            }
            set 
            {
                this.puntosDeVida = value;
            }
                 }

        public short Nivel 
        {
            get { return this.nivel; }
            set { this.nivel = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        static Personaje()
        {
            random = new Random(); 
        }

        private Personaje() 
        {
            this.puntosDeDefensa = 100;
            this.puntosDePoder = 100 * this.nivel;
            this.PuntosDeVida = 500 * this.Nivel;
            this.titulo = "";
            Nivel = 1; 
        }

        public Personaje(decimal id, string nombre, string titulo) : this()
        {
            this.id = id;
            if (String.IsNullOrEmpty(nombre))
            {
                throw new ArgumentNullException();
            }
            this.titulo = titulo;
            this.nombre = nombre.Trim();

        }

        public Personaje(decimal id, string nombre, string titulo, short nivel): this(id, nombre, titulo)
        {
            
            const int maximo = 100;
            const int minimo = 1;

            if (this.Nivel >= minimo && this.Nivel <= maximo)
            {
                this.Nivel = nivel;
                this.puntosDeDefensa = 100;
                this.puntosDePoder = 100 * this.nivel;
                this.PuntosDeVida = 500 * this.Nivel;
            }
            else
            {
                throw new BusinessException("El nivel no esta entre el 1 y 100");
            }
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.id);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            Personaje p = obj as Personaje;
            if (p == null)
            {
                return false;
            }

            return (p == p);// && (y == p.y);
        }

        public static bool operator ==(Personaje personaje, Personaje otroPersonaje) 
        {
            return personaje.id == otroPersonaje.id;
        }

        public static bool operator !=(Personaje personaje, Personaje otroPersonaje)
        {
            return !(personaje.id == otroPersonaje.id);
        }

        public abstract void AplicarBeneficiosDeClase();

        public int Atacar() 
        {
            Random random = new Random();
            int ataque = puntosDePoder * random.Next(10, 101) / 100;
            Thread.Sleep(random.Next(1000, 5000));
            AtaqueLanzado?.Invoke(this, ataque);

            return ataque;
        }

        public void RecibirAtaque(int puntosDeAtaque)
        {
            int defensa =this.puntosDeDefensa * random.Next(10, 101) / 100;
            int ataqueFinal = puntosDeAtaque - defensa;

            if (ataqueFinal < 0 )
            {
                ataqueFinal = 0;
            }

            this.PuntosDeVida -= ataqueFinal;

            if (this.PuntosDeVida < 0)
            {
                this.PuntosDeVida = 0;
            }

            AtaqueRecibido?.Invoke(this, defensa);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.nombre);
            if (!string.IsNullOrEmpty(this.titulo))
            {
                sb.Append($", {this.titulo}");
            }

            return sb.ToString();
        }
    }
}
