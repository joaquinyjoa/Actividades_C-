﻿namespace FrmLogin
{
    partial class FrmEnv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            btnEnviar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 182);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 71);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(12, 115);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(233, 23);
            txtDni.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 200);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(233, 23);
            txtCorreo.TabIndex = 8;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(12, 244);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(233, 23);
            txtContraseña.TabIndex = 9;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 273);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 34);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(170, 273);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmEnv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 319);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEnv";
            Text = "FrmEnv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Button btnEnviar;
        private Button btnCancelar;
    }
}