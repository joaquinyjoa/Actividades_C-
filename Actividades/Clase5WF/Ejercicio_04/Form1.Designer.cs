namespace Ejercicio_04
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
            btnAgregar = new Button();
            txtIngreso = new TextBox();
            groupBox2 = new GroupBox();
            btnOrdenar = new Button();
            rdbDescender = new RadioButton();
            rdbAscender = new RadioButton();
            btnLimpiar = new Button();
            groupBox3 = new GroupBox();
            lbListaNumeros = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtIngreso);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 55);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese un nuevo numero";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(119, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(6, 22);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(100, 23);
            txtIngreso.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOrdenar);
            groupBox2.Controls.Add(rdbDescender);
            groupBox2.Controls.Add(rdbAscender);
            groupBox2.Location = new Point(12, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Orden";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(119, 40);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // rdbDescender
            // 
            rdbDescender.AutoSize = true;
            rdbDescender.Location = new Point(6, 56);
            rdbDescender.Name = "rdbDescender";
            rdbDescender.Size = new Size(80, 19);
            rdbDescender.TabIndex = 1;
            rdbDescender.Text = "Descender";
            rdbDescender.UseVisualStyleBackColor = true;
            // 
            // rdbAscender
            // 
            rdbAscender.AutoSize = true;
            rdbAscender.Checked = true;
            rdbAscender.Location = new Point(6, 31);
            rdbAscender.Name = "rdbAscender";
            rdbAscender.Size = new Size(74, 19);
            rdbAscender.TabIndex = 0;
            rdbAscender.TabStop = true;
            rdbAscender.Text = "Ascender";
            rdbAscender.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(18, 198);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(194, 32);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbListaNumeros);
            groupBox3.Location = new Point(221, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 218);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de numeros";
            // 
            // lbListaNumeros
            // 
            lbListaNumeros.FormattingEnabled = true;
            lbListaNumeros.ItemHeight = 15;
            lbListaNumeros.Location = new Point(6, 22);
            lbListaNumeros.Name = "lbListaNumeros";
            lbListaNumeros.Size = new Size(188, 184);
            lbListaNumeros.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 244);
            Controls.Add(groupBox3);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox txtIngreso;
        private GroupBox groupBox2;
        private RadioButton rdbDescender;
        private RadioButton rdbAscender;
        private Button btnOrdenar;
        private Button btnLimpiar;
        private GroupBox groupBox3;
        private ListBox lbListaNumeros;
    }
}
