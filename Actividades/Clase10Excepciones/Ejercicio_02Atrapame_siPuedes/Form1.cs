namespace Ejercicio_02Atrapame_siPuedes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string kilometros = this.txtKilometros.Text;
            string litros = this.txtLitros.Text;

            if (String.IsNullOrEmpty(kilometros) || String.IsNullOrEmpty(litros))
            {
                throw new ParametrosVaciosException("Ingrese kilometros y los litros");
            }
            else
            {
                try 
                {
                    int kilometrosIngresados = int.Parse(kilometros);
                    int litrosIngresados = int.Parse(litros);

                    string total = Calculador.Calcular(kilometrosIngresados, litrosIngresados).ToString();

                    if (total == "0" && litrosIngresados != 0)
                    {
                        throw new DivideByZeroException();
                        
                    }
                    else
                    {
                        this.richTextBox1.AppendText($"{total}\n");
                    }
                    
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message, "ADVERTENCIA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede dividir por cero", "ADVERTENCIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
