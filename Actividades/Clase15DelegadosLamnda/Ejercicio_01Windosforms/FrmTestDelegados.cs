using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01Windosforms
{
    public partial class FrmTestDelegados : Form
    {
        private DelegadoActualizar delegado;

        public FrmTestDelegados(DelegadoActualizar delegado)
        {
            InitializeComponent();
            this.delegado = delegado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.delegado != null)
            {
                this.delegado.Invoke(this.txtNombre.Text);
            }
        }
    }
}
