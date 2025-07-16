using Entidades.Final;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        private Login login;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = this.txtCorreo.Text;
                string clave = this.txtContrase�a.Text;

                if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave))
                {
                    MessageBox.Show("Por favor, ingrese correo y contrase�a.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                login = new Login(correo, clave);

                if (login.Loguear())
                {
                    FrmPrincipal principal = new FrmPrincipal();
                    this.Hide();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Correo o contrase�a incorrectos.", "Error de autenticaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al intentar iniciar sesi�n: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
