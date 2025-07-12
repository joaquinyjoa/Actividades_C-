namespace BibliotecaContabilidad
{
    public class Contabilidad<T, U> 
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad() 
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.egresos.Add(egreso);  // Solo agregás el elemento
            return c;               // Y devolvés el mismo objeto
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingresos)
        {
            c.ingresos.Add(ingresos);  // Solo agregás el elemento
            return c;               // Y devolvés el mismo objeto
        }
    }
}
