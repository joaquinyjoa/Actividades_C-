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
            usuario = new Usuario(
                txtNombre.Text,
                txtApellido.Text,
                Convert.ToInt32(txtDni.Text),
                txtCorreo.Text
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
