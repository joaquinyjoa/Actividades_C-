using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Herramientas
{
    public abstract class Personaje : IJugador
    {
        public delegate void AtaqueHandler(Personaje p,int n);

        private decimal id;
        private short nivel;
        private string nombre;
        private int puntosDefensa;
        private int puntosDePoder;
        private int puntosDeVida;
        private static Random random;
        private string titulo;
        public event AtaqueHandler AtaqueLanzado;
        public event AtaqueHandler AtaqueRecibido;

        public int PuntosDeDefensa 
        {
            get 
            {
                return puntosDefensa;
            }
            set 
            {
                puntosDefensa = value;
            }
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

        public string Titulo
        {
            get => titulo;
            set => titulo = value;
        }

        public short Nivel
        {
            get
            {
                return this.nivel;
            }
        }

        public int PuntosDeVida
        {
            get
            {
                return this.puntosDeVida;
            }
        }

        static Personaje() 
        { 
            random = new Random();
        }

        private Personaje()
        {
            this.puntosDefensa = 100;
            this.puntosDePoder = 100 * this.Nivel;
            this.puntosDeVida = 500 * this.Nivel;
            this.nivel = 1;
        }

        public Personaje(decimal id, string nombre) : this()
        {
            try 
            {
                this.id = id;
                if (String.IsNullOrEmpty(nombre))
                {
                    throw new ArgumentNullException();
                }

                this.nombre = nombre.Trim();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ERROR EL NOMBRE ESTA VACIO");
            }
            
            
        }

        public Personaje(decimal id, string nombre, short nivel) : this (id, nombre) 
        {
            int maximo = 100;
            int minimo = 1;
            string mensaje = "El nivel seleccionado, esta fuera del rango o no es correcto";

            if (nivel >= minimo && nivel <= maximo)
            {
                this.nivel = nivel;

                // Recalcular puntos ahora que nivel ya está asignado
                this.puntosDefensa = 100;
                this.puntosDePoder = 100 * nivel;
                this.puntosDeVida = 500 * nivel;
            }
            else
            {
                throw new BusinessException(mensaje);
            }

        }
        public Personaje(decimal id, string nombre, short nivel, string titulo = "")
            : this(id, nombre, nivel)
        {
            this.titulo = titulo?.Trim() ?? "";
        }

        // Override de Equals
        public override bool Equals(object obj)
        {
            if (obj is Personaje otro)
            {
                return this.id == otro.id;
            }
            return false;
        }

        // Override de GetHashCode
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public static bool operator ==(Personaje a, Personaje b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;

            return a.id == b.id;
        }

        public static bool operator !=(Personaje personaje, Personaje otroPersonaje)
        {
            return !(personaje == otroPersonaje);
        }

        protected abstract void AplicarBeneficioDeClase();

        public int Atacar()
        {
            // Detener ejecución entre 1 y 5 segundos
            int tiempoEspera = random.Next(1000, 5001);
            Task.Delay(tiempoEspera).Wait();  // Espera bloqueante

            // Calcular porcentaje de ataque aleatorio entre 10% y 100%
            int porcentaje = random.Next(10, 101);
            int puntosAtaque = (this.puntosDePoder * porcentaje) / 100;

            // Lanzar evento si hay suscriptores
            AtaqueLanzado?.Invoke(this, puntosAtaque);

            return puntosAtaque;
        }

        public void RecibirAtaque(int puntosAtaque)
        {
            int porcentajeDefensa = random.Next(10, 101);
            int defensa = (PuntosDeDefensa * porcentajeDefensa) / 100;

            int dañoFinal = puntosAtaque - defensa;
            if (dañoFinal < 0)
                dañoFinal = 0;

            this.puntosDeVida -= dañoFinal;
            if (this.puntosDeVida < 0)
                this.puntosDeVida = 0;

            AtaqueRecibido?.Invoke(this, dañoFinal);
        }



        public override string ToString()
        {
            if (string.IsNullOrEmpty(titulo))
                return nombre;
            else
                return $"{nombre} - {titulo}";
        }
    }
}
