using Herramientas;
internal class Program
{
    private static void Main(string[] args)
    {
        Logger logger = new Logger("log.txt");

        try
        {
            Personaje personaje1 = PersonajeDAO.ObtenerPersonajePorID(1);
            Personaje personaje2 = PersonajeDAO.ObtenerPersonajePorID(2);

            // Suscribir eventos AtaqueLanzado y AtaqueRecibido
            personaje1.AtaqueLanzado += MostrarAtaqueLanzado;
            personaje1.AtaqueRecibido += MostrarAtaqueRecibido;

            personaje2.AtaqueLanzado += MostrarAtaqueLanzado;
            personaje2.AtaqueRecibido += MostrarAtaqueRecibido;

            Combate combate = new Combate(personaje1, personaje2);

            // Suscribir eventos combate
            combate.RondaIniciada += IniciarRonda;
            combate.CombateFinalizado += FinalizarCombate;

            Console.WriteLine("¡FIGHT!");
            string textoLog = $" PELEA INICIADA";
            logger.GuardarLog(textoLog); // Usa la variable existente
            combate.IniciarCombate().Wait();
        }
        catch (BusinessException ex)
        {
            // Solo mensaje simple para BusinessException
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Error de negocio: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Para cualquier otra excepción: mensaje + stacktrace + log
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error inesperado: {ex.Message}");
            Console.WriteLine(ex.StackTrace);

            string textoLog = $"Error inesperado: {ex.Message}\nStackTrace:\n{ex.StackTrace}";
            logger.GuardarLog(textoLog); // Usa la variable existente
        }

        static void IniciarRonda(IJugador atacante, IJugador atacado)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"¡{atacante} ataca a {atacado}!");
        }

        static void FinalizarCombate(IJugador ganador)
        {
            Logger logger = new Logger("log.txt");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Combate finalizado. El ganador es {ganador}.");
            string textoLog = $" PELEA TERMINADA GANADOR: {ganador}";
            logger.GuardarLog(textoLog); // Usa la variable existente
        }

        static void MostrarAtaqueLanzado(Personaje personaje, int puntosDeAtaque)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{personaje} lanzó un ataque de {puntosDeAtaque} " +
            "puntos. ");
        }

        static void MostrarAtaqueRecibido(Personaje personaje, int puntosDeAtaque)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{personaje} recibió un ataque por {puntosDeAtaque} " +
            $"puntos.Le quedan {personaje.PuntosDeVida} " +
            $"puntos de vida. ");
        }
    }
}