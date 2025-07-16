namespace Clubes
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo() 
        {
            jugadores = new List<Jugador>{ };
        }

        public Equipo(short cantidadDeJugadores, string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e,Jugador j) 
        {
            bool jugadorExiste = false;

            for (int i = 0; i < e.jugadores.Count; i++)
            {
                if (e.jugadores[i] == j)
                {
                    jugadorExiste = true;
                    break;
                }
            }

            if (!jugadorExiste && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                jugadorExiste = true;
            }

            return jugadorExiste;
        }

    }
}
