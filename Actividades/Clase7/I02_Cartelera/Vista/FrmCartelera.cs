using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;

        public FrmCartelera()
        {
            InitializeComponent();
        }

        static FrmCartelera()
        {
            string rutaAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rutaArchivo = Path.Combine(rutaAppData, "listaSupermercado.xml");
            rutaConfiguracion = rutaArchivo;
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            // Asigno el color actual del panel al ColorDialog
            colorDialog.Color = pnlCartel.BackColor;

            // Muestro el diálogo para que el usuario elija un color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario presionó OK, asigno el color seleccionado al panel
                pnlCartel.BackColor = colorDialog.Color;
            }
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            colorDialog.Color = lblTitulo.ForeColor;

            // Muestro el diálogo para que el usuario elija un color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario presionó OK, asigno el color seleccionado al label
                lblTitulo.ForeColor = colorDialog.Color;
            }
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            colorDialog.Color = lblMensaje.ForeColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblMensaje.ForeColor = colorDialog.Color;
            }
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(rutaConfiguracion))
                {
                    string jsonString = File.ReadAllText(rutaConfiguracion);

                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(jsonString);

                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcto",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }


        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
            Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);

            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(cartel, opciones);

            // Guardo el JSON desde un archivo.
            File.WriteAllText(rutaConfiguracion, jsonString);
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string rutaNuevoArchivo = ofd.FileName;
                    string jsonString = File.ReadAllText(rutaNuevoArchivo);

                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(jsonString);

                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);

                }
                catch (JsonException)
                {
                    MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcto",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                }
                catch (Exception)
                {
                    MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcto",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                }

            }
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            // 1. Pregunta de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar la configuración?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // 2. Elimina el archivo si existe
                    if (File.Exists(rutaConfiguracion))
                    {
                        File.Delete(rutaConfiguracion);
                    }

                    // 3. Restablece los controles a sus valores por defecto
                    txtTitulo.Text = "Título";
                    lblTitulo.ForeColor = Control.DefaultForeColor;

                    rtxtMensaje.Text = "Mensaje";
                    lblMensaje.ForeColor = Control.DefaultForeColor;

                    pnlCartel.BackColor = Control.DefaultBackColor;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la configuración:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
