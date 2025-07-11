namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Contador de palabras";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> palabras = new Dictionary<string, int>();

            /*
                Toma el texto completo (rtbPalabras.Text).
                Lo separa por espacios, saltos de línea y tabulaciones
                Elimina los elementos vacíos (RemoveEmptyEntries
                Cuenta cuántas palabras hay con .Length.
             */

            string[] palabrasArray = rtbPalabras.Text.Split(new char[] { ' ', '\n', '\r', '\t' }, 
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in palabrasArray)
            {
                string palabraLimpia = palabra.ToLower();

                if (palabras.ContainsKey(palabraLimpia))
                {
                    palabras[palabraLimpia]++;
                }
                else
                {
                    palabras.Add(palabraLimpia, 1);
                }
            }

            // Ordenar de mayor a menor por cantidad
            var top3 = palabras.OrderByDescending(p => p.Value).Take(3);

            // Crear mensaje
            string mensaje = "Top 3 palabras:\n";
            foreach (var item in top3)
            {
                mensaje += $"{item.Key}: {item.Value}\n";
            }

            // Mostrar
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
