using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Herramientas
{
    public sealed class Combate
    {
        public delegate void RondaHandler(IJugador jugador1, IJugador jugador2);
        public delegate void CombateFandler(IJugador jugador);

        private IJugador atacado;
        private IJugador atacante;
        private static Random random;

        public event RondaHandler RondaIniciada;
        public event CombateFandler CombateFinalizado;

        private Combate() { }

        static Combate() 
        {
            random = new Random();
        }

        public Combate(IJugador jugador1, IJugador jugador2) 
        {
            this.atacante = SeleccionarJugadorAleatoriamente(jugador1, jugador2);
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
            DateTime fecha = DateTime.Now;
            while (ganador == null)
            {
                IniciarRonda();
                ganador = EvaluarGanador();
            }
            CombateFinalizado?.Invoke(ganador);

            ResultadoCombate resultadoCombate = new ResultadoCombate(fecha, this.atacante.Nombre, this.atacado.Nombre);

            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(resultadoCombate, opciones);

            File.WriteAllText("Combatir.json", jsonString);
        }

        private IJugador EvaluarGanador() 
        {
            IJugador jugador = null;
            if (this.atacado.PuntosDeVida == 0)
            {
                jugador = this.atacante;
            }
            
            IJugador temporal = this.atacado;
            this.atacado = this.atacante;
            this.atacante = temporal;

            return jugador;
        }

        public Task IniciarCombate() 
        {
            return Task.Run(() => Combatir());
        }

        public void IniciarRonda() 
        {
            RondaIniciada?.Invoke(this.atacante, this.atacado);
            int ataque = atacante.Atacar();
            this.atacado.RecibirAtaque(ataque);
        }

        private IJugador SeleccionarJugadorAleatoriamente(IJugador jugador1, IJugador jugador2) 
        {
            string resultado = Aleatorio.TirarMoneda();
            IJugador jugador = jugador2;

            if (resultado == "Cara")
            {
                jugador = jugador1;
            }
            return jugador;
        }

        private IJugador SeleccionarPrimerAtacante(IJugador jugador1, IJugador jugador2)
        {
            IJugador jugador = jugador2;

            if (jugador1.Nivel != jugador2.Nivel)
            {
                if (jugador1.Nivel < jugador2.Nivel)
                {
                    jugador = jugador1;
                }
            }
            else
            {
                jugador = SeleccionarJugadorAleatoriamente(jugador1, jugador2);
            }

            return jugador;
        }

        public class ResultadoCombate 
        {
            private DateTime fechaCombate;
            private string nombreGanador;
            private string nombrePerdedor;

            public DateTime Fecha 
            {
                get { return this.fechaCombate; }
            }

            public string NombreGanador { get => nombreGanador;}
            public string NombrePerdedor { get => nombrePerdedor; }

            public ResultadoCombate(DateTime fechaCombate, string nombreGanador, string nombrePerdedor)
            {
                this.fechaCombate = fechaCombate;
                this.nombreGanador = nombreGanador;
                this.nombrePerdedor = nombrePerdedor;
            }

        }
    }
}
