namespace Ejercicio_01
{
    partial class FrmIngreso
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
            lbl_mensaje = new Label();
            lbl_titulo = new Label();
            SuspendLayout();
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Location = new Point(43, 40);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(38, 15);
            lbl_mensaje.TabIndex = 0;
            lbl_mensaje.Text = "label1";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(43, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(40, 15);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "label1";
            // 
            // FrmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 75);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_mensaje);
            Name = "FrmIngreso";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_mensaje;
        private Label lbl_titulo;
    }
}