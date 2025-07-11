namespace Ejercicio_03
{
    partial class FrmAltaModificacion
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
            txtObjeto = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtObjeto
            // 
            txtObjeto.Location = new Point(12, 22);
            txtObjeto.MaxLength = 50;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(420, 23);
            txtObjeto.TabIndex = 0;
            txtObjeto.KeyPress += txtObjeto_KeyPress;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(240, 64);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(357, 64);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAltaModificacion
            // 
            AcceptButton = btnConfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(444, 108);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtObjeto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAltaModificacion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObjeto;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}
