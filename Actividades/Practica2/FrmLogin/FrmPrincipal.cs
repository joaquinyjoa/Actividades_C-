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
    public partial class FrmPrincipal : Form
    {
        private GroupBox groupBoxLog; // Lo declaramos a nivel de clase para que quede accesible
        private bool colorInvertido = false;
        private CancellationTokenSource cts;

        public FrmPrincipal()
        {
            InitializeComponent();
            // Manejar el cierre para cancelar la tarea
            this.FormClosing += FrmPrincipal_FormClosing;

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();
        }

        private void tsmListadoCrud_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListado frmListado = new FrmListado();
                this.Hide();
                frmListado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el listado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmVerLog_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Abrir archivo de usuarios";
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog1.Filter = "Archivos de log (*.log)|*.log";
                openFileDialog1.DefaultExt = "log";
                openFileDialog1.FileName = "usuarios.log";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string contenido = System.IO.File.ReadAllText(openFileDialog1.FileName);

                    // Mostrar el groupBox1 y limpiar controles internos si ya los tienes creados
                    groupBox1.Visible = true;
                    groupBox1.Text = "Log Usuarios";
                    groupBox1.Controls.Clear();

                    Label lblTitulo = new Label
                    {
                        Text = "Contenido del Log:",
                        Location = new Point(10, 20),
                        AutoSize = true
                    };
                    groupBox1.Controls.Add(lblTitulo);

                    TextBox txtLogUsuarios = new TextBox
                    {
                        Name = "txtLogUsuarios",
                        Multiline = true,
                        ScrollBars = ScrollBars.Vertical,
                        ReadOnly = true,
                        Width = groupBox1.Width - 20,
                        Height = groupBox1.Height - 50,
                        Location = new Point(10, 45),
                        Text = contenido
                    };
                    groupBox1.Controls.Add(txtLogUsuarios);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el archivo de log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsmDeserializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Abrir archivo de usuarios";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                openFileDialog.DefaultExt = "json";
                openFileDialog.FileName = "usuarios_repetidos.json";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Manejadora.DeserializarJSON(openFileDialog.FileName, out List<Usuario> usuarios))
                    {
                        string contenido = string.Join(Environment.NewLine,
                            usuarios.Select(u => $"Nombre: {u.Nombre}, Apellido: {u.Apellido}, DNI: {u.Dni}, Correo: {u.Correo}"));

                        // Crear o actualizar el GroupBox y TextBox donde se mostrará la info

                        if (groupBoxLog == null)
                        {
                            groupBoxLog = new GroupBox();
                            groupBoxLog.Text = "Usuarios Deserializados";
                            groupBoxLog.Width = 600;
                            groupBoxLog.Height = 400;
                            groupBoxLog.Location = new Point(20, 50);
                            this.Controls.Add(groupBoxLog);

                            Label lblTitulo = new Label();
                            lblTitulo.Text = "Contenido deserializado:";
                            lblTitulo.Location = new Point(10, 20);
                            lblTitulo.AutoSize = true;
                            groupBoxLog.Controls.Add(lblTitulo);

                            TextBox txtUsuariosLog = new TextBox();
                            txtUsuariosLog.Name = "txtUsuariosLog";
                            txtUsuariosLog.Multiline = true;
                            txtUsuariosLog.ScrollBars = ScrollBars.Vertical;
                            txtUsuariosLog.ReadOnly = true;
                            txtUsuariosLog.Width = groupBoxLog.Width - 20;
                            txtUsuariosLog.Height = groupBoxLog.Height - 50;
                            txtUsuariosLog.Location = new Point(10, 45);
                            groupBoxLog.Controls.Add(txtUsuariosLog);
                        }

                        TextBox txtUsuariosLogBox = groupBoxLog.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "txtUsuariosLog");

                        if (txtUsuariosLogBox != null)
                        {
                            txtUsuariosLogBox.Text = contenido;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo deserializar el archivo JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir o procesar el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tsmTask_Click(object sender, EventArgs e)
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                MessageBox.Show("La tarea ya está en ejecución.");
                return;
            }

            lstUsuarios.Visible = true; // Mostrar el ListBox cuando se inicia la tarea

            cts = new CancellationTokenSource();

            try
            {
                await Task.Run(async () =>
                {
                    while (!cts.Token.IsCancellationRequested)
                    {
                        // Obtener usuarios desde la base
                        List<Usuario> usuarios = ADO.Instancia.ObtenerTodos();

                        // Invocar la actualización en el hilo UI
                        this.Invoke((MethodInvoker)(() =>
                        {
                            lstUsuarios.Items.Clear();

                            foreach (var u in usuarios)
                            {
                                lstUsuarios.Items.Add($"Nombre: {u.Nombre}, Apellido: {u.Apellido}, DNI: {u.Dni}, Correo: {u.Correo}");
                            }

                            // Alternar colores
                            if (colorInvertido)
                            {
                                lstUsuarios.BackColor = Color.White;
                                lstUsuarios.ForeColor = Color.Black;
                            }
                            else
                            {
                                lstUsuarios.BackColor = Color.Black;
                                lstUsuarios.ForeColor = Color.White;
                            }

                            colorInvertido = !colorInvertido;
                        }));

                        await Task.Delay(1500, cts.Token);
                    }
                }, cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Tarea cancelada, ignorar excepción
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la tarea: {ex.Message}");
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            openFileDialog1.FileName = "usuarios.log"; // Solo para configurar, no tiene 
            // Si lstUsuarios está declarado en el diseñador, solo ocúltalo así:
            lstUsuarios.Visible = false;
        }
    }
}
