using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Persona
    {
        public delegate void DelegadoString(string str);
        public event DelegadoString EventoString;

        private string apellido;
        private string nombre;

        public string Nombre {
            get => nombre;
            set
            {
                nombre = value;
                EventoString?.Invoke($"Nombre modificado a: {nombre}");
            }
        }
        public string Apellido { 
            get => apellido; 
            set
            {
                nombre = value;
                EventoString?.Invoke($"Apellido modificado a: {nombre}");
            }
        }

        public Persona()
        { }

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Nombre} {Apellido}");
            return sb.ToString();
        }

    }
}
