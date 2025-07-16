using System.Text;

namespace Productos
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio) 
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca() 
        {
            return marca;
        }
    
        public float GetPrecio() 
        {
            return precio;
        }

        public static string MostrarProducto(Producto p) 
        {
            StringBuilder mensaje = new StringBuilder();

            if (object.ReferenceEquals(p, null))
            {
                mensaje.Append("Espacio vacio");
            }
            else
            {
                mensaje.AppendLine(p.marca);
                mensaje.AppendLine(p.precio.ToString());
                mensaje.AppendLine(p.codigoDeBarra);
            }

            return mensaje.ToString();
        }
 
        public static explicit operator string(Producto p)
        { 
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2) 
        { 
            return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return p.marca != marca;
        }


    }
}
