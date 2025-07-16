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
                string clave = this.txtContraseña.Text;

                if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave))
                {
                    MessageBox.Show("Por favor, ingrese correo y contraseña.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Correo o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
