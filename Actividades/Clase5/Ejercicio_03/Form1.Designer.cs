namespace Ejercicio_03
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
            btnLimpiar = new Button();
            btnAceptar = new Button();
            txtTotal = new TextBox();
            txtDescuento = new TextBox();
            txtIngreso = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtDescuento);
            groupBox1.Controls.Add(txtIngreso);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 218);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(191, 164);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 40);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(40, 164);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 40);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(191, 110);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(128, 23);
            txtTotal.TabIndex = 5;
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(191, 80);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(128, 23);
            txtDescuento.TabIndex = 4;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(191, 45);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(128, 23);
            txtIngreso.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Total a pagar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 80);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Descuento recibido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 48);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese importe a cobrar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 242);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Descuento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTotal;
        private TextBox txtDescuento;
        private TextBox txtIngreso;
        private Button btnAceptar;
        private Button btnLimpiar;
    }
}
