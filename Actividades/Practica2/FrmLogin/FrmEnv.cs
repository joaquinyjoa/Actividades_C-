using Entidades.Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmEnv : Form
    {
        private Usuario usuario;

        public Usuario UsuarioCreado => usuario; // ✅ propiedad pública de solo lectura

        public FrmEnv()
        {
            InitializeComponent();
        }

        public FrmEnv(Usuario usuarioExistente) : this()
        {
            txtCorreo.Text = usuarioExistente.Correo;
            txtContraseña.Text = usuarioExistente.Clave;
            txtNombre.Text = usuarioExistente.Nombre;
            txtApellido.Text = usuarioExistente.Apellido;
            txtDni.Text = usuarioExistente.Dni.ToString();

            txtDni.ReadOnly = true; //Importante: no se permite modificar DNI
        }

        public FrmEnv(Usuario usuarioEliminar, bool soloLectura) : this(usuarioEliminar)
        {
            // Deshabilita todos los controles para que no se puedan modificar
            txtCorreo.ReadOnly = true;
            txtContraseña.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDni.ReadOnly = true;

            btnEnviar.Text = "Eliminar"; // Cambiar texto del botón
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación básica de campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Intentar convertir el DNI
                if (!int.TryParse(txtDni.Text, out int dni))
                {
                    MessageBox.Show("El DNI debe ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear el usuario si todo está correcto
                usuario = new Usuario(
                    txtNombre.Text,
                    txtApellido.Text,
                    dni,
                    txtCorreo.Text
                );

                // Si llegamos hasta acá, cerrar correctamente
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error de formato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Número demasiado grande o pequeño: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
