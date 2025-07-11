namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadDeMarchas;
        private short cantidadDePasajeros;

        public Automovil(short cantidadDeRuedas, short cantidadDePuertas, Colores color,
            short cantidadDeMarchas, short cantidadDePasajeros)
            :base(cantidadDeRuedas, cantidadDePuertas, color)
        {
            this.cantidadDeMarchas = cantidadDeMarchas;
            this.cantidadDePasajeros = cantidadDePasajeros;
        }
    }
}
