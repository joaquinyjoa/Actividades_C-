namespace Clientes
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja c, string mensaje);

        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;

        static Caja() 
        {
            random = new Random();
        }

        public string NombreCaja { get => nombreCaja; }

        public int CantidadDeClientesALaEspera 
        {
            get 
            {
                return this.clientesALaEspera.Count;
            }

        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegado) 
        {
            clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegado;
        }

        internal void AgregarCliente(string cliente) 
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion(CancellationToken token)
        {
            return Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    if (clientesALaEspera.Any())
                    {
                        string nombreCliente = clientesALaEspera.Dequeue();
                        this.delegadoClienteAtendido?.Invoke(this, nombreCliente);
                        Thread.Sleep(random.Next(1000, 5000)); // Simula tiempo de atención
                    }
                    else
                    {
                        Thread.Sleep(500); // Espera medio segundo si no hay clientes
                    }
                }
            }, token);
        }
    }
}
