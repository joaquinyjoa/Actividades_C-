using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ejercicio_03
{
    public partial class FrmListarSuper : Form
    {
        public List<string> listaSupermercado;

        public FrmListarSuper()
        {
            InitializeComponent();
            this.listaSupermercado = new List<string>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar objeto");
            this.toolTip2.SetToolTip(this.btnAgregar, "Agregar objeto");
            this.toolTip4.SetToolTip(this.btnModificar, "Modificar objeto");

            foreach (string producto in listaSupermercado)
            {
                this.lstObjetos.Items.Add(producto);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = "Agregar objeto";
            string btnConfirmar = "Agregar";
            FrmAltaModificacion altaModificacion = new FrmAltaModificacion(titulo, "", btnConfirmar);

            if (altaModificacion.ShowDialog() == DialogResult.OK)
            {
                // Tomo el texto ingresado y agrego a la lista
                listaSupermercado.Add(altaModificacion.Objeto);
                SerializarXML();
                Limpiar();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItems.Count > 0)
            {
                if (this.lstObjetos.SelectedIndex != -1)
                {
                    for (int i = 0; i < listaSupermercado.Count; i++)
                    {
                        if (listaSupermercado[i] == lstObjetos.SelectedItem.ToString())
                        {
                            listaSupermercado.Remove(lstObjetos.SelectedItem.ToString());
                            break;
                        }
                    }

                    SerializarXML();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un objeto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string titulo = "Modificar objeto";
            string btnModificar = "Modificar";
            int indice = this.lstObjetos.SelectedIndex;

            if (indice != -1)
            {
                string objeto = listaSupermercado[indice];
                FrmAltaModificacion altaModificacion = new FrmAltaModificacion(titulo, objeto, btnModificar);

                if (altaModificacion.ShowDialog() == DialogResult.OK)
                {
                    // Reemplaza el valor viejo por el nuevo
                    listaSupermercado[indice] = altaModificacion.Objeto;
                    SerializarXML();
                    Limpiar();
                    
                }

            }
            else
            {
                MessageBox.Show("Debe elegir un objeto para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public void Limpiar()
        {
            // Rompe el enlace anterior
            lstObjetos.DataSource = null;

            // Vuelve a asignar la lista como origen de datos
            lstObjetos.DataSource = listaSupermercado;
        }

        private void FrmListarSuper_Load(object sender, EventArgs e)
        {
            string rutaAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rutaArchivo = Path.Combine(rutaAppData, "listaSupermercado.xml");

            if (File.Exists(rutaArchivo))
            {
                using (StreamReader streamReader = new StreamReader(rutaArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

                    this.listaSupermercado = xmlSerializer.Deserialize(streamReader) as List<string>;

                    Limpiar();
                }
            }
        }

        public void SerializarXML () 
        {
            string rutaAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rutaArchivo = Path.Combine(rutaAppData, "listaSupermercado.xml");

            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo)) 
            {
                XmlSerializer xmlSerializer = new XmlSerializer (typeof(List<string>));

                xmlSerializer.Serialize(streamWriter, listaSupermercado);
            }
        }
    }
}
