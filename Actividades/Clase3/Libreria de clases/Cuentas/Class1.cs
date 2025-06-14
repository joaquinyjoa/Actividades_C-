using System.Text;

namespace Cuentas
{
    public class Cuenta
    {
        private string titular;
        private decimal montoActual;

        public Cuenta(string titular, decimal montoActual)
        {
            this.titular = titular;
            this.montoActual = montoActual;
        }

        public string Titular { get { return titular; } }
        public decimal MontoActual { get {  return montoActual; } }

        public string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"El nombre del titular es: {Titular}");
            mensaje.AppendLine($"El monto actual del titular es: {MontoActual}");
            
            return mensaje.ToString();
        }

        public decimal Ingresar(decimal monto) 
        {
            if (monto >= 0)
            {
                montoActual += monto;
            }

            return montoActual;
        }

        public decimal Retirar(decimal monto) 
        {
            montoActual -= monto;

            return montoActual;
        }
    }
}
