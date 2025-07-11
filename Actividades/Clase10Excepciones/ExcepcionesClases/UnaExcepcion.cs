namespace ExcepcionesClases
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }
    }
}
