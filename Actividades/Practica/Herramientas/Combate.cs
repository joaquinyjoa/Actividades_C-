using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Herramientas
{
    public sealed class Combate
    {
        public delegate void Manejadora(IJugador jugador1, IJugador jugador2);

        private IJugador atacado;
        private IJugador atacante;
        private static Random random;

        public event Manejadora RondaIniciada;
        public event Action<IJugador> CombateFinalizado;

        static Combate()
        {
            random = new Random();
        }

        private Combate() { }

        public Combate(IJugador jugador1, IJugador jugador2) : this ()
        {
            this.atacante = SeleccionarPrimerAtacante(jugador1, jugador2);
            if (this.atacante == jugador1) 
            {
                this.atacado = jugador2;
            }
            else 
            {
                this.atacado = jugador1;
            }
               
        }

        private void Combatir()
        {
            IJugador ganador = null;

            while (ganador == null)
            {
                IniciarRonda();
                ganador = EvaluarGanador();
            }

            CombateFinalizado?.Invoke(ganador);

            ResultadoCombate resultado = new ResultadoCombate
            {
                NombreGanador = ganador.ToString(),
                NombrePerdedor = (ganador == atacante ? atacado : atacante).ToString(),
                FechaCombate = DateTime.Now
            };

            string json = JsonSerializer.Serialize(resultado);
            File.WriteAllText("combate_resultado.json", json);
        }

        private IJugador EvaluarGanador()
        {
            if (this.atacado.PuntosDeVida == 0)
            {
                return this.atacante;
            }
            else
            {
                IJugador temp = this.atacante;
                this.atacante = this.atacado;
                this.atacado = temp;
                return null;
            }
        }

        public Task IniciarCombate()
        {
            return Task.Run(() => Combatir());
        }

        private void IniciarRonda()
        {
            RondaIniciada?.Invoke(this.atacante, this.atacado);

            int puntosAtaque = this.atacante.Atacar();
            this.atacado.RecibirAtaque(puntosAtaque);
        }

        private IJugador SeleccionarJugadorAleatoriamente(IJugador jugador1, IJugador jugador2)
        {
            IJugador ganador = jugador2;
            
            if (Aleatorio.TirarUnaMoneda() == "Cara")
            {
                ganador = jugador1;
            }

            return ganador;
        }

        private IJugador SeleccionarPrimerAtacante(IJugador jugador1, IJugador jugador2)
        {
            IJugador atacante = SeleccionarJugadorAleatoriamente(jugador1, jugador2);

            if (jugador1.Nivel != jugador2.Nivel)
            {
                if (jugador1.Nivel < jugador2.Nivel)
                {
                    atacante = jugador1;
                }
                else
                {
                    atacante = jugador2;
                }

            }
            
            return atacante;
        }
    }

    public class ResultadoCombate
    {
        public string NombreGanador { get; set; }
        public string NombrePerdedor { get; set; }
        public DateTime FechaCombate { get; set; }
    }
}
