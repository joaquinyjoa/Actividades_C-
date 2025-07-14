using NameGenerator.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Clientes
{
    public class Negocio
    {
        private static RealNameGenerator nombreGenerado;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;
        private CancellationTokenSource cts;  // para controlar la cancelación

        static Negocio() 
        {
            nombreGenerado = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas) 
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
            cts = new CancellationTokenSource();  // ¡Importante!
        }

        public List<Task> ComenzarAtencion()
        {
            CancellationToken token = cts.Token;

            List<Task> tareas = new List<Task>();

            foreach (Caja caja in this.cajas)
            {
                // Generar clientes → Cola global
                Task tareaGenerarClientes = Task.Run(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        string nuevoCliente = nombreGenerado.Generate();
                        clientes.Enqueue(nuevoCliente); // ✅ CORRECTO
                        Thread.Sleep(1000);
                    }
                }, token);
                tareas.Add(tareaGenerarClientes);

                // Asignar a la caja con menos clientes
                Task tareaAsignarClientes = Task.Run(() =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        if (clientes.TryDequeue(out string cliente) &&
                            !string.IsNullOrWhiteSpace(cliente))
                        {
                            var cajaMenosClientes = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                            cajaMenosClientes.AgregarCliente(cliente);
                        }
                        Thread.Sleep(500);
                    }
                }, token);
                tareas.Add(tareaAsignarClientes);

                // Atención en la caja
                Task tareaAtencion = caja.IniciarAtencion(token); // token se pasa
                tareas.Add(tareaAtencion);
            }

            return tareas;
        }


        
    }
}
