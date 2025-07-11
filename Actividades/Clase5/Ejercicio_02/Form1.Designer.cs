namespace Ejercicio_02
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            nudEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            groupBox2 = new GroupBox();
            rdbNoBinario = new RadioButton();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            groupBox3 = new GroupBox();
            chbJavaScript = new CheckBox();
            chbCPlasPlas = new CheckBox();
            chbCSharp = new CheckBox();
            lblPais = new Label();
            lbPaises = new ListBox();
            btnIngresar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudEdad);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblEdad);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del usuario";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(71, 109);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(132, 23);
            nudEdad.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(71, 68);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(132, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(71, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(132, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 111);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 71);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbNoBinario);
            groupBox2.Controls.Add(rdbFemenino);
            groupBox2.Controls.Add(rdbMasculino);
            groupBox2.Location = new Point(257, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(141, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Género";
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Location = new Point(6, 76);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(81, 19);
            rdbNoBinario.TabIndex = 2;
            rdbNoBinario.Text = "No binario";
            rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(6, 51);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 1;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Checked = true;
            rdbMasculino.Location = new Point(6, 26);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chbJavaScript);
            groupBox3.Controls.Add(chbCPlasPlas);
            groupBox3.Controls.Add(chbCSharp);
            groupBox3.Location = new Point(257, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(141, 103);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cursos";
            // 
            // chbJavaScript
            // 
            chbJavaScript.AutoSize = true;
            chbJavaScript.Location = new Point(6, 72);
            chbJavaScript.Name = "chbJavaScript";
            chbJavaScript.Size = new Size(78, 19);
            chbJavaScript.TabIndex = 2;
            chbJavaScript.Text = "JavaScript";
            chbJavaScript.UseVisualStyleBackColor = true;
            // 
            // chbCPlasPlas
            // 
            chbCPlasPlas.AutoSize = true;
            chbCPlasPlas.Location = new Point(6, 47);
            chbCPlasPlas.Name = "chbCPlasPlas";
            chbCPlasPlas.Size = new Size(50, 19);
            chbCPlasPlas.TabIndex = 1;
            chbCPlasPlas.Text = "C++";
            chbCPlasPlas.UseVisualStyleBackColor = true;
            // 
            // chbCSharp
            // 
            chbCSharp.AutoSize = true;
            chbCSharp.Checked = true;
            chbCSharp.CheckState = CheckState.Checked;
            chbCSharp.Location = new Point(6, 22);
            chbCSharp.Name = "chbCSharp";
            chbCSharp.Size = new Size(41, 19);
            chbCSharp.TabIndex = 0;
            chbCSharp.Text = "C#";
            chbCSharp.UseVisualStyleBackColor = true;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(12, 163);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 4;
            lblPais.Text = "Pais";
            // 
            // lbPaises
            // 
            lbPaises.FormattingEnabled = true;
            lbPaises.ItemHeight = 15;
            lbPaises.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lbPaises.Location = new Point(12, 181);
            lbPaises.Name = "lbPaises";
            lbPaises.Size = new Size(213, 94);
            lbPaises.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(257, 252);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(141, 23);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 291);
            Controls.Add(btnIngresar);
            Controls.Add(lbPaises);
            Controls.Add(lblPais);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblDireccion;
        private NumericUpDown nudEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private GroupBox groupBox2;
        private RadioButton rdbNoBinario;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private GroupBox groupBox3;
        private CheckBox chbJavaScript;
        private CheckBox chbCPlasPlas;
        private CheckBox chbCSharp;
        private Label lblPais;
        private ListBox lbPaises;
        private Button btnIngresar;
    }
}
