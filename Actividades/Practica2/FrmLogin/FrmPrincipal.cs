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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmListadoCrud_Click(object sender, EventArgs e)
        {
            FrmListado frmListado = new FrmListado();
            this.Hide();
            frmListado.Show();
        }
    }
}
