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
            string correo = this.txtCorreo.Text;
            string clave = this.txtContraseña.Text;

            login = new Login(correo, clave);

            if (login.Loguear())
            {
                FrmPrincipal principal = new FrmPrincipal();
                this.Hide();
                principal.Show();
            }
        }
    }
}
