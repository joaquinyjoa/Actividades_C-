namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //botones de minimizar y maximizar
            this.MinimizeBox = true;
            this.MaximizeBox = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //agrego las materias
            this.cmb_materia.Items.Add("Programacion 2");
            this.cmb_materia.Items.Add("Estadistica");
            this.cmb_materia.Items.Add("Nada");
        }

        /*es un evento, cuando tenemos una reaccion a algo y dice que accion va a tomar
         si lo comentas se rompe, porque hay un evento que no esta manejado
         */
        private void btn_saludar_Click(object sender, EventArgs e)
        {
            //this = Form1                                                    verifico que se selecciono una
            if (!String.IsNullOrWhiteSpace(tb_nombre.Text) && !String.IsNullOrWhiteSpace(tb_apellido.Text) && cmb_materia.SelectedIndex != -1)
            {
                string nombre = this.tb_nombre.Text;
                string apellido = this.tb_apellido.Text;
                string titulo = "¡HOLA, WINDOWSFORMS!";
                //                                                                              muestro la materia seleccionada
                string mensaje = $"Soy {nombre}, {apellido} y mi materia favorita es {cmb_materia.SelectedItem}";

                //creado en memoria
                FrmIngreso ingreso = new FrmIngreso(titulo, mensaje);//es un formulario

                ingreso.Show();// asi deja vivo lso dos formularios
                Hide();//con hide pasamos directo al menu 

                //MessageBox.Show("hola");//mostrara un mensaje
            }
            else
            {
                // Armo el mensaje de error
                string mensajeError = "Se deben completar los siguientes campos:\n";

                if (String.IsNullOrWhiteSpace(tb_nombre.Text))
                {
                    mensajeError += "\nNombre";
                }
                if (String.IsNullOrWhiteSpace(tb_apellido.Text))
                {
                    mensajeError += "\nApellido";
                }

                // Muestro el error con ícono de error y botón OK
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpio los campos
                this.tb_nombre.Text = string.Empty;//string.Empty == "" es lo mismo
                this.tb_apellido.Text = string.Empty;
            }
        }
    }
}
