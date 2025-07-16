using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso(string titulo, string mensaje)
        {
            InitializeComponent();
            this.Text = titulo;
            this.lbl_titulo.Text = titulo;
            this.lbl_mensaje.Text = mensaje;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
