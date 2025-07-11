namespace Ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.IsHandleCreated)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is TextBox textBox)
                        {
                            textBox.Text = string.Empty;
                        }

                        if (subControl is RadioButton radioButton)
                        {
                            radioButton.Checked = false;
                        }

                        if (subControl is ListBox listBox)
                        {
                            listBox.Items.Clear();
                        }

                    }
                }
            }
            this.rdbAscender.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(this.txtIngreso.Text);
            this.lbListaNumeros.Items.Add(numero.ToString());

            if (rdbAscender.Checked)
            {
                for (int i = 0; i < lbListaNumeros.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j <= lbListaNumeros.Items.Count - 1; j++)
                    {
                        int numI = Convert.ToInt32(lbListaNumeros.Items[i]);
                        int numJ = Convert.ToInt32(lbListaNumeros.Items[j]);
                        if (numJ > numI)
                        {
                            lbListaNumeros.Items[i] = numJ;
                            lbListaNumeros.Items[j] = numI;
                        }
                    }
                }
            }

            if (rdbDescender.Checked)
            {
                for (int i = 0; i < lbListaNumeros.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j < lbListaNumeros.Items.Count - 1; j++)
                    {
                        int numI = Convert.ToInt32(lbListaNumeros.Items[i]);
                        int numJ = Convert.ToInt32(lbListaNumeros.Items[j]);
                        if (numJ < numI)
                        {
                            lbListaNumeros.Items[i] = numJ;
                            lbListaNumeros.Items[j] = numI;
                        }
                    }
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rdbAscender.Checked)
            {
                for (int i = 0; i < lbListaNumeros.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j <= lbListaNumeros.Items.Count - 1; j++)
                    {
                        int numI = Convert.ToInt32(lbListaNumeros.Items[i]);
                        int numJ = Convert.ToInt32(lbListaNumeros.Items[j]);
                        if (numJ > numI)
                        {
                            lbListaNumeros.Items[i] = numJ;
                            lbListaNumeros.Items[j] = numI;
                        }
                    }
                }
            }

            if (rdbDescender.Checked)
            {
                for (int i = 0; i < lbListaNumeros.Items.Count - 1; i++)
                {
                    for (int j = i + 1; j <= lbListaNumeros.Items.Count - 1; j++)
                    {
                        int numI = Convert.ToInt32(lbListaNumeros.Items[i]);
                        int numJ = Convert.ToInt32(lbListaNumeros.Items[j]);
                        if (numJ < numI)
                        {
                            lbListaNumeros.Items[i] = numJ;
                            lbListaNumeros.Items[j] = numI;
                        }
                    }
                }
            }
        }
    }
}
