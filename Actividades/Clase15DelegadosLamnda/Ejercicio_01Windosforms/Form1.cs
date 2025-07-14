namespace Ejercicio_01Windosforms
{
    public partial class Form1 : Form
    {
        private FrmMostrar mostrar;
        private FrmTestDelegados delegados;

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mostrar = new FrmMostrar();
            this.mostrar.MdiParent = this; // acá lo hacés "hijo"

            this.delegados = new FrmTestDelegados(this.mostrar.ActualizarNombre);
            this.delegados.MdiParent = this; // Establece el MDI 
        }

        private void tsmTestDelegados_Click(object sender, EventArgs e)
        {
            this.delegados.Show();
            this.tsmMostrar.Enabled = true;
        }

        private void tsmMostrar_Click(object sender, EventArgs e)
        {
            this.mostrar.Show();
        }
    }
}
