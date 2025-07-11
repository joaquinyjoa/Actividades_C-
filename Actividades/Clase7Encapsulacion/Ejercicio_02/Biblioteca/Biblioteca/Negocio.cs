using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        private Queue<Cliente> clientesPendientes;

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }


        public Cliente Cliente 
        {
            get { return clientes.Peek(); }
            set
            { 
                if (!this.clientes.Contains(value))
                {
                    this.clientes.Enqueue(value);
                }
                
            }
        }

        private Negocio() 
        {
            this.clientes = new Queue<Cliente>();
            this.caja  = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio (string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c) 
        {
            bool agregar = true; // Asumo que puedo agregar

            if (n.clientes.Count > 0)
            {
                foreach (Cliente cli in n.clientes)
                {
                    if (cli == c)  // Si ya existe en la cola
                    {
                        agregar = false;
                        break;
                    }
                }
            }


            if (agregar)
            {
                n.clientes.Enqueue(c);
            }

            return agregar;
        }

        public static bool operator ==(Negocio n, Cliente c) 
        {
            bool existe = false;
            if (n.clientes.Count > 0)
            {
                foreach (Cliente clie in n.clientes)
                {
                    if (clie == c)
                    {
                        existe = true;
                        break;
                    }
                }
            }

            return existe;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            bool existe = true;
            if (n.clientes.Count > 0)
            {
                foreach (Cliente clie in n.clientes)
                {
                    if (clie == c)
                    {
                        existe = false;
                        break;
                    }
                }
            }

            return existe;
        }

        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                // Obtener el primer cliente (sin quitarlo todavía)
                Cliente clienteActual = n.Cliente;

                // Llamar al método Atender del PuestoAtencion
                if (n.caja.Atender(clienteActual))
                {
                    // Si fue atendido, quitarlo de la cola
                    n.clientes.Dequeue();
                    return true;
                }
            }

            return false;
        }
    }
}
