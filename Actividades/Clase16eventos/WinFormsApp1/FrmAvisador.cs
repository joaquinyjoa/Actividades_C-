namespace WinFormsApp1
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;

        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtNombre.Text)) 
            {
               

                if (persona == null)
                {
                    persona = new Persona();
                    // Suscribirse al evento solo una vez
                    persona.EventroString += NotificarCambio;
                }

                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;

                this.lblNombreCompleto.Text = persona.Mostrar();
                this.btnCrear.Text = "Actualizar";
            }

        }

        public void NotificarCambio(string Cambio) 
        {
            MessageBox.Show(Cambio);
        }
    }
}
