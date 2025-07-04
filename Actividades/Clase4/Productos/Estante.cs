using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante): this (capacidad)
        { 
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] getProducto() 
        {
            return productos;
        }

        /// <summary>
        /// Muestra el estante con cada producto
        /// </summary>
        /// <param name="e">El estante pasado por parametros</param>
        /// <returns>Un string con el contenido del array producto</returns>
        public static string MostrarEstante(Estante e) 
        {
            StringBuilder mensaje = new StringBuilder();
            foreach (Producto producto in e.getProducto())
            {
                mensaje.AppendLine(Producto.MostrarProducto(producto));
            }

            return mensaje.ToString();
        }

        //verifica si el producto existe
        public static bool operator ==(Estante e, Producto p) 
        {
            bool bandera = false;
            foreach (Producto producto in e.getProducto())
            {
                if (producto == p)
                {
                    bandera = true;
                    break;
                }
            }

            return bandera;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        /// <summary>
        /// Agrega un producto si no supero la cantidad de la estanteria
        /// </summary>
        /// <param name="e">Obj de tipo Estante</param>
        /// <param name="p">Obj de tipo Producto</param>
        /// <returns>un booleano, true si se agrego, caso contrario false</returns>
        public static bool operator +(Estante e, Producto p)
        {
            bool bandera = true;
            int espacio = e.getProducto().Length;

            for (int i = 0; i < espacio; i++)
            {
                
                if (Object.ReferenceEquals(e.getProducto()[i], null))
                {
                    e.getProducto()[i] = p;
                    break;
                }
                //valido si el espacio esta vacio
                else if (e.getProducto()[i] == p)
                {
                    bandera = false;
                    break;
                }

            }

            return bandera;
        }

        public static bool operator -(Estante e, Producto p) 
        {
            bool bandera = false;
            int espacio = e.getProducto().Length;

            for (int i = 0; i < espacio; i++)
            {
                if (e.getProducto()[i] == p)
                {
                    bandera = true;
                    e.getProducto()[i] = null;
                    break;
                }
  
            }

            return bandera;
        }
    }
}
