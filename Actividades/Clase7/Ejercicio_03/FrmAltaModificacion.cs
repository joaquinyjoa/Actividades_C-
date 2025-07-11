namespace Ejercicio_03
{
    public partial class FrmAltaModificacion : Form
    {
        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        public FrmAltaModificacion(string titulo, string textoObjeto, string textoConfirm)
        {
            InitializeComponent();
            this.Text = titulo;
            this.txtObjeto.Text = textoObjeto;
            this.btnConfirmar.Text = textoConfirm;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtObjeto.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) 
            {
                this.DialogResult= DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
