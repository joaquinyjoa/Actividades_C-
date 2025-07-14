namespace WinFormsApp1
{
    partial class FrmAvisador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblNombreCompleto = new Label();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(86, 20);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 23);
            txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(28, 28);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(66, 161);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(105, 15);
            lblNombreCompleto.TabIndex = 4;
            lblNombreCompleto.Text = "Nombre completo";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(28, 116);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(203, 24);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FrmAvisador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(253, 204);
            Controls.Add(btnCrear);
            Controls.Add(lblNombreCompleto);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Name = "FrmAvisador";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblNombreCompleto;
        private Button btnCrear;
    }
}
