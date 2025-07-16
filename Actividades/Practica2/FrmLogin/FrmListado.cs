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
    public partial class FrmListado : Form
    {
        private List<Usuario> usuarios;

        public FrmListado()
        {
            InitializeComponent();

            // Suscripción al evento del ADO
            ADO.Instancia.ApellidoUsuarioExistente += ManejarApellidoExistente;
            ADO.Instancia.ApellidoUsuarioExistente += Manejador_apellidoExistenteLog;
            ADO.Instancia.ApellidoUsuarioExistente += Manejador_apellidoExistenteJSON;

            RefrescarGrilla();
            usuarios = ADO.Instancia.ObtenerTodos(); // método corregido previamente
            dgvUsuarios.DataSource = usuarios;
        }

        private void Manejador_apellidoExistenteJSON(object sender, List<Usuario> usuarios)
        {
            try
            {
                string rutaEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "usuarios_repetidos.json");

                if (!Manejadora.SerializarJSON(usuarios, rutaEscritorio))
                {
                    MessageBox.Show("Error al serializar los usuarios repetidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Manejador_apellidoExistenteLog(object sender, List<Usuario> usuarios)
        {
            try
            {
                if (!Manejadora.EscribirArchivo(usuarios))
                {
                    MessageBox.Show("Error al escribir el archivo de log.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManejarApellidoExistente(object sender, List<Usuario> usuarios)
        {
            try
            {
                string mensaje = "Ya existen usuarios con ese apellido:\n\n";
                foreach (var u in usuarios)
                {
                    mensaje += $"{u.Nombre} {u.Apellido} - DNI: {u.Dni}\n";
                }

                MessageBox.Show(mensaje, "Apellido duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar aviso de duplicado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEnv frmAlta = new FrmEnv();

                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    Usuario nuevoUsuario = frmAlta.UsuarioCreado;

                    if (ADO.Instancia.Agregar(nuevoUsuario))
                    {
                        MessageBox.Show("Usuario agregado con éxito");
                        RefrescarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar usuario");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar agregar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario seleccionado = (Usuario)dgvUsuarios.CurrentRow?.DataBoundItem;

                if (seleccionado is not null)
                {
                    FrmEnv frmModificar = new FrmEnv(seleccionado);

                    if (frmModificar.ShowDialog() == DialogResult.OK)
                    {
                        Usuario actualizado = frmModificar.UsuarioCreado;

                        if (ADO.Instancia.Modificar(actualizado))
                        {
                            MessageBox.Show("Usuario modificado correctamente");
                            RefrescarGrilla();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el usuario");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario seleccionado = (Usuario)dgvUsuarios.CurrentRow?.DataBoundItem;

                if (seleccionado is not null)
                {
                    FrmEnv frmEliminar = new FrmEnv(seleccionado, soloLectura: true);

                    if (frmEliminar.ShowDialog() == DialogResult.OK)
                    {
                        if (ADO.Instancia.Eliminar(seleccionado))
                        {
                            MessageBox.Show("Usuario eliminado correctamente");
                            RefrescarGrilla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el usuario");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarGrilla()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = ADO.Instancia.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar la grilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
    }
