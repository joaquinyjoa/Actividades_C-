using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

//cambiar codigo

namespace Conductores
{
    public class Conductor
    {
        private string nombre;
        private string kilometroUno;
        private string kilometroDos;
        private string kilometroTres;
        private string kilometroCuatro;
        private string kilometroCinco;
        private string kilometroSeis;
        private string kilometroSiete;

        public Conductor (string nombre, string diaUno, string diaDos, string diaTres, string diaCuatro, string diaCinco, string diaSeis, string diaSiete)
        {
            this.nombre = nombre;
            this.kilometroUno = diaUno;
            this.kilometroDos = diaDos;
            this.kilometroTres = diaTres;
            this.kilometroCuatro = diaCuatro;
            this.kilometroCinco = diaCinco;
            this.kilometroSeis = diaSeis;
            this.kilometroSiete = diaSiete;
        }

        public string GetNombre() 
        {
            return nombre;
        }

        public void TieneFranco(int dia) 
        {
            string franco = "0 (Tiene franco)";
            switch (dia)
            {
                case 1:
                    this.kilometroUno = franco;
                    break;
                case 2:
                    this.kilometroDos = franco;
                    break;
                case 3:
                    this.kilometroTres = franco;
                    break;
                case 4:
                    this.kilometroCuatro = franco;
                    break;
                case 5:
                    this.kilometroCinco = franco;
                    break;
                case 6:
                    this.kilometroSeis = franco;
                    break;
                case 7:
                    this.kilometroSiete = franco;
                    break;
            }
        }

        public string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Nombre del conductor: {nombre}");
            mensaje.AppendLine($"Dia 1: {kilometroUno}");
            mensaje.AppendLine($"Dia 2: {kilometroDos}");
            mensaje.AppendLine($"Dia 3: {kilometroTres}");
            mensaje.AppendLine($"Dia 4: {kilometroCuatro}");
            mensaje.AppendLine($"Dia 5: {kilometroCinco}");
            mensaje.AppendLine($"Dia 6: {kilometroSeis}");
            mensaje.AppendLine($"Dia 7: {kilometroSiete}");

            return mensaje.ToString();
        }

        public int SumarKilometrosSemana() 
        {
            string franco = "0 (Tiene franco)";
            int acumuladorKilometros = 0;
            int suma = 0;

            string[] arrayKilometros = new string[7];
            arrayKilometros[0] = kilometroUno;
            arrayKilometros[1] = kilometroDos;
            arrayKilometros[2] = kilometroTres;
            arrayKilometros[3] = kilometroCuatro;
            arrayKilometros[4] = kilometroCinco;
            arrayKilometros[5] = kilometroSeis;
            arrayKilometros[6] = kilometroSiete;

            for (int i = 0; i < arrayKilometros.Length; i++)
            {
                if (arrayKilometros[i] == franco)
                {
                    continue;
                }

                acumuladorKilometros = Convert.ToInt32(arrayKilometros[i]);
                suma += acumuladorKilometros;
            }

            return suma;
        }

        public int ObtenerKilometrosPorDia(int dia)
        {
            string valor = "0";
            switch (dia)
            {
                case 1:
                    valor = kilometroUno;
                    break;
                case 2:
                    valor = kilometroDos;
                    break;
                case 3:
                    valor = kilometroTres;
                    break;
                case 4:
                    valor = kilometroCuatro;
                    break;
                case 5:
                    valor = kilometroCinco;
                    break;
                case 6:
                    valor = kilometroSeis;
                    break;
                case 7:
                    valor = kilometroSiete;
                    break;
            }

            if (valor.StartsWith("0"))
                return 0;

            return int.Parse(valor);
        }

    }
}
