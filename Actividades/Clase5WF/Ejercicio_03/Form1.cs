namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.HasChildren)//valida si hay un control que tiene adentro otros controles
                {
                    //recorre los controladores del GroupBox
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is TextBox textBox2)
                        {
                            textBox2.Text = string.Empty;
                        }

                    }

                }

            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double ingreso = Convert.ToDouble(txtIngreso.Text);
            double primerDescuento = 0.10;
            double segundoDescuento = 0.20;
            double montoDescuento = 0;

            if (ingreso >= 3000 && ingreso <= 5000)
            {
                montoDescuento = ingreso * primerDescuento;
            }
            else if (ingreso > 5000)
            {
                montoDescuento = ingreso * segundoDescuento;
            }

            this.txtDescuento.Text = montoDescuento.ToString();

            this.txtTotal.Text = (ingreso - montoDescuento).ToString();
        }
    }
}
