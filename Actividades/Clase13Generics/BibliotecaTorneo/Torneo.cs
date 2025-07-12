using System.Text;

namespace BibliotecaTorneo
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos = new List<T>();
        private string nombre;

        public Torneo(string nombre) 
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public string JugarPartido
        {
            get 
            {
                Random e1 = new Random();
                Random e2 = new Random();

                T equipo1 = equipos[e1.Next(0, equipos.Count)];
                T equipo2 = equipos[e2.Next(0, equipos.Count)];

                return CalcularPartido(equipo1, equipo2);
            }
        }

        public bool EstaInscripto(T equipo)
        {
            foreach (T e in this.equipos)
            {
                if (e == equipo)  // usa el == de Equipo
                {
                    return true;
                }
            }
            return false;
        }


        public static bool operator ==(Torneo<T> torneo, T e)
        {
            foreach (T eq in torneo.equipos)
            {
                if (eq == e)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T e)
        {
            return !(torneo == e);
        }

        public static bool operator +(Torneo<T> torneo, T e) // Cambiado a T
        {
            bool agregar = true;
            foreach (T eq in torneo.equipos) // Cambiado a T
            {
                if (eq == e)
                {
                    agregar = false;
                    break;
                }
            }
            if (agregar)
            {
                torneo.equipos.Add(e);
            }
            return agregar;
        }

        private string CalcularPartido(T a, T b) 
        {
            string mensaje = "";

            Random random = new Random();
            int resultadoA = random.Next(0, 10);
            int resultadoB = random.Next(0, 10);

            if (a is EquipoBasquet && b is EquipoBasquet)
            {
                mensaje = $"{a.Nombre} {resultadoA} - {resultadoB} {b.Nombre}";
            }
            else if (a is EquipoFutbol && b is EquipoFutbol)
            {
                mensaje = $"{a.Nombre} {resultadoA} - {resultadoB} {b.Nombre}";
            }

            return mensaje;
        }

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del torneo: {this.nombre}");
            sb.AppendLine($"Equipos: ");
            foreach (Equipo equipo in equipos)
            {
                sb.AppendLine($"{equipo.Ficha()}");
            }

            return sb.ToString();
        }
    }
}
