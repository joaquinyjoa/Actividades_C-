using Biblioteca_de_clases;
namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Registro";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string genero = "";
            List<string> seleccionados = new List<string>();

            //Creacion de variables para validar campos vacios, no chequeados y obtener un numero
            bool nombreVacio = String.IsNullOrEmpty(nombre);
            bool direccionVacia = String.IsNullOrEmpty(direccion);
            decimal edad = nudEdad.Value;
            bool estaCSharp = chbCSharp.Checked;
            bool estaCPlasPlas = chbCPlasPlas.Checked;
            bool estaJavaScript = chbJavaScript.Checked;
            int seleccionPaises = lbPaises.SelectedIndex;

            if (nombreVacio)
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (direccionVacia)
            {
                MessageBox.Show("El campo Direccion es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (edad < 18 || edad > 65)
            {
                MessageBox.Show("La edad debe estar entre 18 y 65 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!estaCSharp && !estaCPlasPlas && !estaJavaScript)
            {
                MessageBox.Show("Debe seleccionar uno de los tres cursos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(seleccionPaises == -1)
            {
                MessageBox.Show("Debe seleccionar uno de los tres paises", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {    
                if (chbCPlasPlas.Checked)
                {
                    seleccionados.Add(chbCPlasPlas.Text);
                }
                if (chbCSharp.Checked)
                {
                    seleccionados.Add(chbCSharp.Text);
                }
                if (chbJavaScript.Checked)
                {
                    seleccionados.Add(chbJavaScript.Text);
                }

                string[] cursosSeleccionados = seleccionados.ToArray();

                
                if (rdbMasculino.Checked)
                {
                    genero = rdbMasculino.Text;
                }
                else if (rdbFemenino.Checked)
                {
                    genero = rdbFemenino.Text;
                }
                else if (rdbNoBinario.Checked)
                {
                    genero = rdbNoBinario.Text;
                }

                string pais = lbPaises.SelectedItem.ToString();

                Integrante i = new Integrante(cursosSeleccionados, direccion, (int)edad, genero, nombre, pais);

                // Mostrar datos con MessageBox
                MessageBox.Show(i.Mostrar(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
